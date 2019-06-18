namespace UI
{
    partial class CarDeleting
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
            this.pnlDeleteCarInf = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaseNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgrdDeleteCar = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pnlDeleteCarInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDeleteCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeleteCarInf
            // 
            this.pnlDeleteCarInf.Controls.Add(this.label5);
            this.pnlDeleteCarInf.Controls.Add(this.txtSaseNo);
            this.pnlDeleteCarInf.Location = new System.Drawing.Point(12, 9);
            this.pnlDeleteCarInf.Name = "pnlDeleteCarInf";
            this.pnlDeleteCarInf.Size = new System.Drawing.Size(330, 48);
            this.pnlDeleteCarInf.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şasi Numarası :";
            // 
            // txtSaseNo
            // 
            this.txtSaseNo.Location = new System.Drawing.Point(137, 9);
            this.txtSaseNo.Name = "txtSaseNo";
            this.txtSaseNo.Size = new System.Drawing.Size(168, 20);
            this.txtSaseNo.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(362, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 48);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgrdDeleteCar
            // 
            this.dtgrdDeleteCar.BackgroundColor = System.Drawing.Color.White;
            this.dtgrdDeleteCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdDeleteCar.Location = new System.Drawing.Point(12, 63);
            this.dtgrdDeleteCar.Name = "dtgrdDeleteCar";
            this.dtgrdDeleteCar.Size = new System.Drawing.Size(704, 254);
            this.dtgrdDeleteCar.TabIndex = 16;
            this.dtgrdDeleteCar.Click += new System.EventHandler(this.dtgrdDeleteCar_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Red;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(479, 9);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(237, 48);
            this.btnGoBack.TabIndex = 18;
            this.btnGoBack.Text = "YÖNETİCİ KONTOL EKRANINA GERİ DÖN";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // CarDeleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(726, 332);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.pnlDeleteCarInf);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgrdDeleteCar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CarDeleting";
            this.Text = "ARAÇ SİLME EKRANI";
            this.Load += new System.EventHandler(this.AdminDeleteCar_Load);
            this.pnlDeleteCarInf.ResumeLayout(false);
            this.pnlDeleteCarInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDeleteCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteCarInf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaseNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgrdDeleteCar;
        private System.Windows.Forms.Button btnGoBack;
    }
}