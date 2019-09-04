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
    public partial class frmOdunc : Form
    {
        KUTUPHANEEntities db = new KUTUPHANEEntities();
        List<KITAP> listemkitap = new List<KITAP>();
        List<UYE> listemuye = new List<UYE>();
        int satir = -1;
        public frmOdunc()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
            var liste = db.ODUNC_KITAP.ToList();
            dataGridView1.DataSource = liste;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                txtODUNC_KITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value.ToString();
                cmbKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                cmbUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                //dtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
                dtVERILIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value.ToString();
                string cmbKontrol = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
                if (cmbKontrol == "True")
                {
                    cmbDURUMU.Text = "Alındı";
                    dtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
                }
                if (cmbKontrol == "False")
                {
                    cmbDURUMU.Text = "Ödünç Verildi";
                    dtALINIS_TARIHI.Text = null;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {//YENİ
            txtODUNC_KITAP_REFNO.Text = "";
            txtACIKLAMA.Text = "";
            cmbKITAP_REFNO.Text = "";
            cmbUYE_REFNO.Text = "";
            cmbDURUMU.Text = "";
            dtALINIS_TARIHI.Text = "";
            dtVERILIS_TARIHI.Text = "";

        }

        private void Button3_Click(object sender, EventArgs e)
        {//VAZGEÇ
            txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            cmbKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
            cmbUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
            dtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
            dtVERILIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["dtVERILIS_TARIHI"].Value.ToString();
            string cmbKontrol = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            if (Convert.ToInt32(cmbKontrol) == 1)
            {
                cmbDURUMU.Text = "Alındı";
                dtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
            }
            if (Convert.ToInt32(cmbKontrol) == 0)
            {
                cmbDURUMU.Text = "Ödünç Verildi";
                dtALINIS_TARIHI.Text = null;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {//KAYDET
            ODUNC_KITAP o = new ODUNC_KITAP();
            if (txtACIKLAMA.Text == "" || cmbDURUMU.Text == "" || cmbKITAP_REFNO.Text == "" || cmbUYE_REFNO.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız!", "Hata");
            }
            else
            {
                if (txtODUNC_KITAP_REFNO.Text != "")
                {
                    o = db.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));
                    o.ACIKLAMA = txtACIKLAMA.Text;
                    o.KITAP_REFNO = Convert.ToInt32(cmbKITAP_REFNO.Text);
                    o.UYE_REFNO = cmbUYE_REFNO.Text;

                    o.VERILIS_TARIHI = dtVERILIS_TARIHI.Value;
                    if (cmbDURUMU.Text == "Alındı")
                    {
                        o.DURUMU = Convert.ToBoolean(true);
                        o.ALINIS_TARIHI = dtALINIS_TARIHI.Value;
                    }
                    else if (cmbDURUMU.Text == "Ödünç Verildi")
                    {
                        o.DURUMU = Convert.ToBoolean(false);
                        o.ALINIS_TARIHI = null;
                    }
                    db.SaveChanges();
                }
                else
                {
                    o.ACIKLAMA = txtACIKLAMA.Text;
                    o.KITAP_REFNO = Convert.ToInt32(cmbKITAP_REFNO.Text);
                    o.UYE_REFNO = cmbUYE_REFNO.Text;

                    o.VERILIS_TARIHI = dtVERILIS_TARIHI.Value;
                    if (cmbDURUMU.Text == "Alındı")
                    {
                        o.DURUMU = Convert.ToBoolean(true);
                        o.ALINIS_TARIHI = dtALINIS_TARIHI.Value;
                    }
                    else if (cmbDURUMU.Text == "Ödünç Verildi")
                    {
                        o.DURUMU = Convert.ToBoolean(false);
                        o.ALINIS_TARIHI = null;
                    }
                    db.ODUNC_KITAP.Add(o);
                    db.SaveChanges();
                }
            }
            var liste = db.ODUNC_KITAP.ToList();
            dataGridView1.DataSource = liste;

        }
        void comboboxDoldur()
        {
            listemkitap = db.KITAPs.ToList();
            foreach (var item in listemkitap)
            {
                cmbKITAP_REFNO.Items.Add(item.KITAP_REFNO);
            }
            listemuye = db.UYEs.ToList();
            foreach (var item in listemuye)
            {
                cmbUYE_REFNO.Items.Add(item.ADI_SOYAD);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnaMenu frm = new frmAnaMenu();
            frm.Show();
        }
    }
    
}
