using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    public partial class frmUyeList : Form
    {
        KUTUPHANEEntities db = new KUTUPHANEEntities();
        int ToplamSatir = 0;
        int SayfadakiSatir = 20;
        int ToplamSayfa = 0;
        int AktifSayfa = 1;
        public frmUyeList()
        {
            InitializeComponent();
        }

        private void FrmUyeList_Load(object sender, EventArgs e)
        {
            ToplamSatir = db.UYEs.Count();
            ToplamSayfa = ToplamSatir / SayfadakiSatir;
            if (ToplamSatir % SayfadakiSatir != 0) ToplamSayfa++;
            sorgula();
            sutunGizle();
        }
        void sorgula()
        {
            var liste = db.UYEs.OrderBy(u => u.UYE_REFNO).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button1_Click(object sender, EventArgs e)
        {//excele aktar
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet 
            try
            {
                worksheet = workbook.Sheets["Sheet1"];
            }
            catch (Exception)
            {
                worksheet = workbook.Sheets["Sayfa1"];
            }

            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            try
            {

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            // app.Quit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {//ilk sayfa
            AktifSayfa = 1;
            sorgula();
            sutunGizle();
        }

        private void Button2_Click(object sender, EventArgs e)
        {//geri
            if (AktifSayfa > 1)
            {
                AktifSayfa--;
                sorgula();
                sutunGizle();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {//ileri
            if (AktifSayfa < ToplamSayfa)
            {
                AktifSayfa++;
                sorgula();
                sutunGizle();
            }

        }
        private void Button4_Click(object sender, EventArgs e)
        {//son sayfa
            AktifSayfa = ToplamSayfa;
            sorgula();
            sutunGizle();
        }
        void sutunGizle()
        {
            dataGridView1.Columns[0].Visible = false;//uye refno 
            dataGridView1.Columns[5].Visible = false;//ekleme tarihi
            dataGridView1.Columns[7].Visible = false;//açıklama bilgisi gizlendi
            baslıkDuzenle();
        }
        void baslıkDuzenle()
        {
            dataGridView1.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Adres";
            dataGridView1.Columns[3].HeaderText = "Telefon";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Durumu";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnaMenu frm = new frmAnaMenu();
            frm.Show();
        }

    }
}
