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
    public partial class AdminDoktorGiris : Form
    {

        public AdminDoktorGiris()
        {
            InitializeComponent();
        }

        string AdminSifre = "ismail";

        private void AdminDoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (lblKimGirecek.Text == "ADMİN")
            {
                if (txtParola.Text != AdminSifre)
                {
                    MessageBox.Show("Hatalı Parola");
                }
                else
                {
                    Admin adm = new Admin();
                    adm.Show();
                    this.Hide();
                }
            }
            
        }
    }
}
