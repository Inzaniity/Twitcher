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

        public delegate void Eventhandler(object sender, EventArgs e);

        public event ButtonClickedEventHandler MetroTile_Click;

        public event Eventhandler MetroCheckedChange;

        //this.themeToggle.CheckedChanged += new System.EventHandler(this.themeToggle_CheckedChanged);

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
            if (Properties.Settings.Default.theme == 2)
            {
                themeToggle.Checked = true;
            }
            else
            {
                themeToggle.Checked = false;
            }

            themeToggle.CheckedChanged += new EventHandler(onToggleChange);
        }

        private void onToggleChange(object sender, EventArgs e)
        {
            MetroCheckedChange?.Invoke(sender, e);
        }

        private void onMetroClick(object sender, EventArgs e)
        {
            MetroTile_Click?.Invoke(sender, e);
        }

        public Boolean ThemeChecked
        {
            get { return themeToggle.Checked; }
            set
            {
                themeToggle.CheckedChanged -= onToggleChange;

                if (value)
                {
                    themeToggle.Checked = true;
                }
                else
                {
                    themeToggle.Checked = false;
                };
                themeToggle.CheckedChanged += onToggleChange;
            }
        }

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}