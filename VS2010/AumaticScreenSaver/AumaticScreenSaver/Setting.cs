using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AumaticScreenSaver
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            int sWidth = SystemInformation.VirtualScreen.Width;//pobiera szerokosc ekranu
            int sHeight = SystemInformation.VirtualScreen.Height;//pobiera wysokosc ekranu
            this.CenterToScreen();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\AumaticScreenSaver");
            if (key == null)
                intervalTextBox.Text = "1500";
            else
                intervalTextBox.Text = (string)key.GetValue("Interval");
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\AumaticScreenSaver");
            key.SetValue("Interval", intervalTextBox.Text);
            Close();
        }
    }
}
