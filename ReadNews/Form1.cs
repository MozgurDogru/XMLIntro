using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ReadNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebClient client = new WebClient();
        XmlDocument xDoc = new XmlDocument();
        private void Form1_Load(object sender, EventArgs e)
        {
            lbxTitle.Items.Clear();
           // lbxTitle.DisplayMember = "Title";
            client.Encoding = Encoding.UTF8;
            string text = client.DownloadString("http://www.hurriyet.com.tr/rss/gundem");
            xDoc.LoadXml(text);

            XmlNodeList news = xDoc.SelectNodes("rss/channel/item");

            foreach (XmlNode item in news)
            {
                News news1 = new News()
                {
                    Title = item.SelectSingleNode("title").InnerText,
                    Desc = item.SelectSingleNode("description").InnerText,
                    Url = item.SelectSingleNode("link").InnerText
                };
                lbxTitle.Items.Add(news1);
            }
        }

        private void lbxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            News selected = lbxTitle.SelectedItem as News;
            rtxtDesc.Text = selected.Desc;
            wbContent.Navigate(selected.Url);
            wbContent.ScriptErrorsSuppressed = true;
        }
    }
}
