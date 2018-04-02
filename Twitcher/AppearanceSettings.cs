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
    public partial class AppearanceSettings : MetroFramework.Controls.MetroUserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);

        public event ButtonClickedEventHandler MetroTile_Click;

        public event ButtonClickedEventHandler MetroToggle_Click;

        public AppearanceSettings()
        {
            InitializeComponent();

            foreach (Control c in Controls)
            {
                if (c is MetroFramework.Controls.MetroTile)
                {
                    c.Click += new EventHandler(onMetroClick);
                }
            }
            themeToggle.Click += new EventHandler(onToggleClick);
        }

        private void onToggleClick(object sender, EventArgs e)
        {
            MetroToggle_Click?.Invoke(sender, e);
        }

        private void onMetroClick(object sender, EventArgs e)
        {
            MetroTile_Click?.Invoke(sender, e);
        }

        public Boolean ThemeChecked
        {
            get { return themeToggle.Checked; }
            set { themeToggle.Checked = value; }
        }

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}