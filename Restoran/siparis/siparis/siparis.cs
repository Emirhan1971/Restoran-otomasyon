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

namespace siparis
{
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server=192.168.1.102;; database=siparis; Uid=ms; Pwd=123456789;");

        private void btn_oneri_ilet_Click(object sender, EventArgs e)
        {
            if (txt_musteriNo_oneri.Text != "")
            {
                if (rtxt_oneri.Text != "")
                {
                    MySqlCommand komut = new MySqlCommand("insert into oneri(oneri,musteri_no_oneri) values(@oneri,@musteri_no)", baglanti);
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@oneri", rtxt_oneri.Text);
                    komut.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(txt_musteriNo_oneri.Text));

                    komut.ExecuteNonQuery();
                    MySqlCommand komutno = new MySqlCommand("select max(oneri_no) from oneri", baglanti);
                    MySqlDataReader mdr_oneri;
                    mdr_oneri = komutno.ExecuteReader();
                    while (mdr_oneri.Read())
                    {
                        MessageBox.Show(mdr_oneri["max(oneri_no)"].ToString(), "Öneri no", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    baglanti.Close();
                    txt_musteriNo_oneri.Text = "";
                    rtxt_oneri.Text = "";
                    tabControl1.SelectedIndex = 0;
                    pictureBox1.Image = null;

                }
                else
                {
                    MessageBox.Show("Öneri veya Şikayet bölümü boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
             }
          
                 
            else
            {
                MessageBox.Show("Kullanıcı numarası boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                baglanti.Close();
            }
            
        }

       

        private void btn_ileri_Click_1(object sender, EventArgs e)
        {
            if (txt_telNo.Text != "")
            {
                if (txt_soyad.Text != "")
                {

                    MySqlCommand komut = new MySqlCommand("insert into musteri(ad, soyad, tel_no) values(@ad, @soyad, @tel_no)", baglanti);
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@ad", txt_ad.Text);
                    komut.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    komut.Parameters.AddWithValue("@tel_no", txt_telNo.Text);
                    komut.ExecuteNonQuery();
                    MySqlCommand komutNo = new MySqlCommand("select max(musteri_id) from musteri ", baglanti);
                    MySqlDataReader dr;

                    dr = komutNo.ExecuteReader();
                    while (dr.Read())
                    {
                        MessageBox.Show(dr["max(musteri_id)"].ToString(), "Müşleri no", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    baglanti.Close();

                }

                tabControl1.SelectedIndex = 1;

            }
            if (txt_telNo.Text == "")
            {
                if (txt_soyad.Text == "")
                {

                    MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_telNo.Text = "";
        }

        private void siparis_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler", baglanti);
           
            DataTable table = new DataTable();
            adapter.Fill(table);
            dg_urunler.DataSource = table;
           
            
        }

        private void dg_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MySqlCommand komut = new MySqlCommand("select * from urunler where urun_no='" + int.Parse(dg_urunler.CurrentRow.Cells[0].Value.ToString()) + "'",baglanti);
            baglanti.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                if(dr["fotograf"]!=null)
                {
                    byte[] data = new byte[0];
                    data = (byte[])dr["fotograf"];
                     MemoryStream mem = new MemoryStream(data);
                    pb_urunfoto.Image = Image.FromStream(mem);
                    txt_urunadi.Text = dr["urun_adi"].ToString();
                    txt_fiyat.Text = dr["fiyat"].ToString();
                    txt_urunNo.Text = dr["urun_no"].ToString();
                }
            }
            baglanti.Close();
        }

        private void cb_filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_filtre.SelectedIndex==0)
            {
                MySqlDataAdapter adapterkahvalti = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler where katagori='kahvaltı'", baglanti);
                DataTable tablokahvalti = new DataTable();
                adapterkahvalti.Fill(tablokahvalti);
                dg_urunler.DataSource = tablokahvalti;

            }
            if(cb_filtre.SelectedIndex==1)
            {
                MySqlDataAdapter adapterogleyemegi = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler where katagori='Öğle yemeği'", baglanti);
                DataTable tablo_ogleyemegi = new DataTable();
                adapterogleyemegi.Fill(tablo_ogleyemegi);
                dg_urunler.DataSource = tablo_ogleyemegi;
            }
            if(cb_filtre.SelectedIndex==2)
            {
                MySqlDataAdapter adapterakşamyemegi = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler where katagori='Akşam yemeği'", baglanti);
                DataTable tablo_akşamyemegi = new DataTable();
                adapterakşamyemegi.Fill(tablo_akşamyemegi);
                dg_urunler.DataSource = tablo_akşamyemegi;
            }
            if(cb_filtre.SelectedIndex==3)
            {
                MySqlDataAdapter adapterkapali = new MySqlDataAdapter("select urun_no as'Ürün numarası', urun_adi as 'urun adi', katagori, fiyat as 'Fiyat' from urunler", baglanti);

                DataTable tablekapali = new DataTable();
                adapterkapali.Fill(tablekapali);
                dg_urunler.DataSource = tablekapali;

            }
        }

        private void btn_siparisVer_Click(object sender, EventArgs e)
        {
            double hesap = Convert.ToDouble(txt_fiyat.Text) * Convert.ToDouble(cb_adet.Text);
           
            MySqlCommand komutsiparis = new MySqlCommand("insert into siparisler(urun_no,urun_adi,musteri_nuım,adet,toplam_hesap) values (@urun_no ,@urun_adi ,@musteri_no ,@adet,@hesap)", baglanti);
           
            baglanti.Open();
            komutsiparis.Parameters.AddWithValue("@urun_no", txt_urunNo.Text);
            komutsiparis.Parameters.AddWithValue("@urun_adi", txt_urunadi.Text);

            komutsiparis.Parameters.AddWithValue("@adet", cb_adet.Text);
            komutsiparis.Parameters.AddWithValue("@musteri_no", txt_musteriNumarası.Text);
            komutsiparis.Parameters.AddWithValue("@hesap", hesap);

            komutsiparis.ExecuteNonQuery();

            MySqlCommand komuttoplam = new MySqlCommand("insert into toplam(musteri_notoplam,toplam_fiyat) values (@musteri_notoplam,@toplamfiyat)", baglanti);
            MessageBox.Show("Siparişiniz alınmıştır.", "Afiyet olsun", MessageBoxButtons.OK, MessageBoxIcon.None);
            txt_urunNo.Text = "";
            txt_urunadi.Text = "";
            cb_adet.Text = "1";
            txt_musteriNumarası.Text = "";
            lbl_toplam_fiyat.Text = "";
            txt_fiyat.Text = "";
            tabControl1.SelectedIndex = 0;
            baglanti.Close(); 
           
           if(txt_musteriNumarası==null)
            {
                MessageBox.Show("Lütfen müşleri numaranızı giriniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void cb_adet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_adet.SelectedIndex >= 0)
                {
                    double hesap = Convert.ToDouble(txt_fiyat.Text) * Convert.ToDouble(cb_adet.Text);
                     lbl_toplam_fiyat.Text = "Toplam fiyat: "+hesap.ToString() + "TL";
                     
                }
                
            }
            catch
            {
                MessageBox.Show("Lütfen ilk önce ürün seçiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void tb_hosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        private void btn_degis_Click(object sender, EventArgs e)
        {

            string sorgu = "select sifre from yonetici";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            bool sifre = true;
            Giris g = new Giris();
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
                if (dr.Read() == false && sifre == true)
                {
                    if (dr["sifre"].ToString() != txt_sifre_exit.Text)
                    {
                        MessageBox.Show("Yanlış şifre","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }
                    baglanti.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bool sifre = true;
            Giris g = new Giris();
            if (txt_sifre_exit.Text != "")
            {
                while (dr.Read())
                {
                    if (dr["sifre"].ToString() == txt_sifre_exit.Text)
                    {
                        sifre = false;
                        this.Close();
                        Application.Exit();
                        if (dr.Read() == true && dr["sifre"].ToString() == txt_sifre_exit.Text)
                        {
                            break;
                        }
                    }
                   
                }
                if (dr.Read() == false && sifre==false)
                {
                    if (dr["sifre"].ToString() != txt_sifre_exit.Text)
                    {
                        MessageBox.Show("Yanlış şifre","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }
                    baglanti.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz", "UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                baglanti.Close();
            }
           
        }
    }
}
