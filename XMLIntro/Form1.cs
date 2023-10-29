using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xDoc.Load(path);
            XmlNode Color = xDoc.SelectSingleNode("settings/color");
            int r = int.Parse(Color.SelectSingleNode("red").InnerText);
            int g = int.Parse(Color.SelectSingleNode("green").InnerText);
            int b = int.Parse(Color.SelectSingleNode("blue").InnerText);

           
        }
        XmlDocument xDoc = new XmlDocument();
        string path = "../../Mysettings.xml";
        private void btnColor_Set(object sender, EventArgs e)
        {
            Button Selected = (Button)sender;

            this.BackColor = Selected.BackColor;

            xDoc.Load(path);
            XmlNode Color = xDoc.SelectSingleNode("settings/color");
            Color.SelectSingleNode("red").InnerText = this.BackColor.R.ToString();
            Color.SelectSingleNode("green").InnerText = this.BackColor.G.ToString();
            Color.SelectSingleNode("blue").InnerText = this.BackColor.B.ToString();
            xDoc.Save(path);


        }
    }
}
