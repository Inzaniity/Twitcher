using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Twitcher
{
    public partial class ConnectionSettings : MetroFramework.Controls.MetroUserControl
    {
        public ConnectionSettings()
        {
            InitializeComponent();
        }

        public String botNameString
        {
            get { return txtBoxBotName.Text; }
            set { txtBoxBotName.Text = value; }
        }

        public String OAuthString
        {
            get { return txtBoxOAuth.Text; }
            set { txtBoxOAuth.Text = value; }
        }

        public String ChannelString
        {
            get { return txtBoxChannelName.Text; }
            set { txtBoxChannelName.Text = value; }
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
        }

        private void ConnectionSettings_Load_1(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            botNameString = Properties.Settings.Default.botname;
            OAuthString = Properties.Settings.Default.oauth;
            ChannelString = Properties.Settings.Default.channelname;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.botname = botNameString;
            Properties.Settings.Default.oauth = OAuthString;
            Properties.Settings.Default.channelname = ChannelString;
            Properties.Settings.Default.Save();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi/");
        }
    }
}