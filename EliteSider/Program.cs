using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EliteSider
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // FormProgress.ShowSplash();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClockForm());
        }
    }
}