using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          XmlDocument xDoc=new XmlDocument();
        String path = "../../students.xml";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNameSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlNode students = xDoc.SelectSingleNode("Students");

            XmlElement student = xDoc.CreateElement("student");
            xDoc.AppendChild(students);

            XmlAttribute number = xDoc.CreateAttribute("Number");
            number.Value = (lbxStudents.Items.Count + 1).ToString();
            student.Attributes.Append(number);

            XmlElement nameSurname = xDoc.CreateElement("NameSurname");
            nameSurname.InnerText = txtNameSurname.Text;
            student.AppendChild(nameSurname);

            XmlElement phone = xDoc.CreateElement("Phone");
            phone.InnerText = txtPhone.Text;
            student.AppendChild(phone);

            students.AppendChild(student);

            xDoc.Save(path);
            MessageBox.Show("Kayıt Eklendi!");
            LoadXML();
            txtNameSurname.Text = txtPhone.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                CreateXML();
            }
            LoadXML();
        }

        private void LoadXML()
        {
            lbxStudents.Items.Clear();
            xDoc.Load(path);
          //  XmlNode root = xDoc.SelectSingleNode();
            XmlNodeList students = xDoc.SelectNodes("Students/Student");

            foreach (XmlNode item in students)
            {
                string text = string.Format($"{item.Attributes["Number"].Value}- {item["NameSurname"].InnerText}({item["Phone"].InnerText})");
                lbxStudents.Items.Add(text);
            }
        }

        private void CreateXML()
        {
           XmlDeclaration xDec= xDoc.CreateXmlDeclaration("1.0","utf-8", null);
            xDoc.AppendChild(xDec);

            XmlElement students = xDoc.CreateElement("students");
            xDoc.AppendChild(students);

            XmlElement student = xDoc.CreateElement("student");
            XmlAttribute number = xDoc.CreateAttribute("Number");
            number.Value = (lbxStudents.Items.Count + 1).ToString();

            student.Attributes.Append(number); 

            XmlElement nameSurname=xDoc.CreateElement ("NameSurname");
            nameSurname.InnerText = "Ali Veli";
            student.AppendChild(nameSurname);

            XmlElement phone = xDoc.CreateElement("Phone");
            phone.InnerText = "555 44 33";
            student.AppendChild(phone);

            students.AppendChild(student);  

            xDoc.Save(path);


        }
    }
}
