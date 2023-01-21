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
using System.Configuration;
namespace siparis
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            
        }
       
        MySqlConnection baglanti=new MySqlConnection("server=192.168.1.102; database=siparis; Uid=ms; Pwd=123456789;");
        
        private void Giris_Load(object sender, EventArgs e)
        { 
          lbl_sifre.Visible = false;
          txt_sifre.Visible=false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                lbl_sifre.Visible = true;
                txt_sifre.Visible=true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                lbl_sifre.Visible = false;
                txt_sifre.Visible = false;
            }
        }
        
       private void btn_giris_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                siparis s = new siparis();
                s.Show();
                this.Hide();


            }
            if (comboBox1.SelectedIndex==0)
            {

                {
                    
                    if (txt_sifre.Text == "0000")
                    {
                        yonetici_kayit yk = new yonetici_kayit();
                        yk.Show();
                        this.Hide();
                    }
                    else if (txt_sifre.Text != "0000")
                    {
                        string sorgu = "select sifre from yonetici";
                        MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                        MySqlDataReader dr;
                        baglanti.Open();
                        dr = komut.ExecuteReader();
                        yonetici y = new yonetici();
                        bool sifre = true; 
                        if (txt_sifre.Text != "")
                        {
                            while (dr.Read())
                            {
                                if (dr["sifre"].ToString() == txt_sifre.Text)
                                {
                                    txt_sifre.Text = "";
                                    this.Hide();
                                    y.Show();
                                    sifre = false;
                                    if (dr.Read() == true && dr["sifre"].ToString() == txt_sifre.Text)
                                    { 
                                        break;
                                    }
                                }
                            }
                           
                            if (dr.Read() == false && dr["sifre"].ToString() != txt_sifre.Text && sifre==true) 
                            {
                                baglanti.Close();
                                MessageBox.Show("Yanlış şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                
                                
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
           

        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
