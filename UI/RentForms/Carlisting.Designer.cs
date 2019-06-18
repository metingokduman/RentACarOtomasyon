namespace UI
{
    partial class Carlisting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carlisting));
            this.dtGrdViewCarList = new System.Windows.Forms.DataGridView();
            this.dtLastRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtFirstRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnRentPage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCarSearch = new System.Windows.Forms.Button();
            this.dtgrdviewRentCarDates = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoBac = new System.Windows.Forms.Button();
            this.pctrBoxCarImage = new System.Windows.Forms.PictureBox();
            this.btnCarPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdviewRentCarDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdViewCarList
            // 
            this.dtGrdViewCarList.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdViewCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewCarList.Location = new System.Drawing.Point(12, 183);
            this.dtGrdViewCarList.Name = "dtGrdViewCarList";
            this.dtGrdViewCarList.Size = new System.Drawing.Size(543, 349);
            this.dtGrdViewCarList.TabIndex = 3;
            this.dtGrdViewCarList.Click += new System.EventHandler(this.dtGrdViewCarList_Click);
            this.dtGrdViewCarList.DoubleClick += new System.EventHandler(this.dtGrdViewCarList_DoubleClick);
            // 
            // dtLastRentDate
            // 
            this.dtLastRentDate.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.dtLastRentDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtLastRentDate.Location = new System.Drawing.Point(198, 48);
            this.dtLastRentDate.Name = "dtLastRentDate";
            this.dtLastRentDate.Size = new System.Drawing.Size(200, 20);
            this.dtLastRentDate.TabIndex = 33;
            this.dtLastRentDate.ValueChanged += new System.EventHandler(this.dtFirstRentDate_ValueChanged);
            // 
            // dtFirstRentDate
            // 
            this.dtFirstRentDate.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.dtFirstRentDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtFirstRentDate.Location = new System.Drawing.Point(198, 17);
            this.dtFirstRentDate.Name = "dtFirstRentDate";
            this.dtFirstRentDate.Size = new System.Drawing.Size(200, 20);
            this.dtFirstRentDate.TabIndex = 32;
            this.dtFirstRentDate.ValueChanged += new System.EventHandler(this.dtFirstRentDate_ValueChanged);
            // 
            // btnRentPage
            // 
            this.btnRentPage.BackColor = System.Drawing.Color.White;
            this.btnRentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRentPage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRentPage.Location = new System.Drawing.Point(404, 85);
            this.btnRentPage.Name = "btnRentPage";
            this.btnRentPage.Size = new System.Drawing.Size(122, 62);
            this.btnRentPage.TabIndex = 31;
            this.btnRentPage.Text = "KİRALAMA İŞLEMİNE DEVAM ET";
            this.btnRentPage.UseVisualStyleBackColor = false;
            this.btnRentPage.Click += new System.EventHandler(this.btnRentPage_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(685, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 90);
            this.label9.TabIndex = 30;
            this.label9.Text = "7 -9 günlük kiralamada %30 indirim\r\n\r\n10 - 29 gün arası kiralamada %35 indirim\r\n\r" +
    "\n30 gün ve üzeri kiralamada %40 indirim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(48, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Kiralama Bitiş Tarihi";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(533, 21);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(146, 92);
            this.lblTotalPrice.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(9, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kiralama Başlangıç Tarihi";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCalculate.Location = new System.Drawing.Point(404, 17);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 51);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "FİYAT HESAPLA";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // btnCarSearch
            // 
            this.btnCarSearch.BackColor = System.Drawing.Color.White;
            this.btnCarSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCarSearch.Location = new System.Drawing.Point(198, 85);
            this.btnCarSearch.Name = "btnCarSearch";
            this.btnCarSearch.Size = new System.Drawing.Size(200, 42);
            this.btnCarSearch.TabIndex = 34;
            this.btnCarSearch.Text = "ARAÇLARI LİSTELE";
            this.btnCarSearch.UseVisualStyleBackColor = false;
            this.btnCarSearch.Click += new System.EventHandler(this.btnCarSearch_Click);
            // 
            // dtgrdviewRentCarDates
            // 
            this.dtgrdviewRentCarDates.BackgroundColor = System.Drawing.Color.White;
            this.dtgrdviewRentCarDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdviewRentCarDates.Location = new System.Drawing.Point(910, 183);
            this.dtgrdviewRentCarDates.Name = "dtgrdviewRentCarDates";
            this.dtgrdviewRentCarDates.Size = new System.Drawing.Size(251, 349);
            this.dtgrdviewRentCarDates.TabIndex = 35;
            this.dtgrdviewRentCarDates.Click += new System.EventHandler(this.dtgrdviewRentCarDates_Click);
            this.dtgrdviewRentCarDates.DoubleClick += new System.EventHandler(this.dtgrdviewRentCarDates_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(907, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Seçilen aracın kirada olduğu tarihler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seçilen tarihler arasındaki müsait araç listesi";
            // 
            // btnGoBac
            // 
            this.btnGoBac.BackColor = System.Drawing.Color.Red;
            this.btnGoBac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBac.Location = new System.Drawing.Point(12, 100);
            this.btnGoBac.Name = "btnGoBac";
            this.btnGoBac.Size = new System.Drawing.Size(122, 42);
            this.btnGoBac.TabIndex = 37;
            this.btnGoBac.Text = "GERİ";
            this.btnGoBac.UseVisualStyleBackColor = false;
            this.btnGoBac.Click += new System.EventHandler(this.btnGoBac_Click);
            // 
            // pctrBoxCarImage
            // 
            this.pctrBoxCarImage.BackColor = System.Drawing.Color.Transparent;
            this.pctrBoxCarImage.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxCarImage.Image")));
            this.pctrBoxCarImage.Location = new System.Drawing.Point(571, 183);
            this.pctrBoxCarImage.Name = "pctrBoxCarImage";
            this.pctrBoxCarImage.Size = new System.Drawing.Size(333, 244);
            this.pctrBoxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxCarImage.TabIndex = 38;
            this.pctrBoxCarImage.TabStop = false;
            // 
            // btnCarPicture
            // 
            this.btnCarPicture.BackColor = System.Drawing.Color.White;
            this.btnCarPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarPicture.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCarPicture.Location = new System.Drawing.Point(571, 433);
            this.btnCarPicture.Name = "btnCarPicture";
            this.btnCarPicture.Size = new System.Drawing.Size(333, 51);
            this.btnCarPicture.TabIndex = 39;
            this.btnCarPicture.Text = "FOTOĞRAFLARI GÖSTER";
            this.btnCarPicture.UseVisualStyleBackColor = false;
            this.btnCarPicture.Click += new System.EventHandler(this.btnCarPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1000, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Carlisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1165, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCarPicture);
            this.Controls.Add(this.pctrBoxCarImage);
            this.Controls.Add(this.btnGoBac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrdviewRentCarDates);
            this.Controls.Add(this.btnCarSearch);
            this.Controls.Add(this.dtLastRentDate);
            this.Controls.Add(this.dtFirstRentDate);
            this.Controls.Add(this.btnRentPage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dtGrdViewCarList);
            this.Name = "Carlisting";
            this.Text = "ARAÇ  SEÇME EKRANI";
            this.Load += new System.EventHandler(this.UserInterFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdviewRentCarDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrdViewCarList;
        private System.Windows.Forms.DateTimePicker dtLastRentDate;
        private System.Windows.Forms.DateTimePicker dtFirstRentDate;
        private System.Windows.Forms.Button btnRentPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCarSearch;
        private System.Windows.Forms.DataGridView dtgrdviewRentCarDates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoBac;
        private System.Windows.Forms.PictureBox pctrBoxCarImage;
        private System.Windows.Forms.Button btnCarPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}