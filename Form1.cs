using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HastaneKayit
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       

        public OleDbConnection uyelerBaglantisi = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=hastaneBilgileri.accdb");


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        bool giris_Yapildimi = false;
        bool banlanmismi = false;
        
        void BanGunuGuncelle()
        {
            string banGunu = "";
            string banTarihi = "";
            DateTime bugun = DateTime.Now;
            banlanmismi = false;
            try
            {
                uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='"+maskedtxtTC.Text+"'",uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    banGunu = rd["ban"].ToString();
                    banTarihi = rd["banTarihi"].ToString();
                }                
                uyelerBaglantisi.Close();

                DateTime banTarihiDate = DateTime.Parse(banTarihi);
                banTarihiDate = banTarihiDate.AddDays(int.Parse(banGunu));
                DateTime bugununDate = DateTime.Parse(bugun.ToShortDateString());
                TimeSpan kalanGun = banTarihiDate - bugununDate;
                if (int.Parse(kalanGun.TotalDays.ToString()) > 0)
                {
                    MessageBox.Show("You are not allowed to enter the system for " + kalanGun.TotalDays.ToString() + " days.");
                    giris_Yapildimi = true;
                    banlanmismi = true;
                }
                
            }
            catch (Exception )
            {
            }

        }

        bool Admin_Girdimi = false;
        bool Doktor_Girdimi = false;
        void Admin_Girisi()
        {
            //Admin_Girdimi = false;
            //try
            //{
            //    uyelerBaglantisi.Open();
            //    OleDbCommand cmd0 = new OleDbCommand("Select * From Admin where KullaniciAdi='" + maskedtxtTC.Text + "' and Parola='" + txtParola.Text + "'", uyelerBaglantisi);
            //    cmd0.ExecuteNonQuery();
            //    OleDbDataReader rd0 = cmd0.ExecuteReader();
            //    while (rd0.Read())
            //    {
            //        AdminPaneli AmdPanel = new AdminPaneli();
            //        AmdPanel.Show();
            //        this.Hide();
            //        Admin_Girdimi = true;
            //        giris_Yapildimi = true;
            //    }
            //    uyelerBaglantisi.Close();
            //}
            //catch (Exception hata)
            //{                
            //    MessageBox.Show(hata.Message);
            //}
            if (maskedtxtTC.Text == "00000000000" && txtParola.Text == "00000")
            {
                AdminPaneli AmdPanel = new AdminPaneli();
                AmdPanel.Show();
                this.Hide();
                Admin_Girdimi = true;
                giris_Yapildimi = true;
            }
        }

        void Doktor_Girisi()
        {
            Doktor_Girdimi = false;
            Admin_Girdimi = false;
            try
            {
                uyelerBaglantisi.Open();
                OleDbCommand cmd0 = new OleDbCommand("Select * From Doktorlar where KullaniciAdi='" + maskedtxtTC.Text + "' and Sifre='" + txtParola.Text + "'", uyelerBaglantisi);
                cmd0.ExecuteNonQuery();
                OleDbDataReader rd0 = cmd0.ExecuteReader();
                while (rd0.Read())
                {
                    Doktor dr = new Doktor(maskedtxtTC.Text,txtParola.Text);
                    dr.Show();
                    this.Hide();
                    Doktor_Girdimi = true;
                    giris_Yapildimi = true;
                }
                uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void Uye_Girisi()
        {
            BanGunuGuncelle();

            try
                {
                    uyelerBaglantisi.Open();
                    OleDbCommand cmd1 = new OleDbCommand("Select * From Uyeler where TC='" + maskedtxtTC.Text + "' and Parola='" + txtParola.Text + "'", uyelerBaglantisi);
                    cmd1.ExecuteNonQuery();
                    OleDbDataReader rd1 = cmd1.ExecuteReader();

                    while (rd1.Read())
                    {                 
                        if (banlanmismi == false)
                        {
                            randevuAra rara = new randevuAra(maskedtxtTC.Text, txtParola.Text);
                            rara.Show();
                            this.Hide();
                            giris_Yapildimi = true;
                        }
                    }
                    uyelerBaglantisi.Close();

                    if (giris_Yapildimi == false)
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı/Parola");
                    }
                }
                catch (Exception)
                {
                    uyelerBaglantisi.Close();
                    MessageBox.Show("Bağlantı Sağlanamadı");
                }
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Admin_Girisi();
            if (Admin_Girdimi==false)
            {
                Doktor_Girisi();
            }
            if (Admin_Girdimi==false && Doktor_Girdimi==false)
            {
                Uye_Girisi();
            }
        }

        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            yeniUye yeniuye = new yeniUye();
            yeniuye.ShowDialog();
        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            ParolamiUnuttum pUnuttum = new ParolamiUnuttum();
            pUnuttum.ShowDialog();
        }

        private void maskedtxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtParola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnGiris_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            uyelerBaglantisi.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
