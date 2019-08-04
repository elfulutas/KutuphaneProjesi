namespace KUTUPHANE
{
    partial class frmOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdunc));
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtACIKLAMA = new System.Windows.Forms.TextBox();
            this.cmbDURUMU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtALINIS_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtVERILIS_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.cmbKITAP_REFNO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUYE_REFNO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtODUNC_KITAP_REFNO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(527, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 62;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 461);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 222);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 60;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 59;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 58;
            this.button1.Text = "Yeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::KUTUPHANE.Properties.Resources.error;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(705, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 35);
            this.button5.TabIndex = 75;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtACIKLAMA);
            this.groupBox1.Controls.Add(this.cmbDURUMU);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtALINIS_TARIHI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtVERILIS_TARIHI);
            this.groupBox1.Controls.Add(this.cmbKITAP_REFNO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUYE_REFNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtODUNC_KITAP_REFNO);
            this.groupBox1.Location = new System.Drawing.Point(37, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 423);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 88;
            this.label7.Text = "Açıklama";
            // 
            // txtACIKLAMA
            // 
            this.txtACIKLAMA.Location = new System.Drawing.Point(151, 319);
            this.txtACIKLAMA.Multiline = true;
            this.txtACIKLAMA.Name = "txtACIKLAMA";
            this.txtACIKLAMA.Size = new System.Drawing.Size(200, 73);
            this.txtACIKLAMA.TabIndex = 87;
            // 
            // cmbDURUMU
            // 
            this.cmbDURUMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDURUMU.FormattingEnabled = true;
            this.cmbDURUMU.Items.AddRange(new object[] {
            "Alındı",
            "Ödünç Verildi"});
            this.cmbDURUMU.Location = new System.Drawing.Point(150, 268);
            this.cmbDURUMU.Name = "cmbDURUMU";
            this.cmbDURUMU.Size = new System.Drawing.Size(200, 24);
            this.cmbDURUMU.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Alınış Tarihi";
            // 
            // dtALINIS_TARIHI
            // 
            this.dtALINIS_TARIHI.Location = new System.Drawing.Point(150, 219);
            this.dtALINIS_TARIHI.Name = "dtALINIS_TARIHI";
            this.dtALINIS_TARIHI.Size = new System.Drawing.Size(200, 22);
            this.dtALINIS_TARIHI.TabIndex = 83;
            this.dtALINIS_TARIHI.Value = new System.DateTime(2019, 8, 3, 20, 1, 39, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Veriliş Tarihi";
            // 
            // dtVERILIS_TARIHI
            // 
            this.dtVERILIS_TARIHI.Location = new System.Drawing.Point(151, 170);
            this.dtVERILIS_TARIHI.Name = "dtVERILIS_TARIHI";
            this.dtVERILIS_TARIHI.Size = new System.Drawing.Size(200, 22);
            this.dtVERILIS_TARIHI.TabIndex = 81;
            // 
            // cmbKITAP_REFNO
            // 
            this.cmbKITAP_REFNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKITAP_REFNO.FormattingEnabled = true;
            this.cmbKITAP_REFNO.Location = new System.Drawing.Point(151, 119);
            this.cmbKITAP_REFNO.Name = "cmbKITAP_REFNO";
            this.cmbKITAP_REFNO.Size = new System.Drawing.Size(199, 24);
            this.cmbKITAP_REFNO.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Kitap Refno";
            // 
            // cmbUYE_REFNO
            // 
            this.cmbUYE_REFNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUYE_REFNO.FormattingEnabled = true;
            this.cmbUYE_REFNO.Location = new System.Drawing.Point(151, 68);
            this.cmbUYE_REFNO.Name = "cmbUYE_REFNO";
            this.cmbUYE_REFNO.Size = new System.Drawing.Size(199, 24);
            this.cmbUYE_REFNO.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Üye Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Ödünç Kitap Refno";
            // 
            // txtODUNC_KITAP_REFNO
            // 
            this.txtODUNC_KITAP_REFNO.Location = new System.Drawing.Point(151, 19);
            this.txtODUNC_KITAP_REFNO.Name = "txtODUNC_KITAP_REFNO";
            this.txtODUNC_KITAP_REFNO.ReadOnly = true;
            this.txtODUNC_KITAP_REFNO.Size = new System.Drawing.Size(200, 22);
            this.txtODUNC_KITAP_REFNO.TabIndex = 75;
            // 
            // frmOdunc
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
            this.Name = "frmOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitaplar";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtACIKLAMA;
        private System.Windows.Forms.ComboBox cmbDURUMU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtALINIS_TARIHI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtVERILIS_TARIHI;
        private System.Windows.Forms.ComboBox cmbKITAP_REFNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUYE_REFNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtODUNC_KITAP_REFNO;
    }
}