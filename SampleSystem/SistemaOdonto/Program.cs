﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleSystem
{
    static class Program
    {
        /// <summary>
        /// System Samples.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmSplashScreen frm = new frmSplashScreen();
            frm.ShowDialog();

            Application.Run(new frmMain());
        }
    }
}
