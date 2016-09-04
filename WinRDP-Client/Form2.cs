using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRDP_Client
{
    public partial class Form2 : Form
    {
        public Form2(string ip, string user, string pass)
        {

            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            
            panel1.Dock = DockStyle.Bottom;
            panel1.BackColor = Color.FromArgb(70, 0, 0, 0);
            panel1.Visible = false;

            axMsRdpClient71.Dock = DockStyle.Fill;


            axMsRdpClient71.Server = ip;
            axMsRdpClient71.UserName = user;

            IMsTscNonScriptable secured = (IMsTscNonScriptable)axMsRdpClient71.GetOcx();
            secured.ClearTextPassword = pass;

            axMsRdpClient71.AdvancedSettings8.AuthenticationLevel = 2;
            axMsRdpClient71.AdvancedSettings8.EnableCredSspSupport = true;
            axMsRdpClient71.AdvancedSettings8.NegotiateSecurityLayer = false;

            axMsRdpClient71.AdvancedSettings8.RelativeMouseMode = true;
            axMsRdpClient71.AdvancedSettings.BitmapPeristence = 1;
            axMsRdpClient71.AdvancedSettings.Compress = 1;
            axMsRdpClient71.AdvancedSettings8.SmartSizing = true;
            //axMsRdpClient71.DesktopHeight = 1366;
            //axMsRdpClient71.DesktopWidth = 768;
            axMsRdpClient71.FullScreen = false;
            axMsRdpClient71.ColorDepth = 32;


            axMsRdpClient71.AdvancedSettings8.RedirectDrives = false;
            axMsRdpClient71.AdvancedSettings8.RedirectPrinters = false;
            axMsRdpClient71.AdvancedSettings8.RedirectClipboard = true;
            axMsRdpClient71.AdvancedSettings8.RedirectSmartCards = false;

            axMsRdpClient71.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axMsRdpClient71.Disconnect();
            Close();
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 2000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            axMsRdpClient71.FullScreen = true;
        }

        private void axMsRdpClient71_OnLeaveFullScreenMode(object sender, EventArgs e)
        {
            //MessageBox.Show("123");
            topmost();
            this.TopMost = true;
        }

        public bool topmost()
        {
            return this.TopMost = true;
        }
        private void axMsRdpClient71_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            Close();
        }
    }
}
