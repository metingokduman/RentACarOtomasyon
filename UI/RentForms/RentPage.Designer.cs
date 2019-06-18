namespace UI
{
    partial class RentPage
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
            this.pnlCustomerRentForm = new System.Windows.Forms.Panel();
            this.dtpckerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserIdentity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnGoBackCarListing = new System.Windows.Forms.Button();
            this.pnlCustomerRentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomerRentForm
            // 
            this.pnlCustomerRentForm.Controls.Add(this.dtpckerBirthDate);
            this.pnlCustomerRentForm.Controls.Add(this.label1);
            this.pnlCustomerRentForm.Controls.Add(this.label2);
            this.pnlCustomerRentForm.Controls.Add(this.label3);
            this.pnlCustomerRentForm.Controls.Add(this.txtUserCity);
            this.pnlCustomerRentForm.Controls.Add(this.label4);
            this.pnlCustomerRentForm.Controls.Add(this.txtUserIdentity);
            this.pnlCustomerRentForm.Controls.Add(this.label5);
            this.pnlCustomerRentForm.Controls.Add(this.txtUserName);
            this.pnlCustomerRentForm.Controls.Add(this.txtUserSurname);
            this.pnlCustomerRentForm.Location = new System.Drawing.Point(12, 12);
            this.pnlCustomerRentForm.Name = "pnlCustomerRentForm";
            this.pnlCustomerRentForm.Size = new System.Drawing.Size(353, 202);
            this.pnlCustomerRentForm.TabIndex = 7;
            // 
            // dtpckerBirthDate
            // 
            this.dtpckerBirthDate.Location = new System.Drawing.Point(131, 121);
            this.dtpckerBirthDate.Name = "dtpckerBirthDate";
            this.dtpckerBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpckerBirthDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC Kimlik No:";
            // 
            // txtUserCity
            // 
            this.txtUserCity.Location = new System.Drawing.Point(131, 160);
            this.txtUserCity.Name = "txtUserCity";
            this.txtUserCity.Size = new System.Drawing.Size(200, 20);
            this.txtUserCity.TabIndex = 4;
            this.txtUserCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // txtUserIdentity
            // 
            this.txtUserIdentity.Location = new System.Drawing.Point(131, 75);
            this.txtUserIdentity.MaxLength = 11;
            this.txtUserIdentity.Name = "txtUserIdentity";
            this.txtUserIdentity.Size = new System.Drawing.Size(200, 20);
            this.txtUserIdentity.TabIndex = 2;
            this.txtUserIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserIdentity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Memleket:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(131, 13);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(131, 44);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(200, 20);
            this.txtUserSurname.TabIndex = 1;
            this.txtUserSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.White;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFinish.Location = new System.Drawing.Point(11, 220);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(353, 45);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "KİRALA";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Red;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGoBack.Location = new System.Drawing.Point(162, 280);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(203, 44);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "KULLANICI SAYFASINA GERİ DÖN";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnGoBackCarListing
            // 
            this.btnGoBackCarListing.BackColor = System.Drawing.Color.Red;
            this.btnGoBackCarListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBackCarListing.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGoBackCarListing.Location = new System.Drawing.Point(12, 280);
            this.btnGoBackCarListing.Name = "btnGoBackCarListing";
            this.btnGoBackCarListing.Size = new System.Drawing.Size(115, 44);
            this.btnGoBackCarListing.TabIndex = 9;
            this.btnGoBackCarListing.Text = "GERİ";
            this.btnGoBackCarListing.UseVisualStyleBackColor = false;
            this.btnGoBackCarListing.Click += new System.EventHandler(this.btnGoBackCarListing_Click);
            // 
            // RentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.btnGoBackCarListing);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.pnlCustomerRentForm);
            this.Controls.Add(this.btnFinish);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RentPage";
            this.Text = "KİRALAMA EKRANI";
            this.Load += new System.EventHandler(this.CustomerRentForm_Load);
            this.pnlCustomerRentForm.ResumeLayout(false);
            this.pnlCustomerRentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerRentForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserIdentity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DateTimePicker dtpckerBirthDate;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnGoBackCarListing;
    }
}