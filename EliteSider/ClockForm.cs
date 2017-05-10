using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Drawing2D;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;  

namespace EliteSider
{
    public partial class ClockForm : Form
    {
        private CommonPerformanceCounter cpuPerfCounter = new CommonPerformanceCounter("Processor", "% Processor Time", "_Total", true);
        private DiskTimePerformanceCounter diskPerfCounter = new DiskTimePerformanceCounter();
        private WiFiPerformanceCounter networkPerfCounter = new WiFiPerformanceCounter();
        private MemoryPerformanceCounter mpf = new MemoryPerformanceCounter();
        private CPUPerformanceCounter cpuCounter = new CPUPerformanceCounter();

        PerfData cpuData = new PerfData();
        PerfData diskData = new PerfData();
        PerfData netData = new PerfData();
        PerfData memData = new PerfData();
        PerfData cpuInfo = new PerfData();

        FormProgress fp;
                //double curBatAvg = 0;
        //int curBatAvgCount = 0;
        //double prevBatAvg = 0;
        //double incBatAvg = 0;
        //double drawBatAvg = 0;

        public ClockForm()
        {
            InitializeComponent();
        } 

        private void ClockForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("ClockForm_Load");

            //Thread InstanceCaller = new Thread(new ThreadStart(SplashThreadFunc));
            //InstanceCaller.Start();
            fp = new FormProgress();
            fp.Show();
            fp.label2.Refresh(); 

            SplashThreadFunc("Initial basic setting", 0, fp);
            InitBasicSetting(); 

            //SideBar sidebar = new SideBar();

            //sidebar.Show();
            //sidebar.SendToBack();

            //this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);

            panel_clock_in_Height = panel_clock_in.Height;
            panel_clock_in_Width = panel_clock_in.Width;

            //SetBackGroundColor();
            SplashThreadFunc("Initial clock region", 10, fp);
            SetClockRegion();
 
            SplashThreadFunc("Initial clock background", 15, fp);
            //setClockbackground(3);

            setClockbackground(new Random().Next(8));

            SplashThreadFunc("Initial Timer", 20, fp);
            InitialTimer();
             
            //SetWeather();

            SplashThreadFunc("Initial Calendar", 30, fp);
            SetCalendarCube();
            
            //SetNewsLink();

            //refreshRssNews();

            //clockForm.Size = new Size(clockForm.Width, Screen.PrimaryScreen.Bounds.Height);

             
            counterPollTimer_Tick(null, null);
            //RenderSysMon();

            SplashThreadFunc("Initial Picture box", 40, fp);
            InitPictureBox();
              
             
        }

        private void SplashThreadFunc(string PROGRESS_MSG, int progress, FormProgress fp)
        {
             //fp = new FormProgress();
             //fp.Show();
             //fp.label2.Refresh();
             //for (int i = 0; i < 100; i++)
            //{
            fp.progressBar1.Value = progress;
                 fp.label1.Text = PROGRESS_MSG;
                 fp.label1.Refresh(); 
             //    i = PROGRESS_PCT;
             //}
             //fp.Close();
        }

        private static string GIF_PATH = Directory.GetCurrentDirectory() + "\\gif\\t.swf";

        private void InitPictureBox()
        {
            string picfile = EliteSider.Properties.Settings.Default.picfile;

            if (picfile != null && !picfile.Equals(""))
            {
                setPicToPB(picfile);
            }

            if (File.Exists(GIF_PATH))
            {
                webBrowser1.Url = new Uri(GIF_PATH);
            }
        }

