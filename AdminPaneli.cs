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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        string klinikid1 = "";
        string klinikid2 = "";
        string klinikid3 = "";
        int uye_Sayisi = 0;

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            UyeleriGetir();
            KlinikleriGetir();

            uyeSayisiHesapla();

        }
        void KlinikleriGetir()
        {
            listBoxKlinik.Items.Clear();
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Klinik", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listBoxKlinik.Items.Add(rd["KlinikAdi"].ToString());
                }

                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void AdminPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime dateSaat = DateTime.Now;
            lblSaat.Text = dateSaat.ToLongTimeString();
            lblTarih.Text = dateSaat.ToLongDateString();
        }

        private void listBoxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDoktor.Items.Clear();

            try
            {
                frm1.uyelerBaglantisi.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Klinik where KlinikAdi='"+listBoxKlinik.SelectedItem.ToString()+"'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    klinikid1 = rd["Klinikid"].ToString();
                }

                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }

            try
            {
                frm1.uyelerBaglantisi.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Doktorlar where Klinikid=@id", frm1.uyelerBaglantisi);
                cmd.Parameters.AddWithValue("@id", klinikid1);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listBoxDoktor.Items.Add(rd["DoktorAdiSoyadi"].ToString());
                }

                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
        }

        private void btnKlinikEkle_Click(object sender, EventArgs e)
        {
            pnlKlinikEkle.Visible = true;
            pnlDoktorEkle.Visible = false;
            txtKlinikEkle.Select();
        }

        private void btnKlinikSil_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxKlinik.SelectedItem.ToString();

                //SİL KLİNİK
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd2 = new OleDbCommand("Select * From Klinik where KlinikAdi='"+listBoxKlinik.SelectedItem.ToString()+"'",frm1.uyelerBaglantisi);
                cmd2.ExecuteNonQuery();
                OleDbDataReader rd = cmd2.ExecuteReader();
                while (rd.Read())
                {
                    klinikid2 = rd["Klinikid"].ToString();
                }

                OleDbCommand cmd = new OleDbCommand("Delete * From Klinik where KlinikAdi='" + listBoxKlinik.SelectedItem.ToString() + "'", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();

                OleDbCommand cmd1 = new OleDbCommand("Delete * From Doktorlar where Klinikid=@id",frm1.uyelerBaglantisi);
                cmd1.Parameters.AddWithValue("@id", klinikid2);
                cmd1.ExecuteNonQuery();

                frm1.uyelerBaglantisi.Close();
                KlinikleriGetir();
                listBoxDoktor.Items.Clear();

            }
            catch (Exception)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show("Silinecek Kliniği Seçmediniz");
            }
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxKlinik.SelectedItem.ToString();
                pnlDoktorEkle.Visible = true;
                pnlKlinikEkle.Visible = false;
                txtDoktorKullaniciAdi.Select();
            }
            catch (Exception)
            {
                MessageBox.Show("Doktoru Ekeleyeceğiniz Kliniği Seçmediniz");
            }
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxDoktor.SelectedItem.ToString();
                
                //DOKTORU SİL
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Delete * From Doktorlar where DoktorAdiSoyadi='" + listBoxDoktor.SelectedItem.ToString() + "'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                frm1.uyelerBaglantisi.Close();
                listBoxKlinik_SelectedIndexChanged(sender, e);

            }
            catch (Exception)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show("Silinecek Doktoru Seçmediniz");
            }
        }

        private void pnlKlinikEkleTamam_Click(object sender, EventArgs e)
        {
            if (txtKlinikEkle.Text.Trim()!="")
            {
                try
                {
                    frm1.uyelerBaglantisi.Open();

                    OleDbCommand cmd = new OleDbCommand("insert into Klinik (Klinikadi) values ('"+txtKlinikEkle.Text+"')",frm1.uyelerBaglantisi);
                    cmd.ExecuteNonQuery();

                    frm1.uyelerBaglantisi.Close();
                    KlinikleriGetir();
                }
                catch (Exception hata)
                {
                    frm1.uyelerBaglantisi.Close();
                    MessageBox.Show(hata.Message);
                }
            }
            btnKlinikİptal_Click(sender, e);
        }

        bool kullaniciAdiKontroluTammammi = false;

        void kullaniciAdi_Kontrolu()
        {
            
            kullaniciAdiKontroluTammammi = false;
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='"+txtDoktorKullaniciAdi.Text+"'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("This User Name / Code Has Been Taken Before."); //// UYELERİN KULLANICI ADI KONTROL EDİLDİ
                    kullaniciAdiKontroluTammammi = false;
                }
                else
                {
                    kullaniciAdiKontroluTammammi = true;
                }

                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


            if (kullaniciAdiKontroluTammammi)
            {
                try
                {
                    frm1.uyelerBaglantisi.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * From Doktorlar where KullaniciAdi='" + txtDoktorKullaniciAdi.Text + "'", frm1.uyelerBaglantisi);
                    cmd.ExecuteNonQuery();
                    OleDbDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("This User Name / Code Has Been Taken Before."); //// UYELERİN KULLANICI ADI KONTROL EDİLDİ
                        kullaniciAdiKontroluTammammi = false;
                    }
                    else
                    {
                        kullaniciAdiKontroluTammammi = true;
                    }

                    frm1.uyelerBaglantisi.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }


        }

        private void DoktorEkleTamam_Click(object sender, EventArgs e)
        {
            kullaniciAdi_Kontrolu();
            if (kullaniciAdiKontroluTammammi == true)
            {
                try
                {
                    frm1.uyelerBaglantisi.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * From Klinik where KlinikAdi='" + listBoxKlinik.SelectedItem.ToString() + "'", frm1.uyelerBaglantisi);
                    cmd.ExecuteNonQuery();
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        klinikid3 = rd["Klinikid"].ToString();
                    }
                    frm1.uyelerBaglantisi.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

                if (txtDoktorEkle.Text.Trim() != "" && txtDoktorParola.Text.Trim() != "")
                {
                    try
                    {
                        frm1.uyelerBaglantisi.Open();

                        OleDbCommand cmd = new OleDbCommand("insert into Doktorlar (KullaniciAdi,Klinikid,DoktorAdiSoyadi,Sifre) values ('" + txtDoktorKullaniciAdi.Text + "','" + klinikid3 + "','" + txtDoktorEkle.Text + "','" + txtDoktorParola.Text + "')", frm1.uyelerBaglantisi);
                        cmd.ExecuteNonQuery();
                        frm1.uyelerBaglantisi.Close();
                        listBoxKlinik_SelectedIndexChanged(sender, e);
                    }
                    catch (Exception hata)
                    {
                        frm1.uyelerBaglantisi.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                btnDoktorIptal_Click(sender, e);
            }
            

            
        }

        public string SecilenDoktor ;
        private void btnDoktorBilgileri_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxDoktor.SelectedItem.ToString();
                DoktorBilgileri dBilgileri = new DoktorBilgileri();
                dBilgileri.txtAdSoyad.Text = SecilenDoktor;
                dBilgileri.ShowDialog();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Doktor Seçmediniz");
            }
        }

        private void listBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SecilenDoktor = listBoxDoktor.SelectedItem.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnKlinikİptal_Click(object sender, EventArgs e)
        {
            pnlKlinikEkle.Visible = false;
            txtKlinikEkle.Text = "";
            
        }

        private void btnDoktorIptal_Click(object sender, EventArgs e)
        {
            pnlDoktorEkle.Visible = false;
            txtDoktorParola.Text = "";
            txtDoktorEkle.Text = "";
            txtDoktorKullaniciAdi.Text = "";
        }


        void UyeleriGetir()
        {
            listView1.Items.Clear();
            int i = 0;
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listView1.Items.Add(rd["TC"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Adı"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Soyadı"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Cinsiyeti"].ToString());
                    i++;
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            string TC = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                TC = itm.SubItems[0].Text;
            }
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Delete * From Uyeler where TC='"+TC+"'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                frm1.uyelerBaglantisi.Close();
                UyeleriGetir();
                uye_Sayisi = 0;
                uyeSayisiHesapla();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
            
        }

        private void btnBanla_Click(object sender, EventArgs e)
        {
            string banlanacakTC = "";
            string banGunu = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                banlanacakTC = itm.SubItems[0].Text;
            }
            banGunu = numericUpDown1.Value.ToString();
            if (banlanacakTC != "")
            {
                DateTime date = DateTime.Now;
                try
                {
                    frm1.uyelerBaglantisi.Open();
                    OleDbCommand cmd = new OleDbCommand("Update Uyeler set ban ='" + banGunu + "',banTarihi='"+date.ToShortDateString()+"' where TC='" + banlanacakTC + "'", frm1.uyelerBaglantisi);
                    cmd.ExecuteNonQuery();
                    frm1.uyelerBaglantisi.Close();
                    MessageBox.Show("İşlem Başarılı");
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string TC = "";
             if (listView1.SelectedItems.Count > 0)
             {
                 ListViewItem itm = listView1.SelectedItems[0];
                 TC = itm.SubItems[0].Text;
             }


            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='"+TC+"'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    numericUpDown1.Value = int.Parse(rd["ban"].ToString());
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                if (hata.Message=="Input string was not in a correct format.")
                {
                    numericUpDown1.Value = 0;
                }
                else
                {
                    MessageBox.Show(hata.Message);
                }
                
            }
        }
        void uyeSayisiHesapla()
        {
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    uye_Sayisi++;
                }
                frm1.uyelerBaglantisi.Close();
                lblUyeSayisi.Text = "There are " + uye_Sayisi + " members in the system.";
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
        }

        
    }
}
