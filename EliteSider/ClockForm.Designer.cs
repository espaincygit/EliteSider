namespace EliteSider
{
    partial class ClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.counterPollTimer = new System.Windows.Forms.Timer(this.components);
            this.button_weather = new System.Windows.Forms.Button();
            this.button_calendar = new System.Windows.Forms.Button();
            this.button_news = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_lan = new System.Windows.Forms.Label();
            this.label_mem_v = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_mem_n = new System.Windows.Forms.Label();
            this.label_cpu_v = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_cpu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_week = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel_clock_in = new System.Windows.Forms.Panel();
            this.panel_lv = new System.Windows.Forms.Panel();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerSysInfo = new System.Windows.Forms.Timer(this.components);
            this.timerLazyLoad = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_lv.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterPollTimer
            // 
            this.counterPollTimer.Enabled = true;
            this.counterPollTimer.Interval = 10000;
            this.counterPollTimer.Tick += new System.EventHandler(this.counterPollTimer_Tick);
            // 
            // button_weather
            // 
            this.button_weather.BackColor = System.Drawing.Color.Black;
            this.button_weather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_weather.ForeColor = System.Drawing.Color.Aqua;
            this.button_weather.Location = new System.Drawing.Point(89, 581);
            this.button_weather.Name = "button_weather";
            this.button_weather.Size = new System.Drawing.Size(64, 23);
            this.button_weather.TabIndex = 44;
            this.button_weather.Text = "Weather";
            this.button_weather.UseVisualStyleBackColor = false;
            this.button_weather.MouseLeave += new System.EventHandler(this.button_weather_MouseLeave);
            this.button_weather.Click += new System.EventHandler(this.button_weather_Click);
            this.button_weather.MouseHover += new System.EventHandler(this.button_weather_MouseHover);
            // 
            // button_calendar
            // 
            this.button_calendar.BackColor = System.Drawing.Color.Black;
            this.button_calendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_calendar.ForeColor = System.Drawing.Color.Aqua;
            this.button_calendar.Location = new System.Drawing.Point(89, 610);
            this.button_calendar.Name = "button_calendar";
            this.button_calendar.Size = new System.Drawing.Size(64, 23);
            this.button_calendar.TabIndex = 45;
            this.button_calendar.Text = "Calendar";
            this.button_calendar.UseVisualStyleBackColor = false;
            this.button_calendar.MouseLeave += new System.EventHandler(this.button_calendar_MouseLeave);
            this.button_calendar.Click += new System.EventHandler(this.button_calendar_Click);
            this.button_calendar.MouseHover += new System.EventHandler(this.button_calendar_MouseHover);
            // 
            // button_news
            // 
            this.button_news.BackColor = System.Drawing.Color.Black;
            this.button_news.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_news.ForeColor = System.Drawing.Color.Aqua;
            this.button_news.Location = new System.Drawing.Point(24, 581);
            this.button_news.Name = "button_news";
            this.button_news.Size = new System.Drawing.Size(62, 23);
            this.button_news.TabIndex = 46;
            this.button_news.Text = "News";
            this.button_news.UseVisualStyleBackColor = false;
            this.button_news.MouseLeave += new System.EventHandler(this.button_news_MouseLeave);
            this.button_news.Click += new System.EventHandler(this.button_news_Click);
            this.button_news.MouseHover += new System.EventHandler(this.button_news_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::EliteSider.Properties.Resources.lv;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 26);
            this.panel1.TabIndex = 47;
            this.panel1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.BackgroundImage = global::EliteSider.Properties.Resources.currencyback;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(53, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 49);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(11, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "JPY";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "USD";
            this.label9.DoubleClick += new System.EventHandler(this.label9_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.BackgroundImage = global::EliteSider.Properties.Resources.sysMon;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label_lan);
            this.groupBox2.Controls.Add(this.label_mem_v);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_mem_n);
            this.groupBox2.Controls.Add(this.label_cpu_v);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label_cpu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(23, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 124);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // label_lan
            // 
            this.label_lan.BackColor = System.Drawing.Color.Transparent;
            this.label_lan.ForeColor = System.Drawing.Color.White;
            this.label_lan.Location = new System.Drawing.Point(9, 100);
            this.label_lan.Name = "label_lan";
            this.label_lan.Size = new System.Drawing.Size(116, 16);
            this.label_lan.TabIndex = 36;
            this.label_lan.Text = "0%";
            // 
            // label_mem_v
            // 
            this.label_mem_v.BackColor = System.Drawing.Color.Black;
            this.label_mem_v.Image = global::EliteSider.Properties.Resources.blueprogressbar;
            this.label_mem_v.Location = new System.Drawing.Point(62, 50);
            this.label_mem_v.Name = "label_mem_v";
            this.label_mem_v.Size = new System.Drawing.Size(4, 12);
            this.label_mem_v.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Image = global::EliteSider.Properties.Resources.grayprogressbar;
            this.label7.Location = new System.Drawing.Point(61, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "系统信息";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_mem_n
            // 
            this.label_mem_n.BackColor = System.Drawing.Color.Transparent;
            this.label_mem_n.ForeColor = System.Drawing.Color.White;
            this.label_mem_n.Location = new System.Drawing.Point(9, 50);
            this.label_mem_n.Name = "label_mem_n";
            this.label_mem_n.Size = new System.Drawing.Size(53, 12);
            this.label_mem_n.TabIndex = 32;
            this.label_mem_n.Text = "0%";
            // 
            // label_cpu_v
            // 
            this.label_cpu_v.BackColor = System.Drawing.Color.Black;
            this.label_cpu_v.Image = global::EliteSider.Properties.Resources.blueprogressbar;
            this.label_cpu_v.Location = new System.Drawing.Point(62, 33);
            this.label_cpu_v.Name = "label_cpu_v";
            this.label_cpu_v.Size = new System.Drawing.Size(4, 12);
            this.label_cpu_v.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "0%";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "0%";
            this.label12.Paint += new System.Windows.Forms.PaintEventHandler(this.label12_Paint);
            // 
            // label_cpu
            // 
            this.label_cpu.BackColor = System.Drawing.Color.Black;
            this.label_cpu.Image = global::EliteSider.Properties.Resources.grayprogressbar;
            this.label_cpu.Location = new System.Drawing.Point(61, 33);
            this.label_cpu.Name = "label_cpu";
            this.label_cpu.Size = new System.Drawing.Size(62, 12);
            this.label_cpu.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "0%";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.BackgroundImage = global::EliteSider.Properties.Resources.calendar;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label_week);
            this.groupBox1.Controls.Add(this.label_day);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(53, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 96);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label_week
            // 
            this.label_week.BackColor = System.Drawing.Color.Transparent;
            this.label_week.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_week.ForeColor = System.Drawing.Color.White;
            this.label_week.Location = new System.Drawing.Point(7, 70);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(88, 23);
            this.label_week.TabIndex = 44;
            this.label_week.Text = "1";
            this.label_week.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day
            // 
            this.label_day.BackColor = System.Drawing.Color.Transparent;
            this.label_day.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_day.ForeColor = System.Drawing.Color.White;
            this.label_day.Location = new System.Drawing.Point(11, 31);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(84, 39);
            this.label_day.TabIndex = 43;
            this.label_day.Text = "1";
            this.label_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(7, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 25);
            this.label17.TabIndex = 42;
            this.label17.Text = "1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_clock_in
            // 
            this.panel_clock_in.BackgroundImage = global::EliteSider.Properties.Resources.playboy;
            this.panel_clock_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_clock_in.Location = new System.Drawing.Point(24, 20);
            this.panel_clock_in.Name = "panel_clock_in";
            this.panel_clock_in.Size = new System.Drawing.Size(130, 130);
            this.panel_clock_in.TabIndex = 1;
            this.panel_clock_in.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel_clock_in_MouseDoubleClick);
            this.panel_clock_in.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_clock_in_Paint);
            // 
            // panel_lv
            // 
            this.panel_lv.BackColor = System.Drawing.Color.White;
            this.panel_lv.Controls.Add(this.panel1);
            this.panel_lv.Location = new System.Drawing.Point(10, 3);
            this.panel_lv.Name = "panel_lv";
            this.panel_lv.Size = new System.Drawing.Size(130, 40);
            this.panel_lv.TabIndex = 48;
            this.panel_lv.Visible = false;
            // 
            // buttonRadio
            // 
            this.buttonRadio.BackColor = System.Drawing.Color.Black;
            this.buttonRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRadio.ForeColor = System.Drawing.Color.Aqua;
            this.buttonRadio.Location = new System.Drawing.Point(24, 610);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(62, 23);
            this.buttonRadio.TabIndex = 49;
            this.buttonRadio.Text = "Radio";
            this.buttonRadio.UseVisualStyleBackColor = false;
            this.buttonRadio.MouseLeave += new System.EventHandler(this.buttonRadio_MouseLeave);
            this.buttonRadio.Click += new System.EventHandler(this.button1_Click);
            this.buttonRadio.MouseHover += new System.EventHandler(this.buttonRadio_MouseHover);
            // 
            // button_min
            // 
            this.button_min.BackColor = System.Drawing.Color.Yellow;
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_min.ForeColor = System.Drawing.Color.Aqua;
            this.button_min.Location = new System.Drawing.Point(125, 7);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(10, 10);
            this.button_min.TabIndex = 49;
            this.button_min.Text = "_";
            this.button_min.UseVisualStyleBackColor = false;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.OrangeRed;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.ForeColor = System.Drawing.Color.Aqua;
            this.button_close.Location = new System.Drawing.Point(143, 7);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(10, 10);
            this.button_close.TabIndex = 49;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(106, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 49;
            this.button1.Text = "@";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 780);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GreenYellow;
            this.panel3.Controls.Add(this.buttonRadio);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.button_weather);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.button_calendar);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button_news);
            this.panel3.Controls.Add(this.button_close);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button_min);
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 812);
            this.panel3.TabIndex = 51;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.panel_lv);
            this.panel5.Location = new System.Drawing.Point(3, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 46);
            this.panel5.TabIndex = 52;
            this.panel5.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(4, 630);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(167, 150);
            this.webBrowser1.TabIndex = 53;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(20, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 136);
            this.panel4.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem1.Text = "Add Picture";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Media file(*.jpg;*.bmp;*.jpeg)|*.jpg;*.jpeg;*.bmp";
            // 
            // timerSysInfo
            // 
            this.timerSysInfo.Enabled = true;
            this.timerSysInfo.Interval = 1000;
            this.timerSysInfo.Tick += new System.EventHandler(this.timerSysInfo_Tick);
            // 
            // timerLazyLoad
            // 
            this.timerLazyLoad.Enabled = true;
            this.timerLazyLoad.Interval = 1000;
            this.timerLazyLoad.Tick += new System.EventHandler(this.timerLazyLoad_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(174, 812);
            this.Controls.Add(this.panel_clock_in);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClockForm";
            this.TransparencyKey = System.Drawing.Color.GreenYellow;
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClockForm_MouseDoubleClick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClockForm_Paint);
            this.VisibleChanged += new System.EventHandler(this.ClockForm_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClockForm_FormClosing);
            this.Load += new System.EventHandler(this.ClockForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel_lv.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_clock_in;
        private System.Windows.Forms.Label label_cpu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer counterPollTimer;
        private System.Windows.Forms.Label label_cpu_v;
        private System.Windows.Forms.Label label_mem_v;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_mem_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_weather;
        private System.Windows.Forms.Button button_calendar;
        private System.Windows.Forms.Button button_news;
        private System.Windows.Forms.Label label_lan;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_lv;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timerSysInfo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timerLazyLoad;
    }
}