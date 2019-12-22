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
    public partial class DoktorBilgileri : Form
    {
        public DoktorBilgileri()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();

        private void DoktorBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Doktorlar where DoktorAdiSoyadi='"+txtAdSoyad.Text+"'",frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtParola.Text = rd["Sifre"].ToString();
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
        }
    }
}
