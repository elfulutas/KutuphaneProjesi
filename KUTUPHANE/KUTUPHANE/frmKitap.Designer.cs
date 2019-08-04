namespace KUTUPHANE
{
    partial class frmKitap
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitap));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYAZARI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOZET = new System.Windows.Forms.TextBox();
            this.txtYAYIN_EVI = new System.Windows.Forms.TextBox();
            this.dtBASIM_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtADI = new System.Windows.Forms.TextBox();
            this.txtKITAP_REFNO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Yeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 447);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 222);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(503, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 18;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::KUTUPHANE.Properties.Resources.error;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(704, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 35);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYAZARI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOZET);
            this.groupBox1.Controls.Add(this.txtYAYIN_EVI);
            this.groupBox1.Controls.Add(this.dtBASIM_TARIHI);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtADI);
            this.groupBox1.Controls.Add(this.txtKITAP_REFNO);
            this.groupBox1.Location = new System.Drawing.Point(47, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 404);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtYAZARI
            // 
            this.txtYAZARI.Location = new System.Drawing.Point(156, 160);
            this.txtYAZARI.Name = "txtYAZARI";
            this.txtYAZARI.Size = new System.Drawing.Size(200, 22);
            this.txtYAZARI.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Özet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Yayın Evi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Basım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kitap Refno";
            // 
            // txtOZET
            // 
            this.txtOZET.Location = new System.Drawing.Point(156, 303);
            this.txtOZET.Multiline = true;
            this.txtOZET.Name = "txtOZET";
            this.txtOZET.Size = new System.Drawing.Size(200, 73);
            this.txtOZET.TabIndex = 29;
            // 
            // txtYAYIN_EVI
            // 
            this.txtYAYIN_EVI.Location = new System.Drawing.Point(156, 259);
            this.txtYAYIN_EVI.Name = "txtYAYIN_EVI";
            this.txtYAYIN_EVI.Size = new System.Drawing.Size(200, 22);
            this.txtYAYIN_EVI.TabIndex = 28;
            // 
            // dtBASIM_TARIHI
            // 
            this.dtBASIM_TARIHI.Location = new System.Drawing.Point(156, 212);
            this.dtBASIM_TARIHI.Name = "dtBASIM_TARIHI";
            this.dtBASIM_TARIHI.Size = new System.Drawing.Size(200, 22);
            this.dtBASIM_TARIHI.TabIndex = 27;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(156, 115);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 22);
            this.txtISBN.TabIndex = 26;
            // 
            // txtADI
            // 
            this.txtADI.Location = new System.Drawing.Point(156, 70);
            this.txtADI.Name = "txtADI";
            this.txtADI.Size = new System.Drawing.Size(200, 22);
            this.txtADI.TabIndex = 25;
            // 
            // txtKITAP_REFNO
            // 
            this.txtKITAP_REFNO.Location = new System.Drawing.Point(156, 28);
            this.txtKITAP_REFNO.Name = "txtKITAP_REFNO";
            this.txtKITAP_REFNO.ReadOnly = true;
            this.txtKITAP_REFNO.Size = new System.Drawing.Size(200, 22);
            this.txtKITAP_REFNO.TabIndex = 24;
            // 
            // frmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYAZARI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOZET;
        private System.Windows.Forms.TextBox txtYAYIN_EVI;
        private System.Windows.Forms.DateTimePicker dtBASIM_TARIHI;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtADI;
        private System.Windows.Forms.TextBox txtKITAP_REFNO;
    }
}

