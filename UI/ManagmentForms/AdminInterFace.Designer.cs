namespace UI
{
    partial class AdminInterFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterFace));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaÖzellikleriDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralamaAraYüzüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıkSorulanSorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıdanGelenMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçYıllıkKmGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabaEkleToolStripMenuItem,
            this.arabaÖzellikleriDeğiştirToolStripMenuItem,
            this.araçSilToolStripMenuItem,
            this.araçKiralamaAraYüzüToolStripMenuItem,
            this.araçYıllıkKmGörüntülemeToolStripMenuItem});
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // arabaEkleToolStripMenuItem
            // 
            this.arabaEkleToolStripMenuItem.Name = "arabaEkleToolStripMenuItem";
            this.arabaEkleToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.arabaEkleToolStripMenuItem.Text = "Araba Ekle";
            this.arabaEkleToolStripMenuItem.Click += new System.EventHandler(this.arabaEkleToolStripMenuItem_Click);
            // 
            // arabaÖzellikleriDeğiştirToolStripMenuItem
            // 
            this.arabaÖzellikleriDeğiştirToolStripMenuItem.Name = "arabaÖzellikleriDeğiştirToolStripMenuItem";
            this.arabaÖzellikleriDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.arabaÖzellikleriDeğiştirToolStripMenuItem.Text = "Araç Özellikleri Değiştir";
            this.arabaÖzellikleriDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.arabaÖzellikleriDeğiştirToolStripMenuItem_Click);
            // 
            // araçSilToolStripMenuItem
            // 
            this.araçSilToolStripMenuItem.Name = "araçSilToolStripMenuItem";
            this.araçSilToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.araçSilToolStripMenuItem.Text = "Araç Sil";
            this.araçSilToolStripMenuItem.Click += new System.EventHandler(this.araçSilToolStripMenuItem_Click);
            // 
            // araçKiralamaAraYüzüToolStripMenuItem
            // 
            this.araçKiralamaAraYüzüToolStripMenuItem.Name = "araçKiralamaAraYüzüToolStripMenuItem";
            this.araçKiralamaAraYüzüToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.araçKiralamaAraYüzüToolStripMenuItem.Text = "Araç Kiralama AraYüzü";
            this.araçKiralamaAraYüzüToolStripMenuItem.Click += new System.EventHandler(this.araçKiralamaAraYüzüToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEklemeToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıEklemeToolStripMenuItem
            // 
            this.kullanıcıEklemeToolStripMenuItem.Name = "kullanıcıEklemeToolStripMenuItem";
            this.kullanıcıEklemeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kullanıcıEklemeToolStripMenuItem.Text = "Kullanıcı Ekleme";
            this.kullanıcıEklemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEklemeToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sıkSorulanSorularToolStripMenuItem,
            this.kullanıcıdanGelenMesajlarToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // sıkSorulanSorularToolStripMenuItem
            // 
            this.sıkSorulanSorularToolStripMenuItem.Name = "sıkSorulanSorularToolStripMenuItem";
            this.sıkSorulanSorularToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.sıkSorulanSorularToolStripMenuItem.Text = "Sık Sorulan Sorular";
            // 
            // kullanıcıdanGelenMesajlarToolStripMenuItem
            // 
            this.kullanıcıdanGelenMesajlarToolStripMenuItem.Name = "kullanıcıdanGelenMesajlarToolStripMenuItem";
            this.kullanıcıdanGelenMesajlarToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.kullanıcıdanGelenMesajlarToolStripMenuItem.Text = "Kullanıcıdan Gelen Mesajlar";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // araçYıllıkKmGörüntülemeToolStripMenuItem
            // 
            this.araçYıllıkKmGörüntülemeToolStripMenuItem.Name = "araçYıllıkKmGörüntülemeToolStripMenuItem";
            this.araçYıllıkKmGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.araçYıllıkKmGörüntülemeToolStripMenuItem.Text = "Araç Yıllık Km Görüntüleme";
            this.araçYıllıkKmGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.araçYıllıkKmGörüntülemeToolStripMenuItem_Click);
            // 
            // AdminInterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 532);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminInterFace";
            this.Text = "YÖNETİCİ KONTOL EKRANI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaÖzellikleriDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralamaAraYüzüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıkSorulanSorularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıdanGelenMesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçYıllıkKmGörüntülemeToolStripMenuItem;
    }
}