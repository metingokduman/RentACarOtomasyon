namespace UI
{
    partial class CarAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarAdd));
            this.pnlAdCarInf = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGunlukUcret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKmBilgisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelYili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaseNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnCarImageAdd = new System.Windows.Forms.Button();
            this.pctrBocCarImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAdCarInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBocCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdCarInf
            // 
            this.pnlAdCarInf.Controls.Add(this.label11);
            this.pnlAdCarInf.Controls.Add(this.txtGunlukUcret);
            this.pnlAdCarInf.Controls.Add(this.label1);
            this.pnlAdCarInf.Controls.Add(this.txtMarka);
            this.pnlAdCarInf.Controls.Add(this.txtModel);
            this.pnlAdCarInf.Controls.Add(this.label5);
            this.pnlAdCarInf.Controls.Add(this.txtKmBilgisi);
            this.pnlAdCarInf.Controls.Add(this.label4);
            this.pnlAdCarInf.Controls.Add(this.txtModelYili);
            this.pnlAdCarInf.Controls.Add(this.label3);
            this.pnlAdCarInf.Controls.Add(this.txtSaseNo);
            this.pnlAdCarInf.Controls.Add(this.label2);
            this.pnlAdCarInf.Location = new System.Drawing.Point(12, 12);
            this.pnlAdCarInf.Name = "pnlAdCarInf";
            this.pnlAdCarInf.Size = new System.Drawing.Size(235, 192);
            this.pnlAdCarInf.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "GünlükUcret :";
            // 
            // txtGunlukUcret
            // 
            this.txtGunlukUcret.Location = new System.Drawing.Point(94, 144);
            this.txtGunlukUcret.Name = "txtGunlukUcret";
            this.txtGunlukUcret.Size = new System.Drawing.Size(116, 20);
            this.txtGunlukUcret.TabIndex = 5;
            this.txtGunlukUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunlukUcret_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka :";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(94, 16);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(116, 20);
            this.txtMarka.TabIndex = 0;
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(94, 42);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(116, 20);
            this.txtModel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "ŞasiNO :";
            // 
            // txtKmBilgisi
            // 
            this.txtKmBilgisi.Location = new System.Drawing.Point(94, 67);
            this.txtKmBilgisi.Name = "txtKmBilgisi";
            this.txtKmBilgisi.Size = new System.Drawing.Size(116, 20);
            this.txtKmBilgisi.TabIndex = 2;
            this.txtKmBilgisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunlukUcret_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "ModelYılı :";
            // 
            // txtModelYili
            // 
            this.txtModelYili.Location = new System.Drawing.Point(94, 93);
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(116, 20);
            this.txtModelYili.TabIndex = 3;
            this.txtModelYili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunlukUcret_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "KmBilgisi :";
            // 
            // txtSaseNo
            // 
            this.txtSaseNo.Location = new System.Drawing.Point(94, 119);
            this.txtSaseNo.Name = "txtSaseNo";
            this.txtSaseNo.Size = new System.Drawing.Size(116, 20);
            this.txtSaseNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model :";
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.BackColor = System.Drawing.Color.White;
            this.btnCarAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCarAdd.Location = new System.Drawing.Point(282, 210);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(239, 61);
            this.btnCarAdd.TabIndex = 6;
            this.btnCarAdd.Text = "KAYDET";
            this.btnCarAdd.UseVisualStyleBackColor = false;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Red;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Snow;
            this.btnGoBack.Location = new System.Drawing.Point(12, 264);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(241, 51);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "YÖNETİCİ KONTROL EKRANINA GERİ DÖN";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnCarImageAdd
            // 
            this.btnCarImageAdd.BackColor = System.Drawing.Color.White;
            this.btnCarImageAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarImageAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCarImageAdd.Location = new System.Drawing.Point(12, 210);
            this.btnCarImageAdd.Name = "btnCarImageAdd";
            this.btnCarImageAdd.Size = new System.Drawing.Size(241, 44);
            this.btnCarImageAdd.TabIndex = 13;
            this.btnCarImageAdd.Text = "FOTOĞRAF EKLE";
            this.btnCarImageAdd.UseVisualStyleBackColor = false;
            this.btnCarImageAdd.Click += new System.EventHandler(this.btnCarImageAdd_Click);
            // 
            // pctrBocCarImage
            // 
            this.pctrBocCarImage.BackColor = System.Drawing.Color.Red;
            this.pctrBocCarImage.Image = ((System.Drawing.Image)(resources.GetObject("pctrBocCarImage.Image")));
            this.pctrBocCarImage.Location = new System.Drawing.Point(282, 12);
            this.pctrBocCarImage.Name = "pctrBocCarImage";
            this.pctrBocCarImage.Size = new System.Drawing.Size(239, 192);
            this.pctrBocCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBocCarImage.TabIndex = 14;
            this.pctrBocCarImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "**Fotoğraf ekle butonuna her tıklandığında\r\n siteme araba fotoğrafı eklenecektir";
            // 
            // CarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(576, 327);
            this.Controls.Add(this.pctrBocCarImage);
            this.Controls.Add(this.btnCarImageAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.pnlAdCarInf);
            this.Controls.Add(this.btnCarAdd);
            this.Name = "CarAdd";
            this.Text = "ARAÇ EKLEME EKRANI";
            this.Load += new System.EventHandler(this.AdminAddCar_Load);
            this.pnlAdCarInf.ResumeLayout(false);
            this.pnlAdCarInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBocCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdCarInf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGunlukUcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKmBilgisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelYili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaseNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnCarImageAdd;
        private System.Windows.Forms.PictureBox pctrBocCarImage;
        private System.Windows.Forms.Label label6;
    }
}