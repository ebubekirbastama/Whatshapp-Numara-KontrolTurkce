using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Paylaşım_Botu_Tarayıcı_Entegre
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Class1.dgr.Trim() == Class1.MaxValue)
            {
                Application.Exit();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaSayfa());
        }
    }
}
