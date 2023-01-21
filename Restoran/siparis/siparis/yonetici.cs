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
using System.IO;
using System.Threading;

namespace siparis
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=192.168.1.102; database=siparis; Uid=ms; Pwd=123456789;");

        public object byteFotoo { get; set; }

        private void yonetici_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler", baglanti);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dg_yonetici_urunler.DataSource = table;
        }

        bool dosyayukleme = false;
        public void btn_dosyaSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *png; *gif)|*.jpg; *png; *gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                }
                byte[] bytefoto = System.IO.File.ReadAllBytes(opf.FileName);
                string base64 = Convert.ToBase64String(bytefoto);
                byteFotoo = bytefoto;
                dosyayukleme = true;

            }
            catch
            {
                MessageBox.Show("Fotoğraaf yüklemesi iptal edildi");
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
                if (dosyayukleme == true)

            {
                if (txt_urunAdi.Text == "" || txt_fiyat.Text == "" || cb_katagori.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txt_urunAdi.Text != "" && txt_fiyat.Text != "" && cb_katagori.Text != "")
                {
                    MySqlCommand komut = new MySqlCommand("insert into urunler(urun_adi,katagori,fotograf,fiyat) values(@adurun,@katagori,@fotograf,@fiyat)", baglanti);
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@adurun", txt_urunAdi.Text);
                    komut.Parameters.AddWithValue("@katagori", cb_katagori.Text);
                    komut.Parameters.AddWithValue("@fotograf", byteFotoo);
                    komut.Parameters.AddWithValue("@fiyat", txt_fiyat.Text);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Ürün eklendi", "ürün eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();

                    MySqlDataAdapter adapter = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler", baglanti);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dg_yonetici_urunler.DataSource = table;
                    txt_urunAdi.Text = "";
                    txt_fiyat.Text = "";
                    cb_katagori.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Lütfen boş alanları doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void tb_urunEkle_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {

                MySqlDataAdapter adaptersiparisler = new MySqlDataAdapter("select musteri_nuım as 'Müşteri numarası', urun_no as 'Ürün numarası',urun_adi as 'Ürün adı' ,adet as 'Adet', toplam_hesap as 'Toplam hesap' from siparisler", baglanti);
                DataTable tablosiparis = new DataTable();
                adaptersiparisler.Fill(tablosiparis);
                dg_siparisler.DataSource = tablosiparis;
            }
            if (tabControl1.SelectedIndex == 3)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select oneri_no as 'Öneri veya Şikayet numarası', oneri as 'Öneri veya Şikayet',musteri_no_oneri as 'Müşteri numarası' from oneri", baglanti);
                DataTable tablo_oneri = new DataTable();
                adapter.Fill(tablo_oneri);
                dg_oneri.DataSource = tablo_oneri;

            }
            if (tabControl1.SelectedIndex == 4)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select musteri_id as 'Müşteri numarası',ad as 'Ad',soyad as 'Soyad', tel_no as 'Telefon numarası' from musteri ", baglanti);
                DataTable tablo_musteri = new DataTable();
                adapter.Fill(tablo_musteri);
                dg_musteriler.DataSource = tablo_musteri;
            }
        }

        private void dg_yonetici_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("select * from urunler where urun_no='" + int.Parse(dg_yonetici_urunler.CurrentRow.Cells[0].Value.ToString()) + "'", baglanti);
            baglanti.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["fotograf"] != null)
                {
                    byte[] data = new byte[0];
                    data = (byte[])dr["fotograf"];
                    MemoryStream mem = new MemoryStream(data);
                    pb_yoneticiurunler.Image = Image.FromStream(mem);
                }
            }
            baglanti.Close();
        }

        private void dg_siparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_degis_Click(object sender, EventArgs e)
        {
            string sorgu = "select sifre from yonetici";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            Giris g = new Giris();
            bool sifre= true;
            if (txt_sifre_exit.Text != "")
            {
                while (dr.Read())
                {
                    if (dr["sifre"].ToString() == txt_sifre_exit.Text)
                    {
                        this.Close();
                        g.Show();
                        sifre = false;
                        if (dr.Read() == true && dr["sifre"].ToString() == txt_sifre_exit.Text)
                        {
                            break;
                        }

                    }
                    
                }
                if (dr.Read() == false && sifre==true)
                {
                    if (dr["sifre"].ToString() != txt_sifre_exit.Text )
                    {
                        MessageBox.Show("Yanlış şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    baglanti.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            string sorgu = "select sifre from yonetici";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            Giris g = new Giris();
            bool sifre = true;
            if (txt_sifre_exit.Text != "")
            {
                while (dr.Read())
                {
                    if (dr["sifre"].ToString() == txt_sifre_exit.Text)
                    {
                        this.Close();
                        Application.Exit();
                        sifre = false;
                        if (dr.Read() == true && dr["sifre"].ToString() == txt_sifre_exit.Text)
                        {
                            break;
                        }
                    }
                   
                }
                if (dr.Read() == false && sifre==true)
                {
                    if (dr["sifre"].ToString() != txt_sifre_exit.Text)
                    {
                        MessageBox.Show("Yanlış şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    baglanti.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
            }

        }
    }
}
    