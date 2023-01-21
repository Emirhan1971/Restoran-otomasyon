
namespace siparis
{
    partial class yonetici_kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetici_kayit));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_tcNO = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_tcNO = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_yonetici_ekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(115, 67);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(169, 22);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(115, 132);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(169, 22);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_tcNO
            // 
            this.txt_tcNO.Location = new System.Drawing.Point(115, 213);
            this.txt_tcNO.Name = "txt_tcNO";
            this.txt_tcNO.Size = new System.Drawing.Size(169, 22);
            this.txt_tcNO.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(115, 285);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(169, 22);
            this.txt_sifre.TabIndex = 3;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.Color.Black;
            this.lbl_ad.ForeColor = System.Drawing.Color.White;
            this.lbl_ad.Location = new System.Drawing.Point(80, 72);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "Ad:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.ForeColor = System.Drawing.Color.White;
            this.lbl_soyad.Location = new System.Drawing.Point(57, 135);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(52, 17);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_tcNO
            // 
            this.lbl_tcNO.AutoSize = true;
            this.lbl_tcNO.ForeColor = System.Drawing.Color.White;
            this.lbl_tcNO.Location = new System.Drawing.Point(21, 216);
            this.lbl_tcNO.Name = "lbl_tcNO";
            this.lbl_tcNO.Size = new System.Drawing.Size(88, 17);
            this.lbl_tcNO.TabIndex = 6;
            this.lbl_tcNO.Text = "TC kimlik no:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_sifre.Location = new System.Drawing.Point(27, 285);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(82, 17);
            this.lbl_sifre.TabIndex = 7;
            this.lbl_sifre.Text = "Şifre giriniz:";
            // 
            // btn_yonetici_ekle
            // 
            this.btn_yonetici_ekle.Location = new System.Drawing.Point(160, 358);
            this.btn_yonetici_ekle.Name = "btn_yonetici_ekle";
            this.btn_yonetici_ekle.Size = new System.Drawing.Size(124, 30);
            this.btn_yonetici_ekle.TabIndex = 8;
            this.btn_yonetici_ekle.Text = "Yönetici Ekle";
            this.btn_yonetici_ekle.UseVisualStyleBackColor = true;
            this.btn_yonetici_ekle.Click += new System.EventHandler(this.btn_yonetici_ekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 500);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(160, 436);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(148, 50);
            this.btn_giris.TabIndex = 10;
            this.btn_giris.Text = "Giriş sayfasına geri dön";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // yonetici_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(611, 498);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_yonetici_ekle);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tcNO);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tcNO);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yonetici_kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici kayıt";
            this.Load += new System.EventHandler(this.yonetici_kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_tcNO;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_tcNO;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_yonetici_ekle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_giris;
    }
}