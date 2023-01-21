using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace siparis
{
    public partial class yonetici_kayit : Form
    {
        public yonetici_kayit()
        {
            InitializeComponent();
        }
MySqlConnection baglanti = new MySqlConnection("server=192.168.1.102; database=siparis; uid=ms; pwd=123456789;");
       
        private void btn_yonetici_ekle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_soyad.Text != "" && txt_tcNO.Text != "" && txt_sifre.Text != "")
            {
               
                MySqlCommand komut = new MySqlCommand("insert into yonetici(ad,soyad,tc_no,sifre) values(@ad,@soyad,@tcNo,@sifre);", baglanti);

                baglanti.Open();
                komut.Parameters.AddWithValue("@ad", txt_ad.Text);
                komut.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                komut.Parameters.AddWithValue("@tcNO", txt_tcNO.Text);
                komut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yönetici kaydoldu", "Kayıt başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);                                                                                                                                                                                                                                                                                                                                                                                                 //Tasarlayan: Emirhan Susam                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                baglanti.Close();
                txt_ad.Text = "";
                txt_sifre.Text = "";
                txt_soyad.Text = "";
                txt_tcNO.Text = "";

            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void yonetici_kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
