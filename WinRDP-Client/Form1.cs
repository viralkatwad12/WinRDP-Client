using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMSTSCLib;
using MSTSCLib;

namespace WinRDP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string user = textBox2.Text;
            string pass = textBox3.Text;

            Form2 f2 = new Form2(ip, user, pass);
            f2.Show();
        }
    }
}
