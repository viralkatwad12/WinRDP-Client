namespace WinRDP_Client
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.axMsRdpClient71 = new AxMSTSCLib.AxMsRdpClient7();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient71)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axMsRdpClient71
            // 
            this.axMsRdpClient71.Enabled = true;
            this.axMsRdpClient71.Location = new System.Drawing.Point(-167, -33);
            this.axMsRdpClient71.Name = "axMsRdpClient71";
            this.axMsRdpClient71.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsRdpClient71.OcxState")));
            this.axMsRdpClient71.Size = new System.Drawing.Size(1195, 632);
            this.axMsRdpClient71.TabIndex = 6;
            this.axMsRdpClient71.OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.axMsRdpClient71_OnDisconnected);
            this.axMsRdpClient71.OnLeaveFullScreenMode += new System.EventHandler(this.axMsRdpClient71_OnLeaveFullScreenMode);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 29);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fullscreen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axMsRdpClient71);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseEnter += new System.EventHandler(this.Form2_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form2_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient71)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient7 axMsRdpClient71;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}