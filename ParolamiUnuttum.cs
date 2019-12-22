using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace HastaneKayit
{
    public partial class ParolamiUnuttum : Form
    {               

        public ParolamiUnuttum()
        {
            InitializeComponent();
        }


        Form1 frm1 = new Form1();

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='"+maskedtxtTC.Text+"'", frm1.uyelerBaglantisi);
                OleDbDataReader dr = cmd.ExecuteReader();
                bool parola_Verildimi = false;
                while (dr.Read())
                {
                    try
                    {
                        SmtpClient smtpserver = new SmtpClient();
                        MailMessage mail = new MailMessage();

                        String mailadresin = ("sefacanak@hotmail.com"); // msn
                        String mailsifren = ("123456789"); // sifre
                        String smptsrvr = "smtp.live.com"; // dokunma
                        String kime = (dr["Eposta"].ToString());
                        String konu = ("Password"); //konu
                        String yazi = ("Dear "+dr["Adı"].ToString()+" "+dr["Soyadı"].ToString()+"\n Password = " + dr["Parola"].ToString());  // metin

                        smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                        smtpserver.Port = 587;
                        smtpserver.Host = smptsrvr;
                        smtpserver.EnableSsl = true;
                        mail.From = new MailAddress(mailadresin);
                        mail.To.Add(kime);
                        mail.Subject = konu;
                        mail.Body = yazi;
                        smtpserver.Send(mail);
                        MessageBox.Show("Log in to your account with the password that came to your mail.\n For your security Then please change your password.");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    parola_Verildimi = true;

                    if (parola_Verildimi)
                    {
                        this.Close();
                    }
                }
                if (parola_Verildimi==false)
                {
                    MessageBox.Show("Hatalı Bilgiler");
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                this.Close();
            }
        }

        private void maskedtxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGonder_Click(sender, e);
            }
        }

        private void ParolamiUnuttum_Load(object sender, EventArgs e)
        {
            maskedtxtTC.Text = "1";
            maskedtxtTC.Text = "";
            maskedtxtTC.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void ParolamiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.uyelerBaglantisi.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
