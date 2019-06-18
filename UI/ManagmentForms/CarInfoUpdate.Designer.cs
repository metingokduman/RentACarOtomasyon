namespace UI
{
    partial class CarInfoUpdate
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
            this.pnlUpdatePrice = new System.Windows.Forms.Panel();
            this.txtKmBilgisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGunlukUcret = new System.Windows.Forms.TextBox();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.dtgrdUpdateCar = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pnlUpdatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdUpdateCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpdatePrice
            // 
            this.pnlUpdatePrice.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlUpdatePrice.Controls.Add(this.txtKmBilgisi);
            this.pnlUpdatePrice.Controls.Add(this.label3);
            this.pnlUpdatePrice.Controls.Add(this.label11);
            this.pnlUpdatePrice.Controls.Add(this.txtGunlukUcret);
            this.pnlUpdatePrice.Location = new System.Drawing.Point(21, 12);
            this.pnlUpdatePrice.Name = "pnlUpdatePrice";
            this.pnlUpdatePrice.Size = new System.Drawing.Size(453, 109);
            this.pnlUpdatePrice.TabIndex = 12;
            // 
            // txtKmBilgisi
            // 
            this.txtKmBilgisi.Location = new System.Drawing.Point(132, 70);
            this.txtKmBilgisi.Name = "txtKmBilgisi";
            this.txtKmBilgisi.Size = new System.Drawing.Size(306, 20);
            this.txtKmBilgisi.TabIndex = 1;
            this.txtKmBilgisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunlukUcret_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "KmBilgisi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "GünlükUcret :";
            // 
            // txtGunlukUcret
            // 
            this.txtGunlukUcret.Location = new System.Drawing.Point(132, 12);
            this.txtGunlukUcret.Name = "txtGunlukUcret";
            this.txtGunlukUcret.Size = new System.Drawing.Size(306, 20);
            this.txtGunlukUcret.TabIndex = 0;
            this.txtGunlukUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunlukUcret_KeyPress);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.Color.White;
            this.btnUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCar.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCar.Location = new System.Drawing.Point(480, 12);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(141, 48);
            this.btnUpdateCar.TabIndex = 2;
            this.btnUpdateCar.Text = "GÜNCELLE";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // dtgrdUpdateCar
            // 
            this.dtgrdUpdateCar.BackgroundColor = System.Drawing.Color.White;
            this.dtgrdUpdateCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdUpdateCar.Location = new System.Drawing.Point(21, 141);
            this.dtgrdUpdateCar.Name = "dtgrdUpdateCar";
            this.dtgrdUpdateCar.Size = new System.Drawing.Size(600, 328);
            this.dtgrdUpdateCar.TabIndex = 14;
            this.dtgrdUpdateCar.Click += new System.EventHandler(this.dtgrdUpdateCar_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Red;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBack.ForeColor = System.Drawing.Color.SeaShell;
            this.btnGoBack.Location = new System.Drawing.Point(480, 66);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(141, 59);
            this.btnGoBack.TabIndex = 15;
            this.btnGoBack.Text = "YÖNETİCİ KONTOL EKRANINA GERİ DÖN";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // CarInfoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(640, 481);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dtgrdUpdateCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.pnlUpdatePrice);
            this.Name = "CarInfoUpdate";
            this.Text = "ARAÇ BİLGİ GÜNCELLEME";
            this.Load += new System.EventHandler(this.AdminUpdateCarInformation_Load);
            this.pnlUpdatePrice.ResumeLayout(false);
            this.pnlUpdatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdUpdateCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdatePrice;
        private System.Windows.Forms.TextBox txtKmBilgisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGunlukUcret;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.DataGridView dtgrdUpdateCar;
        private System.Windows.Forms.Button btnGoBack;
    }
}