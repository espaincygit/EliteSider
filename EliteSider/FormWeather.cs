using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Xml;
using System.Net;
using System.IO;
using System.Threading;

namespace EliteSider
{
    public partial class FormWeather : Form
    {
        public FormWeather()
        {
            InitializeComponent();
            
        }

        private Point mouse_offset;
        private int WEATHER_SH = 1;
        private int WEATHER_OSAKA = 0;
        private int WEATHER_CURRENT = 0;
        private void panel_weather_MouseDown(object sender, MouseEventArgs e)
        {


            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void panel_weather_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                Point mousepos = Control.MousePosition;

                mousepos.Offset(mouse_offset.X, mouse_offset.Y);

                Location = mousepos;

            }
        }

        private void InitWeatherOsaka()
        {
            Debug.WriteLine("SetWeather");

            label3.Text = "大阪府 大阪市";

            string lwws = "http://weather.livedoor.com/forecast/webservice/rest/v1?city={0}&day=today";

            string lwwsUrl = String.Format(lwws, 81);//63 tokyo 81 osaka

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(lwwsUrl);
            }
            catch
            {
                clearWeather();
                return;
            }

            //Debug.WriteLine(doc.InnerXml);
            today_temp_max = doc.DocumentElement.SelectSingleNode("/lwws/temperature/max/celsius").InnerText;

            today_temp_min = doc.DocumentElement.SelectSingleNode("/lwws/temperature/min/celsius").InnerText;

            today_weather = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/telop").InnerText;
            today_week = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/day").InnerText;

            string today_imageUrl = doc.DocumentElement.SelectSingleNode
                               ("/lwws/image/url").InnerText;
            //today_image = makeIconFromLWWSGif(today_imageUrl);

            lwws = "http://weather.livedoor.com/forecast/webservice/rest/v1?city={0}&day=tomorrow";

            lwwsUrl = String.Format(lwws, 81);

            doc = new XmlDocument();
            try
            {
                doc.Load(lwwsUrl);
            }
            catch
            {
                return;
            }
            tomo_temp_max = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/temperature/max/celsius").InnerText;
            tomo_temp_min = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/temperature/min/celsius").InnerText;

            tomo_weather = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/telop").InnerText;
            tomo_week = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/day").InnerText;
            string tomo_imageUrl = doc.DocumentElement.SelectSingleNode
                               ("/lwws/image/url").InnerText;

            //tomo_image = makeIconFromLWWSGif(tomo_imageUrl);

            lwws = "http://weather.livedoor.com/forecast/webservice/rest/v1?city={0}&day=dayaftertomorrow";

            lwwsUrl = String.Format(lwws, 81);//63 tokyo 81 osaka

            doc = new XmlDocument();
            try
            {
                doc.Load(lwwsUrl);
            }
            catch
            {
                return;
            }

            //Debug.WriteLine(doc.InnerXml);
            houday_temp_max = doc.DocumentElement.SelectSingleNode("/lwws/temperature/max/celsius").InnerText;

            houday_temp_min = doc.DocumentElement.SelectSingleNode("/lwws/temperature/min/celsius").InnerText;

            houday_weather = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/telop").InnerText;
            houday_week = doc.DocumentElement.SelectSingleNode
                                          ("/lwws/day").InnerText;
            string houday_imageUrl = doc.DocumentElement.SelectSingleNode
                               ("/lwws/image/url").InnerText;

            setWeatherValue();
            //houday_image = makeIconFromLWWSGif(houday_imageUrl);

