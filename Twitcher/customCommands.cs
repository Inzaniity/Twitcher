using System;
using System.Drawing;
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
            comboBoxUserLevel.SelectedIndex = 0;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            CommandBtn_Click?.Invoke(sender, e);
        }

        public string commandTrigger
        {
            get
            {
                if (txtBoxCommandTrigger.Text != "")
                {
                    return txtBoxCommandTrigger.Text;
                }
                return "";
            }
            set { txtBoxCommandTrigger.Text = value; }
        }

        public string commandReturn
        {
            get
            {
                if (txtBoxCommandReturnText.Text != "")
                {
                    return txtBoxCommandReturnText.Text;
                }
                return "";
            }
            set { txtBoxCommandReturnText.Text = value; }
        }

        public string commandUserlevel

        {
            get { return comboBoxUserLevel.SelectedItem.ToString(); }
            set { comboBoxUserLevel.SelectedIndex = int.Parse(value); }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellButton_Click?.Invoke(sender, e);
        }

        //private void metroGrid1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.ColumnIndex == 4 && e.RowIndex > -1)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        //        var w = Properties.Resources.RemoveCommand_16x.Width;
        //        var h = Properties.Resources.RemoveCommand_16x.Height;
        //        var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
        //        var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

        //        e.Graphics.DrawImage(Properties.Resources.RemoveCommand_16x, new Rectangle(x, y, w, h));
        //        e.Handled = true;
        //    }
        //}
    }
}