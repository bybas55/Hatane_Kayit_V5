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
    public partial class yeniUye : Form
    {
    
        public yeniUye()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();

        private void yeniUye_Load(object sender, EventArgs e)
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

                bool oncedenKayitYapilmismi = false;

                OleDbCommand cmd1 = new OleDbCommand("Select * From Uyeler", frm1.uyelerBaglantisi);
                cmd1.ExecuteNonQuery();
                OleDbDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    if (rd["TC"].ToString() == maskedtxtTC.Text)
                    {
                        MessageBox.Show("You Have Previous Record. \n If you have forgotten your password, please visit the Forgot Password section.");
                        oncedenKayitYapilmismi = true;
                        KontrollerEtkin();
                        this.Close();
                        break;
                    }
                }

                if (oncedenKayitYapilmismi == false)
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Uyeler(TC,Adı,Soyadı,Cinsiyeti,DogumYeri,DogumTarihi,BabaAdı,AnneAdı,CepTel,SabitTel,Eposta,Parola) values ('" + maskedtxtTC.Text.ToString() + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + cinsiyet + "','" + txtDogumYeri.Text + "','" + maskedtxtDogumTarihi.Text.ToString() + "','" + txtBabaAdı.Text + "','" + txtAnneAdı.Text + "','" + maskedtxtCepTel.Text.ToString() + "','" + maskedtxtSabitTel.Text.ToString() + "','" + txtEposta.Text + "','" + txtParola.Text + "')", frm1.uyelerBaglantisi);
                    cmd.ExecuteNonQuery();


                    frm1.uyelerBaglantisi.Close();
                    MessageBox.Show("Process Successful.");
                    this.Close();
                    kontrolleriTemizleme();

                    frm1.uyelerBaglantisi.Close();
                }

            }
            catch (Exception mse)
            {                
                MessageBox.Show(mse.Message);
                kontrolleriTemizleme();
                this.Close();
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
                if (txt is TextBox || txt is MaskedTextBox)
                {
                    txt.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniUye_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.uyelerBaglantisi.Close();
        }

    }
}
