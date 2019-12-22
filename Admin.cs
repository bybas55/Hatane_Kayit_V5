using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HastaneKayit
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDoktorGiris giris = new AdminDoktorGiris();
            giris.Show();
            
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {

        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime dateSaat = DateTime.Now;
            label1.Text = dateSaat.ToLongTimeString();
            label2.Text = dateSaat.ToLongDateString();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
