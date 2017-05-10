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
    public partial class SideBar : Form
    {
        public SideBar()
        {
            InitializeComponent();
            
        }

        private void SideBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.SendToBack();
        }
        private bool isCurved = false;
        private void SideBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isCurved = isCurved ? false : true;
            Refresh();
        }
 
        

        private void SideBar_Load(object sender, EventArgs e)
        {
             
            Size = new Size(Width, Screen.PrimaryScreen.Bounds.Height);
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, 0);
            SideBar_MouseDoubleClick(null, null);
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

            fillBackColor(e.Graphics);
        }

        private void fillBackColor(Graphics graphics)
        {
            Color skinColor = this.BackColor;
            LinearGradientBrush linearBrush =
                new LinearGradientBrush(new Rectangle(0, 0, Width, Height),
                    Color.FromArgb(100, 100, 100),
                    Color.FromArgb(skinColor.R, skinColor.G, skinColor.B),
                    0.0f);
            GraphicsPath myGraphicsPath = new GraphicsPath();
            if (isCurved)
            {
                float curve = 63;
                myGraphicsPath.AddArc(new RectangleF(0, 0, 200, Height), 255, -150);
                PointF[] points = new PointF[4];
                points[0] = new PointF(curve, Height);
                points[1] = new PointF(Width, Height);
                points[2] = new PointF(Width, 0);
                points[3] = new PointF(curve, 0);
                myGraphicsPath.AddLines(points);
 
            }
            else
            { 
                myGraphicsPath.AddRectangle(new RectangleF(0, 0, Width, Height));
            }
            this.Region = new Region(myGraphicsPath);
            // Draw Inner Rim to screen.
            
            graphics.FillPath(linearBrush, myGraphicsPath);
        }
    }
}