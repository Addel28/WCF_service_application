using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_service_application;
using WCF_service_application.Models;

namespace WCF_WinForm
{
    public partial class Form1 : Form
    {
        Service1 client = new Service1();

        public Form1()
        {
            InitializeComponent();
            client.FirstStartDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel(0, textBox1.Text, textBox2.Text);
            client.POST(userModel);
            listBox1.Text = client.GetLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.DeleteDB(int.Parse(textBox1.Text));
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string line = client.GetLine();
            //listBox1.Text = client.GetLine();
            listBox1.Items.Add((string)line);
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using WCF_service_application;
//using WCF_service_application.Models;

//namespace WCF_Windows_Form
//{
//    public partial class Form1 : Form
//    {
//        Service1 client = new Service1();

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            var data = client.SelectDb();
//            foreach (var item in data) { listBox1.Items.Add(item); }
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            UserModel userModel = new UserModel(0, textBox1.Text, textBox2.Text);
//            client.POST(userModel);
//        }
//    }
//}