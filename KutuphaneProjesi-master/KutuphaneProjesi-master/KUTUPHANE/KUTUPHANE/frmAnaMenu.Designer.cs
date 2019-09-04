namespace KUTUPHANE
{
    partial class frmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaçAdetKitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alınanKitaplarRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kitapToolStripMenuItem,
            this.üyeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListesiRaporuToolStripMenuItem,
            this.üyeListesiRaporuToolStripMenuItem,
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem,
            this.kaçAdetKitapToolStripMenuItem,
            this.alınanKitaplarRaporuToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.toolStripMenuItem1.Text = "RAPORLAR";
            // 
            // kitapListesiRaporuToolStripMenuItem
            // 
            this.kitapListesiRaporuToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.notebook;
            this.kitapListesiRaporuToolStripMenuItem.Name = "kitapListesiRaporuToolStripMenuItem";
            this.kitapListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.kitapListesiRaporuToolStripMenuItem.Text = "Kitap Listesi ";
            this.kitapListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.KitapListesiRaporuToolStripMenuItem_Click);
            // 
            // üyeListesiRaporuToolStripMenuItem
            // 
            this.üyeListesiRaporuToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.list_with_possible_workers_to_choose;
            this.üyeListesiRaporuToolStripMenuItem.Name = "üyeListesiRaporuToolStripMenuItem";
            this.üyeListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.üyeListesiRaporuToolStripMenuItem.Text = "Üye Listesi ";
            this.üyeListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.ÜyeListesiRaporuToolStripMenuItem_Click);
            // 
            // bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem
            // 
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.clipboard_with_pencil_;
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Name = "bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem";
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Text = "Ödünç Verilen Kitaplar Listesi";
            this.bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.BütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem_Click);
            // 
            // kaçAdetKitapToolStripMenuItem
            // 
            this.kaçAdetKitapToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.list_roman_style_numbers;
            this.kaçAdetKitapToolStripMenuItem.Name = "kaçAdetKitapToolStripMenuItem";
            this.kaçAdetKitapToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.kaçAdetKitapToolStripMenuItem.Text = "Kitap Sayıları Listesi";
            this.kaçAdetKitapToolStripMenuItem.Click += new System.EventHandler(this.KaçAdetKitapToolStripMenuItem_Click);
            // 
            // alınanKitaplarRaporuToolStripMenuItem
            // 
            this.alınanKitaplarRaporuToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.checklist;
            this.alınanKitaplarRaporuToolStripMenuItem.Name = "alınanKitaplarRaporuToolStripMenuItem";
            this.alınanKitaplarRaporuToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.alınanKitaplarRaporuToolStripMenuItem.Text = "Tarihe Göre Listeleme";
            this.alınanKitaplarRaporuToolStripMenuItem.Click += new System.EventHandler(this.AlınanKitaplarRaporuToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.ödünçKitaplarToolStripMenuItem});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.kitapToolStripMenuItem.Text = "KİTAP İŞLEMLERİ";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.books_stack_of_three;
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.KitapEkleToolStripMenuItem_Click);
            // 
            // ödünçKitaplarToolStripMenuItem
            // 
            this.ödünçKitaplarToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.book;
            this.ödünçKitaplarToolStripMenuItem.Name = "ödünçKitaplarToolStripMenuItem";
            this.ödünçKitaplarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ödünçKitaplarToolStripMenuItem.Text = "Ödünç Kitaplar";
            this.ödünçKitaplarToolStripMenuItem.Click += new System.EventHandler(this.ÖdünçKitaplarToolStripMenuItem_Click);
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeEkleToolStripMenuItem});
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.üyeToolStripMenuItem.Text = "ÜYE İŞLEMLERİ";
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Image = global::KUTUPHANE.Properties.Resources.multiple_users_silhouette;
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.ÜyeEkleToolStripMenuItem_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 483);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bütünÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaçAdetKitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alınanKitaplarRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeEkleToolStripMenuItem;
    }
}