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
    public partial class Doktor : Form
    {
        string KullaniciAdi = "";
        string Sifre = "";
        public Doktor()
        {
            InitializeComponent();
        }
        public Doktor(string Kadi,string sifre)
        {
            InitializeComponent();
            KullaniciAdi = Kadi;
            Sifre = sifre;
        }

        Form1 frm1 = new Form1();

        private void Doktor_Load(object sender, EventArgs e)
        {
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Doktorlar where KullaniciAdi='"+KullaniciAdi+"'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lblDoktorAdi.Text = rd["DoktorAdiSoyadi"].ToString();
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            RandevulariGetir();
        }

        DateTime date = DateTime.Now;
        void renklendir()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].BackColor = Color.White;
            }

            string bugun = date.ToShortDateString();
            string saatSimdi = date.ToShortTimeString();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (string.Compare(bugun, listView1.Items[i].SubItems[1].Text) == 0)
                {
                    if (string.Compare(saatSimdi, listView1.Items[i].SubItems[2].Text) == 1 || string.Compare(saatSimdi, listView1.Items[i].SubItems[2].Text) == 0)
                    {
                        listView1.Items[i].BackColor = Color.Red;
                    }
                }

                if (string.Compare(bugun, listView1.Items[i].SubItems[1].Text) == 1)
                {
                    listView1.Items[i].BackColor = Color.Red;
                }
            }



            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].BackColor != Color.Red)
                {
                    listView1.Items[i].BackColor = Color.LawnGreen;
                }
            }
        }
        void RandevulariGetir()
        {
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Randevular where DoktorAdi='" + lblDoktorAdi.Text + "' order by Randevuid desc ", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                int i = 0;
                while (rd.Read())
                {
                    listView1.Items.Add(rd["Tc"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Tarih"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Saat"].ToString());
                    i++;
                }
                frm1.uyelerBaglantisi.Close();
                renklendir();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
        }


        private void Doktor_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Form1 frm1 = new Form1();
            frm1.Show(); this.Hide();
        }        

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime dateSaat = DateTime.Now;
            lblSaat.Text = dateSaat.ToLongTimeString();
            lblTarih.Text = dateSaat.ToLongDateString();
        }        

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