        private void InitBasicSetting()
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            Size = new Size(Width, Screen.PrimaryScreen.Bounds.Height);
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, 0);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            string picfile = EliteSider.Properties.Settings.Default.picfile;
            if (picfile == null || ( picfile != null && picfile.Equals("")))
            {
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            }
            else
            {
                openFileDialog1.InitialDirectory = picfile.Substring(0, picfile.LastIndexOf(@"\"));
            }
        }

        private void InitSysMonPartly()
        {
            try
            {
                diskData.Draw = diskPerfCounter.NextValue();
                cpuInfo.Draw = cpuCounter.NextValue();

                cpuInfo.Current = cpuCounter.cpuSpeed;
            }
            catch (Exception sysExp)
            {
                Debug.WriteLine(sysExp.Message);
            }
        }

        private void CleanMemoryToSwap()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);

            }
        }

        [DllImport("kernel32.dll")]

        private static extern bool SetProcessWorkingSetSize(

            IntPtr process,
            int minSize,
            int maxSize);

        private void SetBackGroundColor()
        {
            Debug.WriteLine("SetBackGroundColor");
            //panel_calendar.BackColor = EliteSider.Properties.Settings.Default.BackgroundColor;
            //panel3.BackColor = EliteSider.Properties.Settings.Default.BackgroundColor;
            //panel_sysMon.BackColor = EliteSider.Properties.Settings.Default.BackgroundColor;
            groupBox1.BackColor = EliteSider.Properties.Settings.Default.BackgroundColor; 
            groupBox2.BackColor = EliteSider.Properties.Settings.Default.BackgroundColor;
            groupBox3.BackColor = EliteSider.Properties.Settings.Default.BackgroundColor;

            label17.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label_day.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;

           
            label10.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label11.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label4.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label12.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label_mem_n.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;

            //label1.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label9.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
            label13.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;

            groupBox3.ForeColor = EliteSider.Properties.Settings.Default.FrontColor;
        }
        private string currencyEur;
        private string currencyAud;
        private string currencyUsd;
        private string currencyJpy;
        private int currencyCount;

        private void SetCurrency()
        {
            Debug.WriteLine("SetCurrency");
            try
            {
                // Create the web request   
                HttpWebRequest request
                    = WebRequest.Create("http://www.boc.cn/sourcedb/whpj/") as HttpWebRequest;
                string result = "";

                // Get response   
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    // Load data into a dataset   
                    DataSet dsWeather = new DataSet();

                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  get cash buy rate 
                    result = reader.ReadToEnd();
                   // currencyJpy = result.Substring(result.IndexOf("日元") + 2);
                     


                    currencyJpy = "JPY " + getCurrencyFromBOC("日元", result);

                    currencyUsd = "USD " + getCurrencyFromBOC("美元", result);
                    currencyAud = "AUD " + getCurrencyFromBOC("澳大利亚元", result);
                    currencyEur = "EUR " + getCurrencyFromBOC("欧元", result);
                    //currencyJpy = "JPY " + result.Substring(result.IndexOf("日元") + 228, 6);


                   // currencyUsd = "USD " + result.Substring(result.IndexOf("美元") + 228, 6);
                   // currencyAud = "AUD " + result.Substring(result.IndexOf("澳大利亚元") + 231, 6);
                   // currencyEur = "EUR " + result.Substring(result.IndexOf("欧元") + 228, 6);
                    // UPPER location
                    label9.Text = currencyUsd;

                    label13.Text = currencyJpy;
                    Debug.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" + result);

                }
            }
            catch (Exception fxerror)
            {
                Debug.WriteLine(fxerror.Message);
                label9.Text = "";
                label13.Text = "";
                return;
            }
        }

        private string getCurrencyFromBOC(string curName, string result)
        {
            string currencyJpy = result.Substring(result.IndexOf(curName) + curName.Length);

            currencyJpy = currencyJpy.Substring(currencyJpy.IndexOf(">") + 1);
            currencyJpy = currencyJpy.Substring(currencyJpy.IndexOf(">") + 1);
            currencyJpy = currencyJpy.Substring(currencyJpy.IndexOf(">") + 1);
            currencyJpy = currencyJpy.Substring(currencyJpy.IndexOf(">") + 1);

            currencyJpy = currencyJpy.Substring(0, currencyJpy.IndexOf("<"));
            return currencyJpy;
        }
         

        private void SetCurrency_old()
        {
            Debug.WriteLine("SetCurrency");
            try
            {
                FXWSService fxService = new FXWSService();

                string usd = fxService.getLatestNoonRate("CNY");

                string yen = fxService.getLatestNoonRate("JPY");

                string tag = "frbny:OBS_VALUE";

                usd = usd.Substring(usd.IndexOf(tag) + tag.Length + 1);

                usd = usd.Substring(0, usd.IndexOf(tag) - 2);

                yen = yen.Substring(yen.IndexOf(tag) + tag.Length + 1);

                yen = yen.Substring(0, yen.IndexOf(tag) - 2);

                double usdd = double.Parse(usd) * 100;

                label9.Text = "CNY " + usdd.ToString();

                usdd = double.Parse(usd) / double.Parse(yen) * 100;

                label13.Text = "JPY " + usdd.ToString().Substring(0, 6);

            }
            catch (Exception fxerror)
            {
                Debug.WriteLine(fxerror.Message);
                label9.Text = "";
                label13.Text = "";
                return;
            }
        }


        private System.Timers.Timer timer3_Current;
        //initial timer at start up
        private void InitialTimer()
        {

            Debug.WriteLine("InitialTimer");
            timer3_Current = new System.Timers.Timer();
            timer3_Current.Elapsed += new ElapsedEventHandler(ShowCurrentTimer);

            timer3_Current.Interval = 1000;
            timer3_Current.Enabled = true;

        }

        //Year Month Day and Time
        private void ShowCurrentTimer(Object source, ElapsedEventArgs e)
        {

            Debug.WriteLine("ShowCurrentTimer");

            //this.label18.Text = currentDate.ToShortTimeString();
            panel_clock_in.Refresh();
            //panel_sysMon.Refresh();


            //Refresh();
        }

        private void SetCalendarCube()
        {

            DateTime currentDate = DateTime.Now;
            this.label17.Text = currentDate.Year + " " + currentDate.Month + "";
            label_day.Text = currentDate.Day.ToString();
            label_week.Text = currentDate.DayOfWeek.ToString();
        }

        private void SetClockRegion()
        {
            Debug.WriteLine("SetClockRegion");
            //setClockbackground(0);
            GraphicsPath myGraphicsPath = new GraphicsPath();
            int radius = panel_clock_in.Height;// 200; 
            int xy = 7;
            int jianxi = 0;

            //clock
            myGraphicsPath.AddEllipse(new Rectangle(0, 0, radius, radius));
            //1
            panel_clock_in.Region = new Region( myGraphicsPath);

            myGraphicsPath = new GraphicsPath();

            myGraphicsPath.AddRectangle(new Rectangle(0, 0, panel_lv.Width, panel_lv.Height));
            //2
            panel_lv.Region = new Region(myGraphicsPath);

            myGraphicsPath = new GraphicsPath();

            //world time
            jianxi = 30 + radius;
            myGraphicsPath.AddRectangle(new Rectangle(0, xy, groupBox1.Width, groupBox1.Height - xy));
            //3
            groupBox1.Region = new Region(myGraphicsPath);

            myGraphicsPath = new GraphicsPath();
            //sys monintor
            //jianxi += panel_calendar.Height + 20;
            myGraphicsPath.AddRectangle(new Rectangle(0, xy, groupBox2.Width, groupBox2.Height - xy));
            //4
            groupBox2.Region = new Region(myGraphicsPath);

            myGraphicsPath = new GraphicsPath();
            //exchange currency 
            //jianxi += panel_sysMon.Height + 11;
            myGraphicsPath.AddRectangle(new Rectangle(0, xy, groupBox3.Width, groupBox3.Height - xy));
            //5
            groupBox3.Region = new Region(myGraphicsPath);
            
            panel2.Height = Screen.PrimaryScreen.Bounds.Height;

            myGraphicsPath = new GraphicsPath();
            myGraphicsPath.AddRectangle(new Rectangle(10, 15, webBrowser1.Width - 18, webBrowser1.Height - 26));
            webBrowser1.Region = new Region(myGraphicsPath);

            //weather
            //jianxi += panel3.Height + 17;
            //myGraphicsPath.AddRectangle(new Rectangle(panel_weather.Left, panel_weather.Top, panel_weather.Width, panel_weather.Height));
            //myGraphicsPath.AddRectangle(new Rectangle(button_weather.Left, button_weather.Top, button_weather.Width, button_weather.Height));
            
            //myGraphicsPath.AddRectangle(new Rectangle(button_calendar.Left, button_calendar.Top, button_calendar.Width, button_calendar.Height));
            
            //myGraphicsPath.AddRectangle(new Rectangle(button_news.Left, button_news.Top, button_news.Width, button_news.Height));

            //myGraphicsPath.AddRectangle(new Rectangle(buttonRadio.Left, buttonRadio.Top, buttonRadio.Width, buttonRadio.Height));
           
            //myGraphicsPath.AddRectangle(new Rectangle(button_min.Left, button_min.Top, button_min.Width, button_min.Height));
            
            //myGraphicsPath.AddRectangle(new Rectangle(button_close.Left, button_close.Top, button_close.Width, button_close.Height));

            //myGraphicsPath.AddRectangle(new Rectangle(button1.Left, button1.Top, button1.Width, button1.Height));
             
            //this.Region = new Region(myGraphicsPath);
 
        }

        private void panel_clock_in_Paint(object sender, PaintEventArgs e)
        {

            RepaintClock(e.Graphics);
            
        }

        int panel_clock_in_Width;
        int panel_clock_in_Height;

        private Color hourColor = Color.DarkGray;//.Red;
        private Color minuteColor = Color.DarkGray;
        private Color secondColor = Color.Red;//.Red;

        private void RepaintClock(Graphics g)
        {
            Debug.WriteLine("RepaintClock(Graphics g)");
            //if (g == null) return;
            //Graphics g = panel_clock_in.CreateGraphics();
            //panel_clock_in.SuspendLayout();217
            g.DrawImage(clockBitMap, 0, 0, panel_clock_in_Width, panel_clock_in_Height);

            //base.OnPaint(e);
            //Smooths out the appearance of the control
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //The center of the control, that is used as center for the clock
            int Width = panel_clock_in.Width;
            int Height = panel_clock_in.Height;
            int Font_Height = 40;
            PointF center = new PointF(Width / 2, Height / 2);
            //The distace of the text from the center   
            //float textRadius = (Math.Min(Width, Height) - Font_Height) / 2;//Font.Height
            //The distance of the margin points from the center
            float outerRadius = Math.Min(Width, Height) / 2 - Font_Height;
            //The length of the hour line
            float hourRadius = outerRadius * 1.2f;
            //The length of the minute line
            float minuteRadius = outerRadius * 1.6f;
            //The length of the second line
            float secondRadius = outerRadius * 2.1f;
            
            //Gets the system time
            DateTime dt = DateTime.Now;
            //Calculates the hour offset from the large outer dot
            float min = ((float)dt.Minute) / 60;
            //Calculates the angle of the hour line
            float hourAngle = GetAngle(dt.Hour + min, 12);
            //Calculates the angle of the minute line
            float minuteAngle = GetAngle(dt.Minute, 60);
            //Calculates the angle of the second line
            float secondAngle = GetAngle(dt.Second, 60);
            //Draws the clock lines
            //DrawOffScreen();
            DrawLine(g, this.hourColor, 3, center, hourRadius, hourAngle);

            DrawLine(g, this.minuteColor, 2, center, minuteRadius, minuteAngle);

            DrawLine(g, this.secondColor, 1, center, secondRadius, secondAngle);
        }

        private Bitmap clockBitMap;
        private void setClockbackground(int num)
        {
            Debug.WriteLine("setClockbackground");
            switch (num)
            {
                case 0:
                    clockBitMap = global::EliteSider.Properties.Resources.playboy;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;

                case 1:
                    clockBitMap = global::EliteSider.Properties.Resources.omega;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;
                case 2:
                    clockBitMap = global::EliteSider.Properties.Resources._1;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;
                case 3:
                    clockBitMap = global::EliteSider.Properties.Resources._2;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;
                case 4:
                    clockBitMap = global::EliteSider.Properties.Resources._3;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;
                case 5:
                    clockBitMap = global::EliteSider.Properties.Resources.ross;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;
                case 6:
                    clockBitMap = global::EliteSider.Properties.Resources.dimand;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;


                default:
                    clockBitMap = global::EliteSider.Properties.Resources.fourseason;
                    this.panel_clock_in.BackgroundImage = (Image)clockBitMap.Clone();
                    break;
            }
        }

        private PointF GetPoint(PointF center, float radius, float angle)
        {
            //Calculates the X coordinate of the point
            float x = (float)Math.Cos(2 * Math.PI * angle / 360) * radius + center.X;
            //Calculates the Y coordinate of the point
            float y = -(float)Math.Sin(2 * Math.PI * angle / 360) * radius + center.Y;
            return new PointF(x, y);
        }

        private void DrawLine(Graphics g, Color color, int penWidth, PointF center, float radius, float angle)
        {
            penWidth = penWidth + 2;
            //Calculates the end point of the line
            PointF endPoint = GetPoint(center, radius, angle);
            //Creates the pen used to render the line
            Pen pen = new Pen(new SolidBrush(color), penWidth);
            //Renders the line
            g.DrawLine(pen, center, endPoint);
            pen.Dispose();
        }
        private float GetAngle(float clockValue, float divisions)
        {
            //Calculates the angle
            return 360 - (360 * (clockValue) / divisions) + 90;
        }

        private void panel_clock_in_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("panel_clock_in_MouseDoubleClick");

            setClockbackground(new Random().Next(8));
        }

        private void ClockForm_VisibleChanged(object sender, EventArgs e)
        {
            if (timer3_Current != null)
            {
                timer3_Current.Interval = Visible ? 1000 : 5000;
                counterPollTimer.Interval = Visible ? 3000 : 5000;
            }
        }
        /*
        private void Render(Graphics g, int x, int y)
        {
            Debug.WriteLine("Render(Graphics g, int x, int y)");
            g.Clear(Color.Black);
            float cpuLen = (float)(cpuData.Draw / cpuData.Max / 2.7 * x);
            g.FillRectangle(Brushes.Green, 0, 0, cpuLen, y);
            float diskLen = (float)(diskData.Draw / diskData.Max / 2.7 * x);
            g.FillRectangle(Brushes.Yellow, cpuLen, 0, diskLen, y);
            float netLen = (float)(netData.Draw / netData.Max / 2.7 * x);
            g.FillRectangle(Brushes.Red, cpuLen + diskLen, 0, netLen, y);
           
        }
        */

        private void RenderSysMon()
        {
            Debug.WriteLine("RenderSysMon");
            
            int x = this.label_cpu.Width;
            int y = label_cpu.Height;

            int cpuLen = (int)(cpuData.Draw / cpuData.Max / 2.7 * x);
            label_cpu_v.Width = cpuLen > label_cpu.Width ? label_cpu.Width : cpuLen;
            //label_cpu.Refresh();

            label12.Text = "CPU " + cpuLen + "%";

            //int diskLen = (int)(diskData.Draw / diskData.Max / 2.7 * x);
            //label_disk_v.Width = diskLen;
            label11.Text = "CPU " + (long)cpuInfo.Current + "Mhz/" + (int)cpuInfo.Draw + "'C";

            int netLen = (int)(netData.Draw / 200 * x);
            //label_net_v.Width = netLen > x ? x : netLen;
            label10.Text = "HDD " + diskData.Draw + "'C";
            //label10.Text = "LAN " + (int)netData.Draw + "KB";

            int memLen = (int)((mpf.totalPhysicalMemory - memData.Draw) / mpf.totalPhysicalMemory * x);
            //int tempMenLen = new Random().Next(label_cpu.Width - label_cpu_v.Width);
            //int tempMenLen = new Random().Next(x);
            //this.label_mem_v.Width = tempMenLen == label_cpu_v.Width ? new Random().Next(x) : tempMenLen;
            //this.label_mem_v.Width = label_cpu.Width - tempMenLen;//memLen;
            this.label_mem_v.Width = memLen;

            //Debug.WriteLine("RenderSysMon  label_cpu_v.Width  " + label_cpu_v.Width);
            //Debug.WriteLine("RenderSysMon  label_mem_v.Width  " + label_mem_v.Width);

            label_cpu.Refresh();
            label7.Refresh();
            //this.label_mem_v.Width = new Random().Next(x);

            label_mem_n.Text = "RAM " + (int)((mpf.totalPhysicalMemory - memData.Draw) / mpf.totalPhysicalMemory * 100) + "%";
            //label_mem_n.Text = "RAM " + memData.Draw + "MB";

            label4.Text = "Free:" + memData.Draw + "MB";
            label_lan.Text = "LAN " + (int)netData.Draw + "KB";
        }
        /*
        private void UpdatePerfData(PerfData perfData, CommonPerformanceCounter perfCounter)
        {
            perfData.Current = perfCounter.NextValue();
            perfData.Current = (perfData.Current > perfData.Max) ?
                perfData.Max : perfData.Current;
            perfData.Increment = (perfData.Current - perfData.Previous) / (counterPollTimer.Interval / 1000);
            perfData.Draw = perfData.Previous;
            perfData.Previous = perfData.Current;
        }*/
        private void counterPollTimer_Tick(object sender, EventArgs e)
        {

            //UpdatePerfData(cpuData, cpuPerfCounter);
            //UpdatePerfData(diskData, diskPerfCounter);
            //UpdatePerfData(netData, networkPerfCounter);
            //UpdatePerfData(memData, mpf);
            Thread SysInfThread = new System.Threading.Thread(new ThreadStart(SysInfProc));
            SysInfThread.Start();
        
            
            //groupBox2.Refresh();
        }

        private void SysInfProc()
        {
            cpuData.Draw = cpuPerfCounter.NextValue();
            netData.Draw = networkPerfCounter.NextValue();
            memData.Draw = mpf.NextValue();

            cpuInfo.Draw = cpuCounter.NextValue();
            diskData.Draw = diskPerfCounter.NextValue();

            cpuInfo.Current = cpuCounter.cpuSpeed;
            if (currencyCount == 0)
            {
                label9.Text = currencyAud;

                label13.Text = currencyEur;
                currencyCount = 1;
            }
            else if (currencyCount == 1)
            {
                label9.Text = currencyUsd;

                label13.Text = currencyJpy;
                currencyCount = 0;

            }

        }

        private void ClockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EliteSider.Properties.Settings.Default.Save();
            timer3_Current.Enabled = false;
            timer3_Current = null;
        }
 
        private void button_weather_Click(object sender, EventArgs e)
        {
            FormWeather formWeather = new FormWeather();

            formWeather.Show();

        }

        private void button_calendar_Click(object sender, EventArgs e)
        {

            FormCalendar formCalendar = new FormCalendar();

            formCalendar.Show();
        }

        private void button_news_Click(object sender, EventArgs e)
        {

            FormNews formNews = new FormNews();

            formNews.Show();
        }

        private void button_weather_MouseHover(object sender, EventArgs e)
        {
            button_weather.ForeColor = Color.White; 
        }

        private void button_calendar_MouseHover(object sender, EventArgs e)
        {
            button_calendar.ForeColor = Color.White;
        }

        private void button_news_MouseHover(object sender, EventArgs e)
        {
            button_news.ForeColor = Color.White;
        }

        private void button_weather_MouseLeave(object sender, EventArgs e)
        {
            button_weather.ForeColor = Color.Aqua;
        }

        private void button_calendar_MouseLeave(object sender, EventArgs e)
        {
            button_calendar.ForeColor = Color.Aqua;
        }

        private void button_news_MouseLeave(object sender, EventArgs e)
        {
            button_news.ForeColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormRadio formRadio = new FormRadio();

            formRadio.Show();
        }

        private void buttonRadio_MouseHover(object sender, EventArgs e)
        {
            buttonRadio.ForeColor = Color.White;

        }

        private void buttonRadio_MouseLeave(object sender, EventArgs e)
        {
            buttonRadio.ForeColor = Color.Aqua;

        }

        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TopMost)
            {
                this.TopMost = false; 
            }
            else
            {
                this.TopMost = true;              
            }
        }

        private void ClockForm_Paint(object sender, PaintEventArgs e)
        {
            //fillBackColor(e.Graphics);

        }

        //private bool isCurved = true;
        private int backPattern = 0;

        private void ClockForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //backPattern = backPattern == 0 ? 1 : 0;
            //Refresh();
        }

        private void fillBackColor(Graphics graphics)
        {
            Color skinColor = this.BackColor;
            int offset = 20;// 20;
            int offset2 = 30;// 30;
            int r = skinColor.R + offset;
            int g = skinColor.G + offset;
            int b = skinColor.B + offset;
            LinearGradientBrush linearBrush =
                new LinearGradientBrush(new Rectangle(0, 0, Width, Height),
                    Color.FromArgb(r, g, b),
                    Color.FromArgb(skinColor.R - offset2, skinColor.G - offset2, skinColor.B - offset2),
                    0.0f);

            GraphicsPath myGraphicsPath = new GraphicsPath();
            switch (backPattern)
            {
                case 0 :

                    //float curve = 65;

                    int radius = panel_clock_in.Height;// 200;  

                    //myGraphicsPath.AddArc(new Rectangle(panel_clock_in.Left, panel_clock_in.Top, radius, radius), 240, -87);

                    myGraphicsPath.AddArc(new RectangleF(-100, 0, 120, 730), -75, 75);
                    PointF[] points = new PointF[2];

                    myGraphicsPath.AddArc(new RectangleF(-100, Height - 730, 120, 730), 0, 75);

                    points = new PointF[4];
                    points[0] = new PointF(0, Height);
                    points[1] = new PointF(Width, Height);
                    points[2] = new PointF(Width, 0);
                    points[3] = new PointF(0, 0);
                    myGraphicsPath.AddLines(points);
                    break;
                case 1:
                    myGraphicsPath.AddRectangle(new RectangleF(0, 0, Width, Height));
                    break;
                default:
                    this.BackColor = Color.Red;
                    myGraphicsPath.AddRectangle(new RectangleF(0, 0, Width, Height));
                    graphics.FillRectangle(linearBrush, new RectangleF(0, 0, 4, Height));

                    break;
            } 
            this.Region = new Region(myGraphicsPath);
            // Draw Inner Rim to screen.

            graphics.FillPath(linearBrush, myGraphicsPath);
            linearBrush.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((openFileDialog1.OpenFile()) != null)
                {
                    string picfile = openFileDialog1.FileNames[0];
                    EliteSider.Properties.Settings.Default.picfile = picfile;

                    setPicToPB(picfile);

                }
            } 
        }

        private void setPicToPB(string picfile)
        {
            if (File.Exists(picfile))
            {
                using (Stream s = new FileStream(picfile, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.BackgroundImage = Image.FromStream(s); ;

                    s.Close();
                }
            }
        } 
 
        private void label12_Paint(object sender, PaintEventArgs e)
        {
            RenderSysMon();

        }

        private void timerSysInfo_Tick(object sender, EventArgs e)
        {
            label12.Refresh(); 

        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            SetCurrency();
        }

        private void timerLazyLoad_Tick(object sender, EventArgs e)
        {
            timerLazyLoad.Stop();
            SplashThreadFunc("Initial Currency", 60, fp);
            SetCurrency();

            SplashThreadFunc("Initial System Monitor", 80, fp);
            InitSysMonPartly();
            SplashThreadFunc("Initial Memory clean", 100, fp);
            CleanMemoryToSwap();
            fp.Close();

        } 


    }
}