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
    public partial class AlinanRandevular : Form
    {
        string tcNo = "";

        public AlinanRandevular()
        {
            InitializeComponent();
        }
        public AlinanRandevular(string tc)
        {
            InitializeComponent();
            tcNo = tc;
        }

        Form1 frm1 = new Form1();
        DateTime date = DateTime.Now;

        private void AlinanRandevular_Load(object sender, EventArgs e)
        {
            listviewGuncelle();
        }


        void listviewGuncelle()
        {
            listView1.Items.Clear();
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Randevular where Tc='"+tcNo+"' order by Randevuid desc ", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                int no = 0;
                while (rd.Read())
                {
                    no++;
                    listView1.Items.Add(no.ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["KlinikAdi"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["DoktorAdi"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Tarih"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Saat"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Randevuid"].ToString());
                }
                frm1.uyelerBaglantisi.Close();
                renklendir();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

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
                if (string.Compare(bugun, listView1.Items[i].SubItems[3].Text) == 0)
                {
                    if (string.Compare(saatSimdi, listView1.Items[i].SubItems[4].Text) == 1 || string.Compare(saatSimdi, listView1.Items[i].SubItems[4].Text) == 0)
                    {
                        listView1.Items[i].BackColor = Color.Red;
                    }
                }

                if (string.Compare(bugun, listView1.Items[i].SubItems[3].Text) == 1)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] idler = new string[listView1.CheckedItems.Count];

            for (int i = 0; i < listView1.CheckedItems.Count; i++)
            {
                idler[i] = listView1.CheckedItems[i].Text;
                try
                {
                    frm1.uyelerBaglantisi.Open();
                    OleDbCommand cmd = new OleDbCommand("Delete * From Randevular where Randevuid=@id", frm1.uyelerBaglantisi);
                    cmd.Parameters.AddWithValue("@id", listView1.CheckedItems[i].SubItems[5].Text);
                    cmd.ExecuteNonQuery();
                    frm1.uyelerBaglantisi.Close();
                    
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                
            }
            listviewGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
