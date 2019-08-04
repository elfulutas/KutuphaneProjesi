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
    public partial class frmUye : Form
    {
        KUTUPHANEEntities db = new KUTUPHANEEntities();
        int satir = -1;
        public frmUye()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var liste = db.UYEs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                txtADI_SOYAD.Text = dataGridView1.Rows[satir].Cells["ADI_SOYAD"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
                txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
                txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
                txtUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                dtEKLEME_TARIHI.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
                string cmbKontrol = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
                if (cmbKontrol == "True")
                {
                    cmbDURUMU.Text = "Aktif";
                }
                if (cmbKontrol == "False")
                {
                    cmbDURUMU.Text = "Pasif";
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {//YENİ
            txtUYE_REFNO.Text = "";
            txtACIKLAMA.Text = "";
            txtADI_SOYAD.Text = "";
            txtADRES.Text = "";
            cmbDURUMU.Text = "";
            txtEMAIL.Text = "";
            txtTELEFON.Text = "";
            dtEKLEME_TARIHI.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {//VAZGEÇ
            txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            txtADI_SOYAD.Text = dataGridView1.Rows[satir].Cells["ADI_SOYAD"].Value.ToString();
            txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
            txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
            txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
            dtEKLEME_TARIHI.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
            string cmbKontrol = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            if (cmbKontrol== "True")
            {
                cmbDURUMU.Text = "Aktif";
            }
            if (cmbKontrol == "False")
            {
                cmbDURUMU.Text = "Pasif";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {//KAYDET
            UYE u = new UYE();
            if (txtUYE_REFNO.Text != "")
            {
                kontrol();
                u = db.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                u.ACIKLAMA = txtACIKLAMA.Text;
                u.ADI_SOYAD = txtADI_SOYAD.Text;
                u.ADRES = txtADRES.Text;
                u.EMAIL = txtEMAIL.Text;
                u.TELEFON = txtTELEFON.Text;
                u.EKLEME_TARIHI = dtEKLEME_TARIHI.Value;
                if (cmbDURUMU.Text=="Aktif")
                {
                    u.DURUMU = Convert.ToBoolean(true);
                }
                else if(cmbDURUMU.Text == "Pasif")
                {
                    u.DURUMU = Convert.ToBoolean(false);
                }
                db.SaveChanges();
            }
            else
            {
                kontrol();
                u.ACIKLAMA = txtACIKLAMA.Text;
                u.ADI_SOYAD = txtADI_SOYAD.Text;
                u.ADRES = txtADRES.Text;
                u.EMAIL = txtEMAIL.Text;
                u.TELEFON = txtTELEFON.Text;
                u.EKLEME_TARIHI = dtEKLEME_TARIHI.Value;
                if (cmbDURUMU.Text == "Aktif")
                {
                    u.DURUMU = Convert.ToBoolean(true);
                }
                else if (cmbDURUMU.Text == "Pasif")
                {
                    u.DURUMU = Convert.ToBoolean(false);
                }
                db.UYEs.Add(u);
                db.SaveChanges();
            }
            var liste = db.UYEs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button4_Click(object sender, EventArgs e)
        {//SİL
            if (txtUYE_REFNO.Text != "")
            {
                UYE u = new UYE();
                u = db.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                db.UYEs.Remove(u);
                db.SaveChanges();
                var liste = db.UYEs.ToList();
                dataGridView1.DataSource = liste;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnaMenu frm = new frmAnaMenu();
            frm.Show();
        }
        void kontrol()
        {
            if (txtACIKLAMA.Text == "" || txtADI_SOYAD.Text == "" || txtADRES.Text == "" || txtEMAIL.Text == "" || txtTELEFON.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız!", "Hata");
            }
        }
    }
}