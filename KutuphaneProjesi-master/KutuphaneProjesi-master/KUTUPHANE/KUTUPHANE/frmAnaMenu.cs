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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }
       
        private void KitapListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapList frm = new frmKitapList();
            frm.ShowDialog();
            this.Hide();
        }

        private void ÜyeListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeList frm = new frmUyeList();
            frm.ShowDialog();
            this.Hide();
        }

        private void KaçAdetKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapSayilari frm = new frmKitapSayilari();
            frm.ShowDialog();
            this.Hide();
        }

        private void AlınanKitaplarRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarihList frm = new frmTarihList();
            frm.ShowDialog();
            this.Hide();
        }

        private void KitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitap frm = new frmKitap();
            frm.ShowDialog();
            this.Hide();
        }

        private void ÖdünçKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdunc frm = new frmOdunc();
            frm.ShowDialog();
            this.Hide();
        }

        private void ÜyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUye frm = new frmUye();
            frm.ShowDialog();
            this.Hide();
        }

        private void BütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOduncList frm = new frmOduncList();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
