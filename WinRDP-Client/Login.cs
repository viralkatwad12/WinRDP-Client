using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRDP_Client
{
    public partial class Login : Form
    {

        RDPDataSetTableAdapters.UsersTableAdapter Users = new RDPDataSetTableAdapters.UsersTableAdapter();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rDPDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.rDPDataSet.Users);

        }

        public bool log = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)Users.SuccessfulLogin(textBox1.Text, textBox2.Text) > 0)
            {
                log = true;
            }
            Close();
        }
    }
}
