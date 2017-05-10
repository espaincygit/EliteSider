namespace EliteSider
{
    partial class FormNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNews));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_newsTitle = new System.Windows.Forms.Label();
            this.timer_News = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 467);
            this.panel1.TabIndex = 41;
            this.panel1.VisibleChanged += new System.EventHandler(this.panel1_VisibleChanged);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 - Asahi",
            "2 - Tianya",
            "3 - Sina",
            "4 - Sohu",
            "5 - Yesky"});
            this.comboBox1.Location = new System.Drawing.Point(97, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 20);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.Text = "1 - Asahi";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(66, 438);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(25, 19);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Transparent";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(224, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(16, 20);
            this.button3.TabIndex = 51;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(204, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 20);
            this.button2.TabIndex = 50;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(242, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 357);
            this.panel3.TabIndex = 48;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(6, 118);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(263, 314);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 49;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseEnter += new System.EventHandler(this.listView1_MouseEnter);
            this.listView1.MouseLeave += new System.EventHandler(this.listView1_MouseLeave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 235;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 34);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 20);
            this.button1.TabIndex = 46;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::EliteSider.Properties.Resources.currency;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label_newsTitle);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 105);
            this.panel2.TabIndex = 45;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label_newsTitle
            // 
            this.label_newsTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_newsTitle.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_newsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_newsTitle.Location = new System.Drawing.Point(57, 77);
            this.label_newsTitle.Name = "label_newsTitle";
            this.label_newsTitle.Size = new System.Drawing.Size(181, 23);
            this.label_newsTitle.TabIndex = 44;
            this.label_newsTitle.Text = "No News";
            this.label_newsTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer_News
            // 
            this.timer_News.Interval = 300000;
            this.timer_News.Tick += new System.EventHandler(this.timer_News_Tick);
            // 
            // FormNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(253, 469);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "FormNews";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "News";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.FormNews_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_newsTitle;
        private System.Windows.Forms.Timer timer_News;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}