
namespace siparis
{
    partial class siparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparis));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_hosgeldiniz = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_telNo = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.tb_urunler = new System.Windows.Forms.TabPage();
            this.lbl_toplam_fiyat = new System.Windows.Forms.Label();
            this.lbl_urunNo = new System.Windows.Forms.Label();
            this.txt_urunNo = new System.Windows.Forms.TextBox();
            this.lbl_musteriNumarası = new System.Windows.Forms.Label();
            this.txt_musteriNumarası = new System.Windows.Forms.TextBox();
            this.lb_filtre = new System.Windows.Forms.Label();
            this.cb_filtre = new System.Windows.Forms.ComboBox();
            this.cb_adet = new System.Windows.Forms.ComboBox();
            this.btn_siparisVer = new System.Windows.Forms.Button();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_urunAdeti = new System.Windows.Forms.Label();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.pb_urunfoto = new System.Windows.Forms.PictureBox();
            this.dg_urunler = new System.Windows.Forms.DataGridView();
            this.tb_oneri_sikayet = new System.Windows.Forms.TabPage();
            this.lbl_oneri_musteriNo = new System.Windows.Forms.Label();
            this.txt_musteriNo_oneri = new System.Windows.Forms.TextBox();
            this.btn_oneri_ilet = new System.Windows.Forms.Button();
            this.rtxt_oneri = new System.Windows.Forms.RichTextBox();
            this.tb_exit = new System.Windows.Forms.TabPage();
            this.txt_sifre_exit = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_degis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tb_hosgeldiniz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tb_urunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_urunfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_urunler)).BeginInit();
            this.tb_oneri_sikayet.SuspendLayout();
            this.tb_exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_hosgeldiniz);
            this.tabControl1.Controls.Add(this.tb_urunler);
            this.tabControl1.Controls.Add(this.tb_oneri_sikayet);
            this.tabControl1.Controls.Add(this.tb_exit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 687);
            this.tabControl1.TabIndex = 0;
            // 
            // tb_hosgeldiniz
            // 
            this.tb_hosgeldiniz.BackColor = System.Drawing.Color.White;
            this.tb_hosgeldiniz.Controls.Add(this.pictureBox1);
            this.tb_hosgeldiniz.Controls.Add(this.lbl_Telefon);
            this.tb_hosgeldiniz.Controls.Add(this.lbl_Soyad);
            this.tb_hosgeldiniz.Controls.Add(this.lbl_Ad);
            this.tb_hosgeldiniz.Controls.Add(this.txt_soyad);
            this.tb_hosgeldiniz.Controls.Add(this.txt_telNo);
            this.tb_hosgeldiniz.Controls.Add(this.txt_ad);
            this.tb_hosgeldiniz.Controls.Add(this.btn_ileri);
            this.tb_hosgeldiniz.ForeColor = System.Drawing.Color.White;
            this.tb_hosgeldiniz.Location = new System.Drawing.Point(4, 25);
            this.tb_hosgeldiniz.Name = "tb_hosgeldiniz";
            this.tb_hosgeldiniz.Padding = new System.Windows.Forms.Padding(3);
            this.tb_hosgeldiniz.Size = new System.Drawing.Size(1228, 658);
            this.tb_hosgeldiniz.TabIndex = 0;
            this.tb_hosgeldiniz.Text = "Hoşgeldiniz";
            this.tb_hosgeldiniz.Click += new System.EventHandler(this.tb_hosgeldiniz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.ForeColor = System.Drawing.Color.Black;
            this.lbl_Telefon.Location = new System.Drawing.Point(27, 191);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(60, 17);
            this.lbl_Telefon.TabIndex = 28;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.ForeColor = System.Drawing.Color.Black;
            this.lbl_Soyad.Location = new System.Drawing.Point(30, 115);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(52, 17);
            this.lbl_Soyad.TabIndex = 27;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ad.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ad.Location = new System.Drawing.Point(53, 33);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_Ad.TabIndex = 26;
            this.lbl_Ad.Text = "Ad:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(86, 115);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(283, 22);
            this.txt_soyad.TabIndex = 25;
            // 
            // txt_telNo
            // 
            this.txt_telNo.Location = new System.Drawing.Point(89, 191);
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Size = new System.Drawing.Size(283, 22);
            this.txt_telNo.TabIndex = 24;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(86, 30);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(283, 22);
            this.txt_ad.TabIndex = 23;
            // 
            // btn_ileri
            // 
            this.btn_ileri.BackColor = System.Drawing.Color.Green;
            this.btn_ileri.Location = new System.Drawing.Point(195, 237);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(174, 66);
            this.btn_ileri.TabIndex = 22;
            this.btn_ileri.Text = "İleri";
            this.btn_ileri.UseVisualStyleBackColor = false;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click_1);
            // 
            // tb_urunler
            // 
            this.tb_urunler.Controls.Add(this.lbl_toplam_fiyat);
            this.tb_urunler.Controls.Add(this.lbl_urunNo);
            this.tb_urunler.Controls.Add(this.txt_urunNo);
            this.tb_urunler.Controls.Add(this.lbl_musteriNumarası);
            this.tb_urunler.Controls.Add(this.txt_musteriNumarası);
            this.tb_urunler.Controls.Add(this.lb_filtre);
            this.tb_urunler.Controls.Add(this.cb_filtre);
            this.tb_urunler.Controls.Add(this.cb_adet);
            this.tb_urunler.Controls.Add(this.btn_siparisVer);
            this.tb_urunler.Controls.Add(this.lbl_fiyat);
            this.tb_urunler.Controls.Add(this.lbl_urunAdeti);
            this.tb_urunler.Controls.Add(this.lbl_urunAdi);
            this.tb_urunler.Controls.Add(this.txt_fiyat);
            this.tb_urunler.Controls.Add(this.txt_urunadi);
            this.tb_urunler.Controls.Add(this.pb_urunfoto);
            this.tb_urunler.Controls.Add(this.dg_urunler);
            this.tb_urunler.Location = new System.Drawing.Point(4, 25);
            this.tb_urunler.Name = "tb_urunler";
            this.tb_urunler.Padding = new System.Windows.Forms.Padding(3);
            this.tb_urunler.Size = new System.Drawing.Size(1228, 658);
            this.tb_urunler.TabIndex = 1;
            this.tb_urunler.Text = "Ürünler";
            this.tb_urunler.UseVisualStyleBackColor = true;
            // 
            // lbl_toplam_fiyat
            // 
            this.lbl_toplam_fiyat.AutoSize = true;
            this.lbl_toplam_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_fiyat.Location = new System.Drawing.Point(861, 156);
            this.lbl_toplam_fiyat.Name = "lbl_toplam_fiyat";
            this.lbl_toplam_fiyat.Size = new System.Drawing.Size(0, 25);
            this.lbl_toplam_fiyat.TabIndex = 16;
            // 
            // lbl_urunNo
            // 
            this.lbl_urunNo.AutoSize = true;
            this.lbl_urunNo.Location = new System.Drawing.Point(485, 146);
            this.lbl_urunNo.Name = "lbl_urunNo";
            this.lbl_urunNo.Size = new System.Drawing.Size(105, 17);
            this.lbl_urunNo.TabIndex = 15;
            this.lbl_urunNo.Text = "Ürün numarası:";
            // 
            // txt_urunNo
            // 
            this.txt_urunNo.Enabled = false;
            this.txt_urunNo.Location = new System.Drawing.Point(597, 141);
            this.txt_urunNo.Name = "txt_urunNo";
            this.txt_urunNo.Size = new System.Drawing.Size(121, 22);
            this.txt_urunNo.TabIndex = 14;
            // 
            // lbl_musteriNumarası
            // 
            this.lbl_musteriNumarası.AutoSize = true;
            this.lbl_musteriNumarası.Location = new System.Drawing.Point(461, 50);
            this.lbl_musteriNumarası.Name = "lbl_musteriNumarası";
            this.lbl_musteriNumarası.Size = new System.Drawing.Size(129, 17);
            this.lbl_musteriNumarası.TabIndex = 13;
            this.lbl_musteriNumarası.Text = "Müşleri Numaranız:";
            // 
            // txt_musteriNumarası
            // 
            this.txt_musteriNumarası.Location = new System.Drawing.Point(597, 47);
            this.txt_musteriNumarası.Name = "txt_musteriNumarası";
            this.txt_musteriNumarası.Size = new System.Drawing.Size(204, 22);
            this.txt_musteriNumarası.TabIndex = 12;
            // 
            // lb_filtre
            // 
            this.lb_filtre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_filtre.AutoSize = true;
            this.lb_filtre.Location = new System.Drawing.Point(1039, 10);
            this.lb_filtre.Name = "lb_filtre";
            this.lb_filtre.Size = new System.Drawing.Size(54, 17);
            this.lb_filtre.TabIndex = 11;
            this.lb_filtre.Text = "Filtrele;";
            // 
            // cb_filtre
            // 
            this.cb_filtre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_filtre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtre.FormattingEnabled = true;
            this.cb_filtre.Items.AddRange(new object[] {
            "Kahvaltı",
            "Öğle yemeği",
            "Akşam Yemeği",
            "Filtrelemeyi kapat"});
            this.cb_filtre.Location = new System.Drawing.Point(1099, 7);
            this.cb_filtre.Name = "cb_filtre";
            this.cb_filtre.Size = new System.Drawing.Size(121, 24);
            this.cb_filtre.TabIndex = 10;
            this.cb_filtre.SelectedIndexChanged += new System.EventHandler(this.cb_filtre_SelectedIndexChanged);
            // 
            // cb_adet
            // 
            this.cb_adet.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_adet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_adet.FormattingEnabled = true;
            this.cb_adet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_adet.Location = new System.Drawing.Point(597, 182);
            this.cb_adet.Name = "cb_adet";
            this.cb_adet.Size = new System.Drawing.Size(121, 24);
            this.cb_adet.TabIndex = 9;
            this.cb_adet.SelectedIndexChanged += new System.EventHandler(this.cb_adet_SelectedIndexChanged);
            // 
            // btn_siparisVer
            // 
            this.btn_siparisVer.Location = new System.Drawing.Point(725, 263);
            this.btn_siparisVer.Name = "btn_siparisVer";
            this.btn_siparisVer.Size = new System.Drawing.Size(94, 30);
            this.btn_siparisVer.TabIndex = 8;
            this.btn_siparisVer.Text = "Sipariş ver";
            this.btn_siparisVer.UseVisualStyleBackColor = true;
            this.btn_siparisVer.Click += new System.EventHandler(this.btn_siparisVer_Click);
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(520, 238);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(71, 17);
            this.lbl_fiyat.TabIndex = 7;
            this.lbl_fiyat.Text = "Adet fiyat:";
            // 
            // lbl_urunAdeti
            // 
            this.lbl_urunAdeti.AutoSize = true;
            this.lbl_urunAdeti.Location = new System.Drawing.Point(550, 182);
            this.lbl_urunAdeti.Name = "lbl_urunAdeti";
            this.lbl_urunAdeti.Size = new System.Drawing.Size(41, 17);
            this.lbl_urunAdeti.TabIndex = 6;
            this.lbl_urunAdeti.Text = "Adet:";
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.Location = new System.Drawing.Point(526, 96);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(64, 17);
            this.lbl_urunAdi.TabIndex = 5;
            this.lbl_urunAdi.Text = "ürün adı:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Enabled = false;
            this.txt_fiyat.Location = new System.Drawing.Point(597, 235);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(204, 22);
            this.txt_fiyat.TabIndex = 4;
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Enabled = false;
            this.txt_urunadi.Location = new System.Drawing.Point(597, 93);
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(204, 22);
            this.txt_urunadi.TabIndex = 2;
            // 
            // pb_urunfoto
            // 
            this.pb_urunfoto.Image = ((System.Drawing.Image)(resources.GetObject("pb_urunfoto.Image")));
            this.pb_urunfoto.Location = new System.Drawing.Point(3, 7);
            this.pb_urunfoto.Name = "pb_urunfoto";
            this.pb_urunfoto.Size = new System.Drawing.Size(366, 296);
            this.pb_urunfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_urunfoto.TabIndex = 1;
            this.pb_urunfoto.TabStop = false;
            // 
            // dg_urunler
            // 
            this.dg_urunler.AllowUserToAddRows = false;
            this.dg_urunler.AllowUserToDeleteRows = false;
            this.dg_urunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_urunler.Location = new System.Drawing.Point(3, 309);
            this.dg_urunler.Name = "dg_urunler";
            this.dg_urunler.ReadOnly = true;
            this.dg_urunler.RowHeadersWidth = 51;
            this.dg_urunler.RowTemplate.Height = 24;
            this.dg_urunler.Size = new System.Drawing.Size(1222, 346);
            this.dg_urunler.TabIndex = 0;
            this.dg_urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_urunler_CellClick);
            // 
            // tb_oneri_sikayet
            // 
            this.tb_oneri_sikayet.Controls.Add(this.label1);
            this.tb_oneri_sikayet.Controls.Add(this.lbl_oneri_musteriNo);
            this.tb_oneri_sikayet.Controls.Add(this.txt_musteriNo_oneri);
            this.tb_oneri_sikayet.Controls.Add(this.btn_oneri_ilet);
            this.tb_oneri_sikayet.Controls.Add(this.rtxt_oneri);
            this.tb_oneri_sikayet.Location = new System.Drawing.Point(4, 25);
            this.tb_oneri_sikayet.Name = "tb_oneri_sikayet";
            this.tb_oneri_sikayet.Size = new System.Drawing.Size(1228, 658);
            this.tb_oneri_sikayet.TabIndex = 3;
            this.tb_oneri_sikayet.Text = "Öneri ve Şikayet";
            this.tb_oneri_sikayet.UseVisualStyleBackColor = true;
            // 
            // lbl_oneri_musteriNo
            // 
            this.lbl_oneri_musteriNo.AutoSize = true;
            this.lbl_oneri_musteriNo.Location = new System.Drawing.Point(25, 24);
            this.lbl_oneri_musteriNo.Name = "lbl_oneri_musteriNo";
            this.lbl_oneri_musteriNo.Size = new System.Drawing.Size(77, 17);
            this.lbl_oneri_musteriNo.TabIndex = 3;
            this.lbl_oneri_musteriNo.Text = "Müşleri no:";
            // 
            // txt_musteriNo_oneri
            // 
            this.txt_musteriNo_oneri.Location = new System.Drawing.Point(108, 24);
            this.txt_musteriNo_oneri.Name = "txt_musteriNo_oneri";
            this.txt_musteriNo_oneri.Size = new System.Drawing.Size(252, 22);
            this.txt_musteriNo_oneri.TabIndex = 2;
            // 
            // btn_oneri_ilet
            // 
            this.btn_oneri_ilet.Location = new System.Drawing.Point(376, 20);
            this.btn_oneri_ilet.Name = "btn_oneri_ilet";
            this.btn_oneri_ilet.Size = new System.Drawing.Size(120, 31);
            this.btn_oneri_ilet.TabIndex = 1;
            this.btn_oneri_ilet.Text = "Gönder";
            this.btn_oneri_ilet.UseVisualStyleBackColor = true;
            this.btn_oneri_ilet.Click += new System.EventHandler(this.btn_oneri_ilet_Click);
            // 
            // rtxt_oneri
            // 
            this.rtxt_oneri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxt_oneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxt_oneri.Location = new System.Drawing.Point(0, 119);
            this.rtxt_oneri.Name = "rtxt_oneri";
            this.rtxt_oneri.Size = new System.Drawing.Size(1228, 539);
            this.rtxt_oneri.TabIndex = 0;
            this.rtxt_oneri.Text = "";
            // 
            // tb_exit
            // 
            this.tb_exit.Controls.Add(this.txt_sifre_exit);
            this.tb_exit.Controls.Add(this.lbl_sifre);
            this.tb_exit.Controls.Add(this.btn_exit);
            this.tb_exit.Controls.Add(this.btn_degis);
            this.tb_exit.Location = new System.Drawing.Point(4, 25);
            this.tb_exit.Name = "tb_exit";
            this.tb_exit.Size = new System.Drawing.Size(1228, 658);
            this.tb_exit.TabIndex = 4;
            this.tb_exit.Text = "Çıkış";
            this.tb_exit.UseVisualStyleBackColor = true;
            // 
            // txt_sifre_exit
            // 
            this.txt_sifre_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sifre_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre_exit.Location = new System.Drawing.Point(206, 306);
            this.txt_sifre_exit.Name = "txt_sifre_exit";
            this.txt_sifre_exit.Size = new System.Drawing.Size(815, 38);
            this.txt_sifre_exit.TabIndex = 0;
            this.txt_sifre_exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sifre_exit.UseSystemPasswordChar = true;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(203, 270);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(140, 17);
            this.lbl_sifre.TabIndex = 2;
            this.lbl_sifre.Text = "Yönetici şifresi giriniz";
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.ImageKey = "(none)";
            this.btn_exit.Location = new System.Drawing.Point(1027, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(201, 658);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Uygulamayı kapat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_degis
            // 
            this.btn_degis.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_degis.Location = new System.Drawing.Point(0, 0);
            this.btn_degis.Name = "btn_degis";
            this.btn_degis.Size = new System.Drawing.Size(201, 658);
            this.btn_degis.TabIndex = 1;
            this.btn_degis.Text = "Kullanıcı değiştir";
            this.btn_degis.UseVisualStyleBackColor = true;
            this.btn_degis.Click += new System.EventHandler(this.btn_degis_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buraya Öneri veya Şikayet giriniz";
            // 
            // siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 687);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "siparis";
            this.Text = "Sipariş ver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.siparis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tb_hosgeldiniz.ResumeLayout(false);
            this.tb_hosgeldiniz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tb_urunler.ResumeLayout(false);
            this.tb_urunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_urunfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_urunler)).EndInit();
            this.tb_oneri_sikayet.ResumeLayout(false);
            this.tb_oneri_sikayet.PerformLayout();
            this.tb_exit.ResumeLayout(false);
            this.tb_exit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_hosgeldiniz;
        private System.Windows.Forms.TabPage tb_urunler;
        private System.Windows.Forms.RichTextBox rtxt_oneri;
        private System.Windows.Forms.Button btn_oneri_ilet;
        private System.Windows.Forms.Label lbl_oneri_musteriNo;
        private System.Windows.Forms.TextBox txt_musteriNo_oneri;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_telNo;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dg_urunler;
        private System.Windows.Forms.Button btn_siparisVer;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_urunAdeti;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.PictureBox pb_urunfoto;
        private System.Windows.Forms.ComboBox cb_adet;
        private System.Windows.Forms.ComboBox cb_filtre;
        private System.Windows.Forms.Label lb_filtre;
        private System.Windows.Forms.Label lbl_musteriNumarası;
        private System.Windows.Forms.TextBox txt_musteriNumarası;
        private System.Windows.Forms.Label lbl_urunNo;
        private System.Windows.Forms.TextBox txt_urunNo;
        private System.Windows.Forms.Label lbl_toplam_fiyat;
        private System.Windows.Forms.TabPage tb_exit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_degis;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre_exit;
        private System.Windows.Forms.TabPage tb_oneri_sikayet;
        private System.Windows.Forms.Label label1;
    }
}

