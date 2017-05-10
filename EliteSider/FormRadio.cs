using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace EliteSider
{
    public partial class FormRadio : Form
    {
        public FormRadio()
        {
            InitializeComponent();
        }
        private static string RadioAdd_BBC_Radio1 = "http://www.bbc.co.uk/radio/aod/radio1.shtml";
        private static string RadioAdd_BBC_Radio2 = "http://www.bbc.co.uk/radio/aod/radio2.shtml";
        
        private static string RadioAdd_BBC_Radio7 = "http://www.bbc.co.uk/radio/aod/bbc7.shtml";
        private void comboBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenWebPage();
            }
        }

        private void OpenWebPage()
        {

            if (!this.comboBox4.Text.Equals(""))
            {
                try
                {
                    if (!this.comboBox4.Text.StartsWith("http://"))
                    {
                        this.webBrowser1.Navigate(new Uri("http://" + this.comboBox4.Text));

                    }
                    else
                    {
                        this.webBrowser1.Navigate(new Uri(this.comboBox4.Text));
                    }
                }
                catch (System.UriFormatException)
                {
                    return;
                }

            }

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            foreach (string link in this.comboBox4.Items)
            {
                if (this.webBrowser1.Url.ToString().Equals(link))
                {
                    return;

                }
            }
            this.comboBox4.Items.Add(this.webBrowser1.Url.ToString());
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {

            this.comboBox4.Text = "";
        }

        private void FormRadio_Load(object sender, EventArgs e)
        { 
            StringCollection WebPageLink = Properties.Settings.Default.WebPageLink;

            foreach (string add in WebPageLink)
            {
                this.comboBox4.Items.Add(add);
            }
            //this.webBrowser1.Navigate(@"E:\Pic4U\gif\t.html");
        }

        private void FormRadio_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.WebPageLink.Clear();

            foreach (string weblink in this.comboBox4.Items)
            {
                Properties.Settings.Default.WebPageLink.Add(weblink);
            }

            Properties.Settings.Default.Save();
        }

        private Point mouse_offset;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                Point mousepos = Control.MousePosition;

                mousepos.Offset(mouse_offset.X, mouse_offset.Y);

                Location = mousepos;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenWebPage();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(new Uri(RadioAdd_BBC_Radio1));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(new Uri(RadioAdd_BBC_Radio2));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(new Uri(RadioAdd_BBC_Radio7));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}