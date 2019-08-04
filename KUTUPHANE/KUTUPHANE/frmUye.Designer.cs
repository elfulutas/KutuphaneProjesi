namespace KUTUPHANE
{
    partial class frmUye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUye));
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDURUMU = new System.Windows.Forms.ComboBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTELEFON = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtACIKLAMA = new System.Windows.Forms.TextBox();
            this.dtEKLEME_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.txtADRES = new System.Windows.Forms.TextBox();
            this.txtADI_SOYAD = new System.Windows.Forms.TextBox();
            this.txtUYE_REFNO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 41;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 490);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 222);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 39;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 38;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 37;
            this.button1.Text = "Yeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::KUTUPHANE.Properties.Resources.error;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(705, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 35);
            this.button5.TabIndex = 46;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDURUMU);
            this.groupBox1.Controls.Add(this.txtEMAIL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTELEFON);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtACIKLAMA);
            this.groupBox1.Controls.Add(this.dtEKLEME_TARIHI);
            this.groupBox1.Controls.Add(this.txtADRES);
            this.groupBox1.Controls.Add(this.txtADI_SOYAD);
            this.groupBox1.Controls.Add(this.txtUYE_REFNO);
            this.groupBox1.Location = new System.Drawing.Point(37, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 425);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // cmbDURUMU
            // 
            this.cmbDURUMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDURUMU.FormattingEnabled = true;
            this.cmbDURUMU.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbDURUMU.Location = new System.Drawing.Point(138, 281);
            this.cmbDURUMU.Name = "cmbDURUMU";
            this.cmbDURUMU.Size = new System.Drawing.Size(200, 24);
            this.cmbDURUMU.TabIndex = 61;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(138, 197);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(200, 22);
            this.txtEMAIL.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Email";
            // 
            // txtTELEFON
            // 
            this.txtTELEFON.Location = new System.Drawing.Point(138, 155);
            this.txtTELEFON.Name = "txtTELEFON";
            this.txtTELEFON.Size = new System.Drawing.Size(200, 22);
            this.txtTELEFON.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ekleme Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Üye Refno";
            // 
            // txtACIKLAMA
            // 
            this.txtACIKLAMA.Location = new System.Drawing.Point(138, 323);
            this.txtACIKLAMA.Multiline = true;
            this.txtACIKLAMA.Name = "txtACIKLAMA";
            this.txtACIKLAMA.Size = new System.Drawing.Size(200, 73);
            this.txtACIKLAMA.TabIndex = 50;
            // 
            // dtEKLEME_TARIHI
            // 
            this.dtEKLEME_TARIHI.Location = new System.Drawing.Point(138, 239);
            this.dtEKLEME_TARIHI.Name = "dtEKLEME_TARIHI";
            this.dtEKLEME_TARIHI.Size = new System.Drawing.Size(200, 22);
            this.dtEKLEME_TARIHI.TabIndex = 49;
            // 
            // txtADRES
            // 
            this.txtADRES.Location = new System.Drawing.Point(138, 113);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(200, 22);
            this.txtADRES.TabIndex = 48;
            // 
            // txtADI_SOYAD
            // 
            this.txtADI_SOYAD.Location = new System.Drawing.Point(138, 71);
            this.txtADI_SOYAD.Name = "txtADI_SOYAD";
            this.txtADI_SOYAD.Size = new System.Drawing.Size(200, 22);
            this.txtADI_SOYAD.TabIndex = 47;
            // 
            // txtUYE_REFNO
            // 
            this.txtUYE_REFNO.Location = new System.Drawing.Point(138, 29);
            this.txtUYE_REFNO.Name = "txtUYE_REFNO";
            this.txtUYE_REFNO.ReadOnly = true;
            this.txtUYE_REFNO.Size = new System.Drawing.Size(200, 22);
            this.txtUYE_REFNO.TabIndex = 46;
            // 
            // frmUye
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
            this.Name = "frmUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.ComboBox cmbDURUMU;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTELEFON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtACIKLAMA;
        private System.Windows.Forms.DateTimePicker dtEKLEME_TARIHI;
        private System.Windows.Forms.TextBox txtADRES;
        private System.Windows.Forms.TextBox txtADI_SOYAD;
        private System.Windows.Forms.TextBox txtUYE_REFNO;
    }
}