            //_publicTime = DateTime.Parse(pt);
            //Debug.WriteLine(today_weather);
            //panel_weather.Refresh();
        }

        string houday_temp_max = "";
        string houday_temp_min = "";
        string houday_weather = "";
        string houday_week = "";
        //Image houday_image = null;

        string today_temp_max = "";
        string today_temp_min = "";
        string today_weather = "";
        string today_week = "";
        //Image today_image = null;

        string tomo_temp_max = "";
        string tomo_temp_min = "";
        string tomo_weather = "";
        string tomo_week = "";
        //Image tomo_image = null;

        private void panel_weather_Paint(object sender, PaintEventArgs e)
        {
        }
        private void setWeatherValue()
        {
            Debug.WriteLine("panel_weather_Paint");
            if (today_week.Equals("")) return;

            //Graphics g = e.Graphics;

            //label1.Text=today_week.Substring(0, 3);//today_week

            label2.Text = today_weather;//today_week E
            string temp = "";
            if (!today_temp_min.Equals(""))
            {
                temp = today_temp_min + "C";//today_week

            }
            if (!today_temp_max.Equals(""))
            {
                if (temp.Equals(""))
                {
                    temp = today_temp_max + "C";
                }
                else
                {
                    temp = temp + "-" + today_temp_max + "C";
                }
                //today_week

            }
            label1.Text = temp;
            //g.DrawString("日本 大趤E, panel_weather.Font, pen, 80, 45);//today_week
            //panel_todayImage.BackgroundImage = today_image;
            //g.DrawImage(today_image, new Rectangle(150, 25, 25, 25));

            label4.Text=tomo_week;//today_week

            label5.Text=tomo_weather;//today_week

            label6.Text=tomo_temp_min + "'C" + "-" + tomo_temp_max + "'C";//today_week

            //panel_tomoImage.BackgroundImage = tomo_image;
            //g.DrawImage(tomo_image, new Rectangle(20, 100, 20, 20));

            label9.Text=houday_week;//today_week

            label8.Text=houday_weather;//today_week

            label7.Text = houday_temp_min + "'C" + "-" + houday_temp_max + "'C";//today_week
            //panel_houImage.BackgroundImage = houday_image;
            //g.DrawImage(houday_image, new Rectangle(150, 100, 20, 20));
        }

        private void FormWeather_Load(object sender, EventArgs e)
        {
            //InitWeatherOsaka();
            clearWeather();
            Thread importThread = new System.Threading.Thread(new ThreadStart(InitWeatherSH));
            importThread.Start();
            
        }

        Image makeIconFromLWWSGif(string url)
        { 
            Bitmap origBitmap;
 
            //Bitmap iconBitmap = new Bitmap(50, 50);
 
            using (WebClient wc = new WebClient())
            {
                Stream st;
                try
                {
                    st = wc.OpenRead(url);
                }
                catch
                {
                    return null;
                }
                origBitmap = (Bitmap)Bitmap.FromStream(st);
            } 
            /*
            Rectangle src = new Rectangle(
              10, 0, origBitmap.Width - 18, origBitmap.Height);
            int height = src.Height * 16 / src.Width;
            Rectangle dest = new Rectangle(0, (16 - height) / 2, 16, height);

            using (Graphics g = Graphics.FromImage(iconBitmap))
            {
                g.Clear(Color.White);
                g.DrawImage(origBitmap, dest, src, GraphicsUnit.Pixel);
                origBitmap.Dispose();
            }
 */
            //Icon icon = Icon.FromHandle(iconBitmap.GetHicon());

            //origBitmap.Dispose();
            //iconBitmap.Dispose();

            return origBitmap;
        } 

        private void label10_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void panel_weather_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Thread importThread = null;
            switch (WEATHER_CURRENT)
            {
                case 1 :
                    importThread = new System.Threading.Thread(new ThreadStart(InitWeatherSH));
                    importThread.Start();
                    //InitWeatherSH();
                    WEATHER_CURRENT = WEATHER_OSAKA;
                    break;
                case 0 :
                    importThread = new System.Threading.Thread(new ThreadStart(InitWeatherOsaka));
                    importThread.Start();
                    
                    WEATHER_CURRENT = WEATHER_SH;
                    break;
                default:
                    importThread = new System.Threading.Thread(new ThreadStart(InitWeatherSH));
                    importThread.Start();
                    //InitWeatherSH();
                    WEATHER_CURRENT = WEATHER_OSAKA;
                    break;
            }
 
            
        }
 
        private void InitWeatherSH()
        {
            try
            {
                WeatherWebService iws = new WeatherWebService();

                string citycode = iws.getSupportProvince()[0];
                string cityname = iws.getSupportCity(citycode)[1];
                //temp 5  12  17  next is overcase
                string[] weather = iws.getWeatherbyCityName(cityname.Substring(0, 2));

                label3.Text = "中国 上海市";

                label1.Text = weather[5].Replace(" ", "");

                label2.Text = weather[6].Substring(6).Replace(" ", "");

                //number of week
                label4.Text = "明天";// weather[13].Substring(0, 6);

                //description
                label5.Text = weather[13].Substring(6).Replace(" ","");

                //temp
                label6.Text = weather[12].Replace(" ", "");

                label9.Text = "后天";// weather[18].Substring(0, 6);

                label8.Text = weather[18].Substring(6).Replace(" ", "");

                label7.Text = weather[17].Replace(" ", "");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                clearWeather();
            }
        }

        private void clearWeather()
        {
            label1.Text = "";
            label2.Text = "";
            label4.Text = "明天";
            label6.Text = "";
            label9.Text = "后天";
            label7.Text = "";
            label3.Text = "中国 上海市";
            label5.Text = "";
            label8.Text = "";
        }

    }
}