namespace UI
{
    partial class AdminRegisterInterface
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
            this.pnlAddModerator = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModeratorPassword = new System.Windows.Forms.TextBox();
            this.txtModeratorMailAdress = new System.Windows.Forms.TextBox();
            this.btnModeratorRegister = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.pnlAddModerator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddModerator
            // 
            this.pnlAddModerator.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddModerator.Controls.Add(this.label1);
            this.pnlAddModerator.Controls.Add(this.cmbxTitle);
            this.pnlAddModerator.Controls.Add(this.label2);
            this.pnlAddModerator.Controls.Add(this.label3);
            this.pnlAddModerator.Controls.Add(this.txtModeratorPassword);
            this.pnlAddModerator.Controls.Add(this.txtModeratorMailAdress);
            this.pnlAddModerator.Location = new System.Drawing.Point(12, 12);
            this.pnlAddModerator.Name = "pnlAddModerator";
            this.pnlAddModerator.Size = new System.Drawing.Size(326, 132);
            this.pnlAddModerator.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-mail Adresi : ";
            // 
            // cmbxTitle
            // 
            this.cmbxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTitle.FormattingEnabled = true;
            this.cmbxTitle.Items.AddRange(new object[] {
            "Yönetici",
            "Müşteri"});
            this.cmbxTitle.Location = new System.Drawing.Point(112, 99);
            this.cmbxTitle.Name = "cmbxTitle";
            this.cmbxTitle.Size = new System.Drawing.Size(199, 21);
            this.cmbxTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ünvan :";
            // 
            // txtModeratorPassword
            // 
            this.txtModeratorPassword.Location = new System.Drawing.Point(112, 55);
            this.txtModeratorPassword.MaxLength = 8;
            this.txtModeratorPassword.Name = "txtModeratorPassword";
            this.txtModeratorPassword.Size = new System.Drawing.Size(199, 20);
            this.txtModeratorPassword.TabIndex = 1;
            // 
            // txtModeratorMailAdress
            // 
            this.txtModeratorMailAdress.Location = new System.Drawing.Point(112, 19);
            this.txtModeratorMailAdress.Name = "txtModeratorMailAdress";
            this.txtModeratorMailAdress.Size = new System.Drawing.Size(199, 20);
            this.txtModeratorMailAdress.TabIndex = 0;
            // 
            // btnModeratorRegister
            // 
            this.btnModeratorRegister.BackColor = System.Drawing.Color.White;
            this.btnModeratorRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModeratorRegister.ForeColor = System.Drawing.Color.Black;
            this.btnModeratorRegister.Location = new System.Drawing.Point(12, 150);
            this.btnModeratorRegister.Name = "btnModeratorRegister";
            this.btnModeratorRegister.Size = new System.Drawing.Size(138, 47);
            this.btnModeratorRegister.TabIndex = 3;
            this.btnModeratorRegister.Text = "KAYIT OLUŞTUR";
            this.btnModeratorRegister.UseVisualStyleBackColor = false;
            this.btnModeratorRegister.Click += new System.EventHandler(this.btnModeratorRegister_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.Red;
            this.btnGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoback.ForeColor = System.Drawing.Color.White;
            this.btnGoback.Location = new System.Drawing.Point(208, 150);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(130, 52);
            this.btnGoback.TabIndex = 20;
            this.btnGoback.Text = "YÖNETİCİ KONTOL EKRANINA GERİ DÖN";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // AdminRegisterInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(352, 226);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.pnlAddModerator);
            this.Controls.Add(this.btnModeratorRegister);
            this.Name = "AdminRegisterInterface";
            this.Text = "KULLANICI EKLEME EKRANI";
            this.Load += new System.EventHandler(this.AdminAddModerator_Load);
            this.pnlAddModerator.ResumeLayout(false);
            this.pnlAddModerator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddModerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModeratorPassword;
        private System.Windows.Forms.TextBox txtModeratorMailAdress;
        private System.Windows.Forms.Button btnModeratorRegister;
        private System.Windows.Forms.Button btnGoback;
    }
}