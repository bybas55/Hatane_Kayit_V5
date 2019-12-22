using System;
using System.Collections.Generic;
using System.Linq;//www.gorselprogramlama.com
using System.Windows.Forms;

namespace HastaneKayit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());//www.gorselprogramlama.com
        }
    }
}
