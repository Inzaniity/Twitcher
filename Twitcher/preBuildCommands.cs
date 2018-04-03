using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitcher
{
    public partial class preBuildCommands : MetroFramework.Controls.MetroUserControl
    {
        public string _path;

        public preBuildCommands()
        {
            InitializeComponent();
        }

        private void preBuildCommands_Load(object sender, EventArgs e)
        {
            txtBoxSong.Text = Properties.Settings.Default.songPath;
            metroToggle2.Checked = Properties.Settings.Default.songEnabeld;
            btnSong.Enabled = Properties.Settings.Default.songEnabeld;
            _path = Properties.Settings.Default.songPath;
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxSong.Text = openFileDialog1.FileName;
                txtBoxSong.Select(txtBoxSong.MaxLength, 0);
                Properties.Settings.Default.songPath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle2.Checked)
            {
                btnSong.Enabled = true;
                txtBoxSong.Enabled = true;
                Properties.Settings.Default.songEnabeld = true;
            }
            else
            {
                btnSong.Enabled = false;
                txtBoxSong.Enabled = false;
                Properties.Settings.Default.songEnabeld = false;
            }
            Properties.Settings.Default.Save();
        }

        public Boolean SongEnabled
        {
            get {return metroToggle2.Checked; }
        }
    }
}
