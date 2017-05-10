using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EliteSider
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
           
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

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            Size = new Size(panel1.Width + monthCalendar1.Width, panel1.Height);

            //GraphicsPath myGraphicsPath = new GraphicsPath();

            //myGraphicsPath.AddRectangle(new Rectangle(button1.Left + 0, button1.Top + 0, button1.Width - 1, button1.Height - 1));

            //this.button1.Region   = new Region(myGraphicsPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}