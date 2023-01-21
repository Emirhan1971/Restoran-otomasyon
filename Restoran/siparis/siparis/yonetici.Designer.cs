namespace siparis
{
    partial class yonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetici));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_urunEkle = new System.Windows.Forms.TabPage();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_ekleyazi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_katagori = new System.Windows.Forms.Label();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.cb_katagori = new System.Windows.Forms.ComboBox();
            this.txt_urunAdi = new System.Windows.Forms.TextBox();
            this.btn_dosyaSec = new System.Windows.Forms.Button();
            this.tb_urunler = new System.Windows.Forms.TabPage();
            this.pb_yoneticiurunler = new System.Windows.Forms.PictureBox();
            this.dg_yonetici_urunler = new System.Windows.Forms.DataGridView();
            this.tb_siparisler = new System.Windows.Forms.TabPage();
            this.dg_siparisler = new System.Windows.Forms.DataGridView();
            this.tb_oneri_sikayet = new System.Windows.Forms.TabPage();
            this.dg_oneri = new System.Windows.Forms.DataGridView();
            this.tb_musteriler = new System.Windows.Forms.TabPage();
            this.dg_musteriler = new System.Windows.Forms.DataGridView();
            this.tb_exit = new System.Windows.Forms.TabPage();
            this.btn_degis = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_sifre_exit = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tb_urunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tb_urunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yoneticiurunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_yonetici_urunler)).BeginInit();
            this.tb_siparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_siparisler)).BeginInit();
            this.tb_oneri_sikayet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_oneri)).BeginInit();
            this.tb_musteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_musteriler)).BeginInit();
            this.tb_exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_urunEkle);
            this.tabControl1.Controls.Add(this.tb_urunler);
            this.tabControl1.Controls.Add(this.tb_siparisler);
            this.tabControl1.Controls.Add(this.tb_oneri_sikayet);
            this.tabControl1.Controls.Add(this.tb_musteriler);
            this.tabControl1.Controls.Add(this.tb_exit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 714);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tb_urunEkle
            // 
            this.tb_urunEkle.Controls.Add(this.btn_ekle);
            this.tb_urunEkle.Controls.Add(this.lbl_ekleyazi);
            this.tb_urunEkle.Controls.Add(this.pictureBox1);
            this.tb_urunEkle.Controls.Add(this.txt_fiyat);
            this.tb_urunEkle.Controls.Add(this.lbl_fiyat);
            this.tb_urunEkle.Controls.Add(this.lbl_katagori);
            this.tb_urunEkle.Controls.Add(this.lbl_urunAdi);
            this.tb_urunEkle.Controls.Add(this.cb_katagori);
            this.tb_urunEkle.Controls.Add(this.txt_urunAdi);
            this.tb_urunEkle.Controls.Add(this.btn_dosyaSec);
            this.tb_urunEkle.Location = new System.Drawing.Point(4, 25);
            this.tb_urunEkle.Name = "tb_urunEkle";
            this.tb_urunEkle.Size = new System.Drawing.Size(1158, 685);
            this.tb_urunEkle.TabIndex = 3;
            this.tb_urunEkle.Text = "Ürün ekle";
            this.tb_urunEkle.UseVisualStyleBackColor = true;
            this.tb_urunEkle.Click += new System.EventHandler(this.tb_urunEkle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(708, 375);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(104, 31);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_ekleyazi
            // 
            this.lbl_ekleyazi.AutoSize = true;
            this.lbl_ekleyazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ekleyazi.Location = new System.Drawing.Point(129, 47);
            this.lbl_ekleyazi.Name = "lbl_ekleyazi";
            this.lbl_ekleyazi.Size = new System.Drawing.Size(95, 25);
            this.lbl_ekleyazi.TabIndex = 8;
            this.lbl_ekleyazi.Text = "Ürün ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(117, 226);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(169, 22);
            this.txt_fiyat.TabIndex = 6;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(53, 232);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(42, 17);
            this.lbl_fiyat.TabIndex = 5;
            this.lbl_fiyat.Text = "Fiyat:";
            // 
            // lbl_katagori
            // 
            this.lbl_katagori.AutoSize = true;
            this.lbl_katagori.Location = new System.Drawing.Point(50, 174);
            this.lbl_katagori.Name = "lbl_katagori";
            this.lbl_katagori.Size = new System.Drawing.Size(65, 17);
            this.lbl_katagori.TabIndex = 4;
            this.lbl_katagori.Text = "Katagori:";
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.Location = new System.Drawing.Point(49, 109);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(66, 17);
            this.lbl_urunAdi.TabIndex = 3;
            this.lbl_urunAdi.Text = "Ürün adı:";
            // 
            // cb_katagori
            // 
            this.cb_katagori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_katagori.FormattingEnabled = true;
            this.cb_katagori.Items.AddRange(new object[] {
            "Kahvaltı",
            "Öğle yemeği",
            "Akşam yemeği"});
            this.cb_katagori.Location = new System.Drawing.Point(117, 167);
            this.cb_katagori.Name = "cb_katagori";
            this.cb_katagori.Size = new System.Drawing.Size(169, 24);
            this.cb_katagori.TabIndex = 2;
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.Location = new System.Drawing.Point(117, 105);
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Size = new System.Drawing.Size(169, 22);
            this.txt_urunAdi.TabIndex = 1;
            // 
            // btn_dosyaSec
            // 
            this.btn_dosyaSec.Location = new System.Drawing.Point(347, 375);
            this.btn_dosyaSec.Name = "btn_dosyaSec";
            this.btn_dosyaSec.Size = new System.Drawing.Size(104, 31);
            this.btn_dosyaSec.TabIndex = 0;
            this.btn_dosyaSec.Text = "Dosya Seç";
            this.btn_dosyaSec.UseVisualStyleBackColor = true;
            this.btn_dosyaSec.Click += new System.EventHandler(this.btn_dosyaSec_Click);
            // 
            // tb_urunler
            // 
            this.tb_urunler.Controls.Add(this.pb_yoneticiurunler);
            this.tb_urunler.Controls.Add(this.dg_yonetici_urunler);
            this.tb_urunler.Location = new System.Drawing.Point(4, 25);
            this.tb_urunler.Name = "tb_urunler";
            this.tb_urunler.Padding = new System.Windows.Forms.Padding(3);
            this.tb_urunler.Size = new System.Drawing.Size(1158, 685);
            this.tb_urunler.TabIndex = 1;
            this.tb_urunler.Text = "Ürünler";
            this.tb_urunler.UseVisualStyleBackColor = true;
            // 
            // pb_yoneticiurunler
            // 
            this.pb_yoneticiurunler.Image = ((System.Drawing.Image)(resources.GetObject("pb_yoneticiurunler.Image")));
            this.pb_yoneticiurunler.Location = new System.Drawing.Point(0, 3);
            this.pb_yoneticiurunler.Name = "pb_yoneticiurunler";
            this.pb_yoneticiurunler.Size = new System.Drawing.Size(456, 312);
            this.pb_yoneticiurunler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_yoneticiurunler.TabIndex = 1;
            this.pb_yoneticiurunler.TabStop = false;
            // 
            // dg_yonetici_urunler
            // 
            this.dg_yonetici_urunler.AllowUserToAddRows = false;
            this.dg_yonetici_urunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_yonetici_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_yonetici_urunler.Location = new System.Drawing.Point(3, 321);
            this.dg_yonetici_urunler.Name = "dg_yonetici_urunler";
            this.dg_yonetici_urunler.ReadOnly = true;
            this.dg_yonetici_urunler.RowHeadersWidth = 51;
            this.dg_yonetici_urunler.RowTemplate.Height = 24;
            this.dg_yonetici_urunler.Size = new System.Drawing.Size(1152, 361);
            this.dg_yonetici_urunler.TabIndex = 0;
            this.dg_yonetici_urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_yonetici_urunler_CellClick);
            // 
            // tb_siparisler
            // 
            this.tb_siparisler.Controls.Add(this.dg_siparisler);
            this.tb_siparisler.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_siparisler.Location = new System.Drawing.Point(4, 25);
            this.tb_siparisler.Name = "tb_siparisler";
            this.tb_siparisler.Size = new System.Drawing.Size(1158, 685);
            this.tb_siparisler.TabIndex = 7;
            this.tb_siparisler.Text = "Siparişler";
            this.tb_siparisler.UseVisualStyleBackColor = true;
            // 
            // dg_siparisler
            // 
            this.dg_siparisler.AllowUserToAddRows = false;
            this.dg_siparisler.AllowUserToDeleteRows = false;
            this.dg_siparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_siparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_siparisler.Location = new System.Drawing.Point(0, 0);
            this.dg_siparisler.Name = "dg_siparisler";
            this.dg_siparisler.ReadOnly = true;
            this.dg_siparisler.RowHeadersWidth = 51;
            this.dg_siparisler.RowTemplate.Height = 24;
            this.dg_siparisler.Size = new System.Drawing.Size(1158, 685);
            this.dg_siparisler.TabIndex = 0;
            this.dg_siparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_siparisler_CellContentClick);
            // 
            // tb_oneri_sikayet
            // 
            this.tb_oneri_sikayet.Controls.Add(this.dg_oneri);
            this.tb_oneri_sikayet.Location = new System.Drawing.Point(4, 25);
            this.tb_oneri_sikayet.Name = "tb_oneri_sikayet";
            this.tb_oneri_sikayet.Size = new System.Drawing.Size(1158, 685);
            this.tb_oneri_sikayet.TabIndex = 4;
            this.tb_oneri_sikayet.Text = "Öneriler ve Şikayetler";
            this.tb_oneri_sikayet.UseVisualStyleBackColor = true;
            // 
            // dg_oneri
            // 
            this.dg_oneri.AllowUserToAddRows = false;
            this.dg_oneri.AllowUserToDeleteRows = false;
            this.dg_oneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_oneri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_oneri.Location = new System.Drawing.Point(0, 0);
            this.dg_oneri.Name = "dg_oneri";
            this.dg_oneri.ReadOnly = true;
            this.dg_oneri.RowHeadersWidth = 51;
            this.dg_oneri.RowTemplate.Height = 24;
            this.dg_oneri.Size = new System.Drawing.Size(1158, 685);
            this.dg_oneri.TabIndex = 0;
            // 
            // tb_musteriler
            // 
            this.tb_musteriler.Controls.Add(this.dg_musteriler);
            this.tb_musteriler.Location = new System.Drawing.Point(4, 25);
            this.tb_musteriler.Name = "tb_musteriler";
            this.tb_musteriler.Size = new System.Drawing.Size(1158, 685);
            this.tb_musteriler.TabIndex = 6;
            this.tb_musteriler.Text = "Müşteriler";
            this.tb_musteriler.UseVisualStyleBackColor = true;
            // 
            // dg_musteriler
            // 
            this.dg_musteriler.AllowUserToAddRows = false;
            this.dg_musteriler.AllowUserToDeleteRows = false;
            this.dg_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_musteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_musteriler.Location = new System.Drawing.Point(0, 0);
            this.dg_musteriler.Name = "dg_musteriler";
            this.dg_musteriler.ReadOnly = true;
            this.dg_musteriler.RowHeadersWidth = 51;
            this.dg_musteriler.RowTemplate.Height = 24;
            this.dg_musteriler.Size = new System.Drawing.Size(1158, 685);
            this.dg_musteriler.TabIndex = 0;
            // 
            // tb_exit
            // 
            this.tb_exit.Controls.Add(this.txt_sifre_exit);
            this.tb_exit.Controls.Add(this.lbl_sifre);
            this.tb_exit.Controls.Add(this.btn_exit);
            this.tb_exit.Controls.Add(this.btn_degis);
            this.tb_exit.Location = new System.Drawing.Point(4, 25);
            this.tb_exit.Name = "tb_exit";
            this.tb_exit.Size = new System.Drawing.Size(1158, 685);
            this.tb_exit.TabIndex = 8;
            this.tb_exit.Text = "Çıkış";
            this.tb_exit.UseVisualStyleBackColor = true;
            // 
            // btn_degis
            // 
            this.btn_degis.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_degis.Location = new System.Drawing.Point(0, 0);
            this.btn_degis.Name = "btn_degis";
            this.btn_degis.Size = new System.Drawing.Size(201, 685);
            this.btn_degis.TabIndex = 0;
            this.btn_degis.Text = "Kullanıcı değiştir";
            this.btn_degis.UseVisualStyleBackColor = true;
            this.btn_degis.Click += new System.EventHandler(this.btn_degis_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.Location = new System.Drawing.Point(957, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(201, 685);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Uygulamayı kapat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_sifre_exit
            // 
            this.txt_sifre_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sifre_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre_exit.Location = new System.Drawing.Point(207, 341);
            this.txt_sifre_exit.Name = "txt_sifre_exit";
            this.txt_sifre_exit.Size = new System.Drawing.Size(744, 38);
            this.txt_sifre_exit.TabIndex = 3;
            this.txt_sifre_exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sifre_exit.UseSystemPasswordChar = true;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(204, 306);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(140, 17);
            this.lbl_sifre.TabIndex = 4;
            this.lbl_sifre.Text = "Yönetici şifresi giriniz";
            // 
            // yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 714);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yonetici";
            this.Text = "yonetici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.yonetici_Load);
            this.tabControl1.ResumeLayout(false);
            this.tb_urunEkle.ResumeLayout(false);
            this.tb_urunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tb_urunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_yoneticiurunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_yonetici_urunler)).EndInit();
            this.tb_siparisler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_siparisler)).EndInit();
            this.tb_oneri_sikayet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_oneri)).EndInit();
            this.tb_musteriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_musteriler)).EndInit();
            this.tb_exit.ResumeLayout(false);
            this.tb_exit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_urunler;
        private System.Windows.Forms.TabPage tb_urunEkle;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_katagori;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.ComboBox cb_katagori;
        private System.Windows.Forms.TextBox txt_urunAdi;
        private System.Windows.Forms.Button btn_dosyaSec;
        private System.Windows.Forms.TabPage tb_oneri_sikayet;
        private System.Windows.Forms.Label lbl_ekleyazi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dg_oneri;
        private System.Windows.Forms.TabPage tb_musteriler;
        private System.Windows.Forms.DataGridView dg_musteriler;
        private System.Windows.Forms.TabPage tb_siparisler;
        private System.Windows.Forms.PictureBox pb_yoneticiurunler;
        private System.Windows.Forms.DataGridView dg_yonetici_urunler;
        private System.Windows.Forms.DataGridView dg_siparisler;
        private System.Windows.Forms.TabPage tb_exit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_degis;
        private System.Windows.Forms.TextBox txt_sifre_exit;
        private System.Windows.Forms.Label lbl_sifre;
    }
}