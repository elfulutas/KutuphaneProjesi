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
    public partial class frmKitap : Form
    {//1.AŞAMA
        KUTUPHANEEntities db = new KUTUPHANEEntities();
        int satir = -1;
        public frmKitap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//1.AŞAMA
            var liste = db.KITAPs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {//2.AŞAMA
            satir = e.RowIndex;
            if (satir>-1)
            {
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtOZET.Text = dataGridView1.Rows[satir].Cells["OZET"].Value.ToString();
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dtBASIM_TARIHI.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {//3a. aşama yeni
            txtADI.Text = "";
            txtISBN.Text = "";
            txtKITAP_REFNO.Text ="";
            txtOZET.Text = "";
            txtYAYIN_EVI.Text = "";
            txtYAZARI.Text = "";
            dtBASIM_TARIHI.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {//3b. aşama vazgeç
            if (satir > -1)
            {
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtOZET.Text = dataGridView1.Rows[satir].Cells["OZET"].Value.ToString();
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dtBASIM_TARIHI.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {//3c. aşama kaydet
            KITAP k = new KITAP();
            if (txtKITAP_REFNO.Text != "")
            {
                kontrol();
                k = db.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                k.ADI = txtADI.Text;
                k.ISBN = txtISBN.Text;
                k.OZET = txtOZET.Text;
                k.YAYIN_EVI = txtYAYIN_EVI.Text;
                k.YAZARI = txtYAZARI.Text;
                k.BASIM_TARIHI = dtBASIM_TARIHI.Value;
                db.SaveChanges();

            }
            else
            {
                kontrol();
                k.ADI = txtADI.Text;
                k.ISBN = txtISBN.Text;
                k.OZET = txtOZET.Text;
                k.YAYIN_EVI = txtYAYIN_EVI.Text;
                k.YAZARI = txtYAZARI.Text;
                k.BASIM_TARIHI = dtBASIM_TARIHI.Value;
                db.KITAPs.Add(k);
                db.SaveChanges();
            }
            var liste = db.KITAPs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button4_Click(object sender, EventArgs e)
        {//3d. aşama sil
            if (txtKITAP_REFNO.Text!="")
            {
                KITAP k = new KITAP();
                k = db.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                db.KITAPs.Remove(k);
                db.SaveChanges();
                var liste = db.KITAPs.ToList();
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
            if (txtADI.Text == "" || txtISBN.Text == "" || txtYAYIN_EVI.Text == "" || txtYAZARI.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız!", "Hata");
            }
        }
    }
}
