using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Threading;

namespace EliteSider
{
    public partial class FormProgress : Form
    {
        private static Thread _splashLauncher;
        private static FormProgress _splashScreen;

        public FormProgress()
        {
            InitializeComponent();
        }
        public static void ShowSplash()
        {
            //Show the form in a new thread
            _splashLauncher = new Thread(new ThreadStart(LaunchSplash));
            _splashLauncher.IsBackground = true;
            _splashLauncher.Start();

        }

        private static void LaunchSplash()
        {
            _splashScreen = new FormProgress();

            //Create new message pump
            Application.Run(_splashScreen);
            for (int i = 0; i < 100; i++)
            {
                //_splashScreen.label1.Text = i;
                //_splashScreen.progressBar1.Value = ClockForm.PROGRESS_PCT;
            }
        }

        private static void CloseSplashDown()
        {
            Application.ExitThread();
        }

        public static void CloseSplash()
        {
            //Need to get the thread that launched the form, so
            //we need to use invoke.
            MethodInvoker mi = new MethodInvoker(CloseSplashDown);
            _splashScreen.Invoke(mi);
        }
  
    }
}