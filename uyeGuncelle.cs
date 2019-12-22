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
    public partial class uyeGuncelle : Form
    {
        string tcNo = "";
        string Parola = "";
        public uyeGuncelle()
        {
            InitializeComponent();
        }
        public uyeGuncelle(string tc,string parola)
        {
            InitializeComponent();
            tcNo = tc;
            Parola = parola;
        }

        Form1 frm1 = new Form1();
        

        private void uyeGuncelle_Load(object sender, EventArgs e)
        {

            texboxlarEnteraBasinca();
            try
            {
                frm1.uyelerBaglantisi.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='" + tcNo + "'", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    maskedtxtTC.Text = frm1.maskedtxtTC.Text;
                    txtAd.Text = rd["Adı"].ToString();
                    txtSoyad.Text = rd["Soyadı"].ToString();
                    txtDogumYeri.Text = rd["DogumYeri"].ToString();
                    maskedtxtDogumTarihi.Text = rd["DogumTarihi"].ToString();
                    txtBabaAdı.Text = rd["BabaAdı"].ToString();
                    txtAnneAdı.Text = rd["AnneAdı"].ToString();
                    maskedtxtCepTel.Text = rd["CepTel"].ToString();
                    maskedtxtSabitTel.Text = rd["SabitTel"].ToString();
                    txtEposta.Text = rd["Eposta"].ToString();
                    txtEpostaTekrar.Text = txtEposta.Text;
                    txtParola.Text = "";
                    txtParolaTekrar.Text = "";
                    if (rd["Cinsiyeti"].ToString() == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (rd["Cinsiyeti"].ToString() == "Female")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                }

                frm1.uyelerBaglantisi.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        bool hata_Varmi = false;
        bool eposta_Hatalimi = false;
        bool parola_Hatalimi = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control kontroller in this.Controls)
            {
                if (kontroller is MaskedTextBox || kontroller is TextBox)
                {
                    if (kontroller.Text.Trim() == "" || maskedtxtTC.Text.Length != 11 || maskedtxtDogumTarihi.Text.Length != 10 || maskedtxtSabitTel.Text.Length != 14 || maskedtxtCepTel.Text.Length != 14)
                    {
                        hata_Varmi = true;
                        break;
                    }
                    else
                        hata_Varmi = false;
                }
            }

            ///EPOSTA KONTROLÜ
            if (txtEposta.Text != txtEpostaTekrar.Text)
            {
                errorProviderEPOSTA.SetError(txtEposta, "Email Addresses Do Not Match.");
                eposta_Hatalimi = true;
            }
            else
            {
                errorProviderEPOSTA.Dispose();
                eposta_Hatalimi = false;
            }
            ///EPOSTA KONTROLÜ
            ///
            ///PAROLA KONTROLU
            if (txtEskiParola.Text==Parola)
            {

                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    errorProviderPAROLA.SetError(txtParola, "Passwords Do Not Match.");
                    parola_Hatalimi = true;
                }
                else
                {
                    errorProviderPAROLA.Dispose();
                    parola_Hatalimi = false;
                }
            }
            else
            {
                parola_Hatalimi = true;
                MessageBox.Show("Password Incorrect");
            }
            ///PAROLA KONTROLU

            if (hata_Varmi || eposta_Hatalimi || parola_Hatalimi)
            {
                errorProvider1.SetError(btnKaydet, "Check Information.");
            }

            //KONTROLLER TAMAM
            if (hata_Varmi == false && eposta_Hatalimi == false && parola_Hatalimi == false)
            {
                foreach (Control kontroller in this.Controls)
                {
                    kontroller.Enabled = false;
                }

                errorProvider1.Dispose();
                uyeEkle();
            }
        }

        void texboxlarEnteraBasinca()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox || txt is MaskedTextBox || txt is RadioButton)
                {
                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
                }
                if (txt is TextBox || txt is MaskedTextBox)
                {
                    txt.Text = "";
                }
                if (txt is MaskedTextBox)
                {
                    txt.Text = "1";
                    txt.Text = "";
                }
            }
        }
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        void uyeEkle()
        {

            string cinsiyet = "Other";
            if (radioButton1.Checked == true)
                cinsiyet = "Male";
            if (radioButton2.Checked == true)
                cinsiyet = "Female";
            if (radioButton3.Checked == true)
                cinsiyet = "Other";


            try
            {
                KontrollerPasif();
                frm1.uyelerBaglantisi.Open();

                OleDbCommand cmd1 = new OleDbCommand("Select * From Uyeler", frm1.uyelerBaglantisi);
                cmd1.ExecuteNonQuery();
                OleDbDataReader rd = cmd1.ExecuteReader();

                OleDbCommand cmdGuncelle = new OleDbCommand("Update uyeler set Adı='" + txtAd.Text + "',Soyadı='" + txtSoyad.Text + "',DogumYeri='" + txtDogumYeri.Text + "',DogumTarihi='" + maskedtxtDogumTarihi.Text + "',BabaAdı='" + txtBabaAdı.Text + "',AnneAdı='" + txtAnneAdı.Text + "',CepTel='" + maskedtxtCepTel.Text + "',SabitTel='" + maskedtxtSabitTel.Text + "',Eposta='" + txtEposta.Text + "',Parola='" + txtParola.Text + "',Cinsiyeti='" + cinsiyet + "' where TC='" + tcNo + "'", frm1.uyelerBaglantisi);
                cmdGuncelle.ExecuteNonQuery();
                MessageBox.Show("Process Successful.");
                frm1.uyelerBaglantisi.Close();
                this.Close();

            }
            catch (Exception mse)
            {
                MessageBox.Show(mse.Message);
                frm1.uyelerBaglantisi.Close();
            }
        }
        void kontrolleriTemizleme()
        {
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is MaskedTextBox || kontrol is TextBox)
                {
                    kontrol.Text = null;
                }
                kontrol.Enabled = true;
            }
        }
        void KontrollerPasif()
        {
            foreach (Control asd in this.Controls)
            {
                asd.Enabled = false;
            }
        }
        void KontrollerEtkin()
        {
            foreach (Control asd in this.Controls)
            {
                asd.Enabled = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                    maskedtxtCepTel.Text = "";
                    maskedtxtDogumTarihi.Text = "";
                    maskedtxtSabitTel.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

