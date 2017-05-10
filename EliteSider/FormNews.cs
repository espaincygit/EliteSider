using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using System.Threading;

namespace EliteSider
{
    public partial class FormNews : Form
    {
        public FormNews()
        {
            InitializeComponent();
            
        }

        ArrayList newsLinkList = new ArrayList();
        private Point mouse_offset;
        private bool isShowTitlePic = true;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            mouse_offset = new Point(-e.X - 7, -e.Y - 8);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point mousepos = Control.MousePosition;

                mousepos.Offset(mouse_offset.X, mouse_offset.Y);

                Location = mousepos;

            }
           
        }

        private void SetNewsLink()
        {

            Debug.WriteLine("SetNewsLink");
            newsLinkList.Clear();
            int num = Int32.Parse(comboBox1.Text.Substring(0, 1));
            switch (num)
            {
                case 1:
                    AddAsahi();
                    break;
                case 2:

                    AddTianyaNews();
                    break;
                case 3:

                    AddSinaNews();
                    break;
                case 4:

                    AddSohuNews();
                    break;
                case 5:

                    AddYeskyNews();
                    break;
                default:

                    AddAsahi();
                    break;

            } 

        }
 
        private void AddAsahi()
        {
            //newsLinkList.Add("");
            // foreign exchange
            newsLinkList.Add("http://www3.asahi.com/rss/index.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/pandemicflu.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/national.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/politics.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/sports.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/olympics.rdf"); 
            newsLinkList.Add("http://www3.asahi.com/rss/business.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/international.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/culture.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/book.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/science.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/fashion.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/car.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/digital.rdf");
            newsLinkList.Add("http://www3.asahi.com/rss/shopping.rdf"); 

        }

        private void AddTianyaNews()
        {

            //newsLinkList.Add("");
            // youku
            newsLinkList.Add("http://www.youku.com/index/rss_cool_v/");
            // google news
            newsLinkList.Add("http://news.google.cn/news?ned=ccn&hl=zh-CN&output=rss");
            // foreign exchange
            newsLinkList.Add("http://fx.678678.com/forexRss/DataRSS/ForexRss1.xml");
            // stock market
            newsLinkList.Add("http://www.chonger99.com/rss.php");
            // erp
            newsLinkList.Add("http://www.erpwhy.com/data/rss/7.xml");
            // investment
            //newsLinkList.Add("http://www.bowu.cc/data/rss/5.xml");
            // cinema
            newsLinkList.Add("http://www.888945.com/rrs.xml");
            // boy movie
            newsLinkList.Add("http://boydy.cn/rss.xml");
            // film
            newsLinkList.Add("http://www.7274.net/Rss.xml");
            // tianya focus
            //newsLinkList.Add("http://focus.tianya.cn/focus/rss.xml");
            // hacker
            //newsLinkList.Add("http://xiyingbiao.blogbus.com/index.rdf");
            // investment
            //newsLinkList.Add("http://www.bowu.cc/data/rss/5.xml");
            // av girl
            newsLinkList.Add("http://www.av-fans.com/rss.php?lang=en_US");
            // saver
            //newsLinkList.Add("http://feed.mysaver.cn/");
            // stock operation
            //newsLinkList.Add("http://www.yesguu.com/do/rss.php?fid=53");

            // stock analysis
            //newsLinkList.Add("http://www.yesguu.com/do/rss.php?fid=44");
            // stock newbee
            //newsLinkList.Add("http://www.yesguu.com/do/rss.php");
            // fun info
            //newsLinkList.Add("http://www.yaeee.com/sites/tianya/funinfo_rss.php");

        }

        private void AddYdyNews()
        {
            newsLinkList.Add("http://bt.ydy.com/rss.php");
        }

        private void AddYeskyNews()
        {
            //newsLinkList.Add("http://myhard.yesky.com/index.xml");
            //newsLinkList.Add("http://digital.yesky.com/index.xml");
            newsLinkList.Add("http://game.yesky.com/index.xml");
            //newsLinkList.Add("http://notebook.yesky.com/index.xml");
            //newsLinkList.Add("http://e.yesky.com/index.xml");
            newsLinkList.Add("http://dh.yesky.com/index.xml");
        }

        private void AddSohuNews()
        {
            //newsLinkList.Add("http://rss.news.sohu.com/rss/pfocus.xml");
            //newsLinkList.Add("http://rss.news.sohu.com/rss/focus.xml");
            newsLinkList.Add("http://rss.news.sohu.com/rss/guonei.xml");
            newsLinkList.Add("http://rss.news.sohu.com/rss/guoji.xml");
            newsLinkList.Add("http://rss.news.sohu.com/rss/shehui.xml");
            newsLinkList.Add("http://mil.news.sohu.com/rss/junshi.xml");
            newsLinkList.Add("http://rss.news.sohu.com/rss/business.xml");
            newsLinkList.Add("http://rss.news.sohu.com/rss/it.xml");
            newsLinkList.Add("http://rss.news.sohu.com/rss/yule.xml");
        }

        private void AddSinaNews()
        {


            newsLinkList.Add("http://rss.sina.com.cn/news/marquee/ddt.xml");
            newsLinkList.Add("http://rss.sina.com.cn/news/china/focus15.xml");
            newsLinkList.Add("http://rss.sina.com.cn/news/world/focus15.xml");
            newsLinkList.Add("http://rss.sina.com.cn/news/china/hktaiwan15.xml");
            newsLinkList.Add("http://rss.sina.com.cn/news/society/focus15.xml");

            newsLinkList.Add("http://rss.sina.com.cn/news/allnews/tech.xml");
            newsLinkList.Add("http://rss.sina.com.cn/tech/rollnews.xml");
            newsLinkList.Add("http://rss.sina.com.cn/tech/internet/home28.xml");
            newsLinkList.Add("http://rss.sina.com.cn/tech/internet/international28.xml");
newsLinkList.Add("http://rss.sina.com.cn/finance/gncj.xml");
            newsLinkList.Add("http://rss.sina.com.cn/finance/roll/newindex.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/news/allnews/ent.xml");
            newsLinkList.Add("http://rss.sina.com.cn/ent/music/focus12.xml");

            //newsLinkList.Add("http://rss.sina.com.cn/shhouse/shencheng13.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/bn/tech.xml");
            newsLinkList.Add("http://rss.sina.com.cn/tech/notebook/193_1.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/tech/notebook/193_2.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/tech/notebook/193_3.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/tech/notebook/193_4.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/tech/notebook/193_5.xml");

            //newsLinkList.Add("http://rss.sina.com.cn/news/allnews/auto.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/auto/z/focus/2.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/auto/z/jiangjiachao/3.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/auto/z/2002-10newcar/6.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/auto/z/guochanche/1.xml");

            //newsLinkList.Add("http://rss.sina.com.cn/bjhouse/tuijian.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/bjhouse/newhouser12.xml");

            //newsLinkList.Add("http://rss.sina.com.cn/news/allnews/games.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/wlyx.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/djyx.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/cyxw.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/dsyx.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/eqxw.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/d/movie.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/d/image.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/d/music.xml");
            /*
            //string news5 = "http://rss.sina.com.cn/news/china/hktaiwan15.xml";            //newsLinkList.Add("http://rss.sina.com.cn/news/allnews/finance.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/finance/jsy.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/finance/ywgg.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/finance/gjcj.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/shhouse/guanzhu4.xml");
            //newsLinkList.Add("http://wm.sina.com.cn/rss/sina_magazine_8.xml");
            //newsLinkList.Add("http://wm.sina.com.cn/rss/sina_magazine_11.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/bn/movie.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/focus.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/jbdongtai.xml");

            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/xinwen.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/waijun.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/junli.xml");

            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/junshi.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/junqing.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/zongheng.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/jczs/col/shijiao.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/zonghe.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/shijiao.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/taiwan20.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/china15.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/col/pingshu.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/hangkong.xml");
            newsLinkList.Add("http://rss.sina.com.cn/jczs/hangtian.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/cysh.xml");
            //newsLinkList.Add("http://rss.sina.com.cn/games/yxyj.xml");
             * */
        }

        int newsNum = 0;

        private void refreshRssNews()
        {
            Debug.WriteLine("refreshRssNews");
            Thread importThread = new System.Threading.Thread(new ThreadStart(NewsProc));
            importThread.Start();

        }
        private void NewsProc()
        {
             
            button1.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            if (newsNum < newsLinkList.Count)
            {
                updateNews(newsLinkList[newsNum].ToString(), true);
                newsNum++;
            }
            else
            {
                newsNum = 0;
                updateNews(newsLinkList[newsNum].ToString(), true);

            }

            Cursor = Cursors.Default;
            button1.Enabled = true;
        }

        private void timer_News_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("timer_News_Tick");
            refreshRssNews();

        }
        private void updateNews(string newsRssLink)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(newsRssLink);

                DataSet ds = new DataSet();

                ds.ReadXml(reader);


                //title [0] category link
                DataTable titleTable = ds.Tables[1];

                label_newsTitle.Text = titleTable.Rows[0].ItemArray[0].ToString();

                DataTable dt = ds.Tables[ds.Tables.Count - 1];
                //dataGridView1.Rows.Clear();
                listView1.BeginUpdate();
                listView1.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {


                    ListViewItem rowNews = new ListViewItem();

                    rowNews.Text = row.ItemArray[0].ToString();

                    rowNews.SubItems.Add(row.ItemArray[1].ToString());

                    listView1.Items.Add(rowNews);
                    //dataGridView1.Rows.Add(new string[] { row.ItemArray[0].ToString(), row.ItemArray[1].ToString() });
                }
                listView1.EndUpdate();

            }
            catch (Exception rss)
            {
                MessageBox.Show(rss.Message);

                label_newsTitle.Text = "No news";
                listView1.Items.Clear();
            }
        }

        private void updateNews(string newsRssLink, bool ok)
        {
            try
            {
                Debug.WriteLine("updateNews");
                label_newsTitle.Text = "Searching news";

                bool isRss = false;
                //XmlTextReader rssReader;

                //XmlDocument rssDoc;

                XmlNode nodeRss = null;

                XmlNode nodeChannel = null;


                XmlTextReader rssReader = new XmlTextReader(newsRssLink);

                XmlDocument rssDoc = new XmlDocument();

                // Load the XML content into a XmlDocument
                try
                {
                    rssDoc.Load(rssReader);
                }
                catch (Exception rssEx)
                {
                    Debug.WriteLine(newsRssLink + "   " + rssEx.Message);
                    return;
                }
                for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
                {

                    // If it is the rss tag

                    if (rssDoc.ChildNodes[i].Name == "rss")
                    {

                        // <rss> tag found

                        nodeRss = rssDoc.ChildNodes[i];
                        isRss = true;
                        break;
                    }
                    else if (rssDoc.ChildNodes[i].Name == "rdf:RDF")
                    {

                        // <rss> tag found

                        nodeRss = rssDoc.ChildNodes[i];
                        isRss = false;
                        break;
                    }

                }

                // Loop for the <channel> tag

                for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
                {

                    // If it is the channel tag

                    if (nodeRss.ChildNodes[i].Name == "channel")
                    {

                        // <channel> tag found

                        nodeChannel = nodeRss.ChildNodes[i];
                        break;
                    }

                }
                // Loop for the <title>, <link>, <description> and all the other tags
                // Set the labels with information from inside the nodes

                label_newsTitle.Text = nodeChannel["title"].InnerText;

                //lblLanguage.Text = "Language: " + nodeChannel["language"].InnerText;

                //lblLink.Text = "Link: " + nodeChannel["link"].InnerText;

                //lblDescription.Text = "Description: " + nodeChannel["description"].InnerText;
                if (isRss)
                {
                    AddRssList(nodeChannel);
                }
                else
                {
                    AddRssList(nodeRss);
                }
               
            }
            catch (Exception rss)
            {
                MessageBox.Show(rss.Message);

                label_newsTitle.Text = "No news";
                listView1.Items.Clear();
            }
        }

        private void AddRssList(XmlNode nodeChannel)
        {

            XmlNode nodeItem = null;
            listView1.BeginUpdate();
            listView1.Items.Clear();
            for (int i = 0; i < nodeChannel.ChildNodes.Count; i++)
            {

                // If it is the item tag, then it has children tags which we will add as items to the ListView

                if (nodeChannel.ChildNodes[i].Name == "item")
                {

                    nodeItem = nodeChannel.ChildNodes[i];
                    // Create a new row in the ListView containing information from inside the nodes

                    ListViewItem rowNews = new ListViewItem();

                    rowNews.Text = nodeItem["title"].InnerText;

                    rowNews.SubItems.Add(nodeItem["link"].InnerText);

                    listView1.Items.Add(rowNews);

                }

            }
            listView1.EndUpdate();
        }
 

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            System.Diagnostics.Process.Start(listView1.SelectedItems[0].SubItems[1].Text);
        }

        private void FormNews_Load(object sender, EventArgs e)
        {
            SetNewsLink();
          
            newsNum = 0;// new Random().Next(newsLinkList.Count); 

            refreshRssNews();
            /*
            GraphicsPath myGraphicsPath = new GraphicsPath();

            myGraphicsPath.AddRectangle(new Rectangle(dataGridView1.Left, dataGridView1.Top, dataGridView1.Width -10, dataGridView1.Height - 20));

            dataGridView1.Region = new Region(myGraphicsPath);
            */
        }
 

        private void button1_Click(object sender, EventArgs e)
        {

            Debug.WriteLine("button1_Click");
            //button1.Enabled = false;
            //this.Cursor = Cursors.WaitCursor;
            refreshRssNews();
            //Cursor = Cursors.Default;
            //button1.Enabled = true;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("dataGridView1_MouseDoubleClick"); 
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.WriteLine("dataGridView1_CellMouseDoubleClick");

            //System.Diagnostics.Process.Start(dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());

        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {

            //this.timer_News.Interval = Visible ? timer_News.Interval : timer_News.Interval * 2;	
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            this.Opacity = 0.1;

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;

        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;

        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            this.Opacity = 0.1;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            this.Opacity = 1;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            this.Opacity = 0.1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            this.Opacity = 0.1;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            this.Opacity = 1;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            this.Opacity = 1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            this.Opacity = 0.1;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isShowTitlePic)
            {
                isShowTitlePic = false;
                this.panel2.BackgroundImage = null;
            }
            else
            {
                isShowTitlePic = true;
                panel2.BackgroundImage = EliteSider.Properties.Resources.currency;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewsLink();
        }


    }
}