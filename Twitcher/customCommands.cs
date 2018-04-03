﻿using System;
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
    public partial class customCommands : MetroFramework.Controls.MetroUserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void DataGridViewCellEvent(object sender, DataGridViewCellEventArgs e);

        public event ButtonClickedEventHandler CommandBtn_Click;
        public event DataGridViewCellEvent CellButton_Click;

        public customCommands()
        {
            InitializeComponent();
        }

        private void customCommands_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            CommandBtn_Click?.Invoke(sender, e);
        }

        public string commandTrigger
        {
            get { return txtBoxCommandTrigger.Text; }
        }

        public string commandReturn
        {
            get { return txtBoxCommandReturnText.Text; }
        }

        public string commandUserlevel
        {
            get { return comboBoxUserLevel.SelectedItem.ToString(); }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellButton_Click?.Invoke(sender, e);
        }
    }
}
