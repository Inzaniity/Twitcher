using MetroFramework;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Events.Client;
using TwitchLib.Models.Client;

namespace Twitcher
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private TwitchClient _client;
        private SQLiteCommand _command;
        private ConnectionCredentials _credentials;
        private readonly SQLiteConnection _dbConnection = new SQLiteConnection("Data Source = db.sqlite; Version = 3;");
        private string _song, _sqlQuery;
        private ConnectionSettings cs = new ConnectionSettings();
        private AppearanceSettings ds = new AppearanceSettings();
        private preBuildCommands pb = new preBuildCommands();
        private customCommands cc = new customCommands();

        public Form1()
        {
            InitializeComponent();
            ds.MetroTile_Click += Ds_MetroTile_Click;
            ds.MetroCheckedChange += Ds_MetroToggle_Click;
            cc.CommandBtn_Click += Cc_CommandBtn_Click;
            cc.CellButton_Click += Cc_CellButton_Click;
        }

        private void Cc_CellButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (MetroFramework.Controls.MetroGrid)sender;
            if (e.ColumnIndex == 4)
                if (MetroMessageBox.Show(this, "Do you really want to delete the command \"" + cc.metroGrid1.Rows[e.RowIndex].Cells[1].Value + "\" ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _sqlQuery = "DELETE FROM commands WHERE id = " + cc.metroGrid1.Rows[e.RowIndex].Cells[0].Value + ";";
                    _dbConnection.Open();
                    _command = new SQLiteCommand(_sqlQuery, _dbConnection);
                    _command.ExecuteNonQuery();
                    _dbConnection.Close();

                    ReadDb();
                }
                else { return; }
        }

        private void Cc_CommandBtn_Click(object sender, EventArgs e)
        {
            _sqlQuery = "INSERT INTO `commands` (trigger, returntext, userlevel) values ('" + cc.commandTrigger + "', '" + cc.commandReturn + "', '" + cc.commandUserlevel + "');";
            _dbConnection.Open();
            _command = new SQLiteCommand(_sqlQuery, _dbConnection);
            _command.ExecuteNonQuery();
            _dbConnection.Close();

            ReadDb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroPanel1.Controls.Add(ds);
            metroPanel1.Controls.Add(cs);
            metroPanel1.Controls.Add(pb);
            metroPanel1.Controls.Add(cc);

            foreach (Control item in metroPanel1.Controls)
            {
                item.Visible = false;
            }

            #region Reading from Config (Theme Style and other)

            cs.botNameString = Properties.Settings.Default.botname;
            cs.OAuthString = Properties.Settings.Default.oauth;
            cs.ChannelString = Properties.Settings.Default.channelname;
            applyStyle();

            #endregion Reading from Config (Theme Style and other)

            #region Database Stuff

            //TODO DB Stuff
            if (!File.Exists("db.sqlite"))
            {
                SQLiteConnection.CreateFile("db.sqlite");
                _sqlQuery = "CREATE TABLE `commands` (`id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, `trigger` TEXT NOT NULL UNIQUE, `returntext` TEXT NOT NULL, `userlevel` TEXT NOT NULL);";
                _dbConnection.Open();
                _command = new SQLiteCommand(_sqlQuery, _dbConnection);
                _command.ExecuteNonQuery();
                _dbConnection.Close();
            }
            else
            {
                ReadDb();
            }

            #endregion Database Stuff
        }

        private void Ds_MetroToggle_Click(object sender, EventArgs e)
        {
            var mtoggle = (MetroFramework.Controls.MetroToggle)sender;
            if (mtoggle.Checked)
            {
                Properties.Settings.Default.theme = 2;
            }
            else
            {
                Properties.Settings.Default.theme = 1;
            }
            Properties.Settings.Default.Save();

            applyStyle();
        }

        private void Ds_MetroTile_Click(object sender, EventArgs e)
        {
            var tile = (MetroFramework.Controls.MetroTile)sender;
            Properties.Settings.Default.color = (int)tile.Style;
            Properties.Settings.Default.Save();
            applyStyle();
        }

        public void AppendTextBox(string value, Color color, FontStyle fs)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, Color, FontStyle>(AppendTextBox), new object[] { value, color, fs });
                return;
            }
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = color;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, fs);
            richTextBox1.AppendText(value);
            richTextBox1.SelectionColor = richTextBox1.ForeColor;
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        public void PrintLog(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(PrintLog), new object[] { value });
                return;
            }
            toolStripLabel1.Text = DateTime.Now.ToString("hh:mm:ss ") + value;
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            SendMsg();
        }

        private void SendMsg()
        {
            if (_client != null)
            {
                if (_client.IsConnected)
                {
                    _client.SendMessage(txtBoxChatMsg.Text);
                    //Timestamp
                    AppendTextBox(DateTime.Now.ToString("h:mm:ss "), richTextBox1.ForeColor, FontStyle.Italic);
                    // Colored Username
                    AppendTextBox(Properties.Settings.Default.botname, Color.Teal, FontStyle.Bold);
                    // Message
                    AppendTextBox(": " + txtBoxChatMsg.Text + Environment.NewLine, richTextBox1.ForeColor, FontStyle.Regular);

                    txtBoxChatMsg.Clear();
                }
                else
                {
                    MetroMessageBox.Show(this, "The Bot is not connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "The Bot is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                _credentials = new ConnectionCredentials(Properties.Settings.Default.botname, Properties.Settings.Default.oauth);
                _client = new TwitchClient(_credentials, Properties.Settings.Default.channelname);
                _client.OnConnected += OnConnect;
                _client.OnDisconnected += OnDisconnect;
                _client.OnConnectionError += OnConnectionError;
                _client.OnJoinedChannel += OnJoinedChannel;
                _client.OnMessageReceived += OnMessageReceived;
                _client.OnWhisperReceived += OnWhisperReceived;
                _client.OnNewSubscriber += OnNewSubscriber;
                _client.OnReSubscriber += OnReSubscriber;
                _client.Connect();
            }
            catch (Exception ex)
            {
                PrintLog(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                _client.Disconnect();
            }
            catch (Exception ex)
            {
                PrintLog(ex.Message);
            }
        }

        public void applyStyle()
        {
            try
            {
                metroStyleManager1.Style = (MetroColorStyle)Properties.Settings.Default.color;
                Style = metroStyleManager1.Style;

                if (Properties.Settings.Default.theme == 2)
                {
                    //ds.ThemeChecked = true;
                    metroStyleManager1.Theme = (MetroThemeStyle)Properties.Settings.Default.theme;
                    Theme = metroStyleManager1.Theme;
                    toolStripLabel1.ForeColor = Color.White;
                }
                else
                {
                    //ds.ThemeChecked = false;
                    metroStyleManager1.Theme = (MetroThemeStyle)Properties.Settings.Default.theme;
                    Theme = metroStyleManager1.Theme;
                    toolStripLabel1.ForeColor = Color.Black;
                }
                metroStyleManager1.Update();
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.Message);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Style = (MetroColorStyle)Properties.Settings.Default.color;
            Theme = (MetroThemeStyle)Properties.Settings.Default.theme;

            metroStyleManager1.Style = Style;
            Style = metroStyleManager1.Style;
            metroStyleManager1.Update();
        }

        private void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (ds.ThemeChecked)
            {
                metroStyleManager1.Theme = MetroThemeStyle.Dark;
                Theme = MetroThemeStyle.Dark;
                Properties.Settings.Default.theme = (int)MetroThemeStyle.Dark;
                toolStripLabel1.ForeColor = Color.White;
            }
            else
            {
                metroStyleManager1.Theme = MetroThemeStyle.Light;
                Theme = MetroThemeStyle.Light;
                Properties.Settings.Default.theme = (int)MetroThemeStyle.Light;
                toolStripLabel1.ForeColor = Color.Black;
            }
            Properties.Settings.Default.Save();
            metroStyleManager1.Update();
        }

        private void OnCommandReceived(object sender, OnWhisperCommandReceivedArgs e)
        {
        }

        private void OnConnect(object sender, OnConnectedArgs e)
        {
            PrintLog("Connected to #" + Properties.Settings.Default.channelname);
        }

        private void OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            PrintLog("Connection Error: " + e);
        }

        private void OnDisconnect(object sender, OnDisconnectedArgs e)
        {
            PrintLog("Disconnected from #" + Properties.Settings.Default.channelname);
        }

        private void OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
        }

        private void OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            Console.WriteLine(e.ChatMessage.Username + "\t" + e.ChatMessage.UserType);

            #region Text To Textbox

            Color color;
            if (e.ChatMessage.Color.IsEmpty == false)
            {
                // Assign the color that Twitch says is their chat color
                color = e.ChatMessage.Color;
            }
            else
            {
                // Assign a random color since Twitch didn't specify a color.
                var ran = new Random();
                color = Color.FromArgb(ran.Next(256), ran.Next(256), ran.Next(256));
            }

            //Timestamp
            AppendTextBox(DateTime.Now.ToString("h:mm:ss "), richTextBox1.ForeColor, FontStyle.Italic);
            // Colored Username
            AppendTextBox(e.ChatMessage.Username, color, FontStyle.Bold);
            // Message
            AppendTextBox(": " + e.ChatMessage.Message + Environment.NewLine, richTextBox1.ForeColor, FontStyle.Regular);

            #endregion Text To Textbox

            #region Chat Triggers / Commands

            if (e.ChatMessage.Message.StartsWith("!song"))
                if (Properties.Settings.Default.songEnabeld)
                {
                    _song = File.ReadAllText(Properties.Settings.Default.songPath);
                    _client.SendMessage("@" + e.ChatMessage.Username + " | " + _song);
                    //Timestamp
                    AppendTextBox(DateTime.Now.ToString("h:mm:ss "), richTextBox1.ForeColor, FontStyle.Italic);
                    // Colored Username
                    AppendTextBox(Properties.Settings.Default.botname, Color.Orange, FontStyle.Bold);
                    // Message
                    AppendTextBox("@" + e.ChatMessage.Username + " | " + _song + Environment.NewLine, richTextBox1.ForeColor, FontStyle.Regular);
                }

            _dbConnection.Open();
            _sqlQuery = "select * from commands order by id asc";
            _command = new SQLiteCommand(_sqlQuery, _dbConnection);
            var reader = _command.ExecuteReader();
            while (reader.Read())
            {
                string returnText;
                if (e.ChatMessage.Message.StartsWith(reader["trigger"].ToString()))
                {
                    returnText = reader["returntext"].ToString();

                    if (returnText.Contains("{sender}"))
                    {
                        returnText = returnText.Replace("{sender}", "@" + e.ChatMessage.Username);
                    }

                    if (returnText.Contains("{target}"))
                    {
                        var splitMsg = e.ChatMessage.Message.Split(new[] { " " }, StringSplitOptions.None);
                        returnText = returnText.Replace("{target}", splitMsg[1]);
                    }
                    _client.SendMessage(returnText);
                }
            }
            _dbConnection.Close();

            #endregion Chat Triggers / Commands
        }

        private void OnNewSubscriber(object sender, OnNewSubscriberArgs e)
        {
        }

        private void OnReSubscriber(object sender, OnReSubscriberArgs e)
        {
            // TODO: OnSubscriber
        }

        private void OnWhisperReceived(object sender, OnWhisperReceivedArgs e)
        {
        }

        private void txtBoxChatMsg_Click(object sender, EventArgs e)
        {
        }

        private void metroGrid1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.RemoveCommand_16x.Width;
                var h = Properties.Resources.RemoveCommand_16x.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.RemoveCommand_16x, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void ReadDb()
        {
            cc.metroGrid1.Rows.Clear();

            _dbConnection.Open();
            _sqlQuery = "select * from commands order by id asc";
            _command = new SQLiteCommand(_sqlQuery, _dbConnection);
            var reader = _command.ExecuteReader();
            while (reader.Read())
                cc.metroGrid1.Rows.Add(new object[] {
                    reader.GetValue(0),
                    reader.GetValue(1),
                    reader.GetValue(2),
                    reader.GetValue(3)
                });
            _dbConnection.Close();
        }

        private void txtBoxChatMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SendMsg();
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            var link = (MetroFramework.Controls.MetroLink)sender;

            foreach (Control c in metroTabControl1.TabPages[1].Controls)
            {
                if (c is MetroFramework.Controls.MetroLink)
                {
                    var linkToFocus = (MetroFramework.Controls.MetroLink)c;

                    if (linkToFocus.Focused)
                    {
                        linkToFocus.FontWeight = MetroLinkWeight.Bold;
                    }
                    else
                    {
                        linkToFocus.FontWeight = MetroLinkWeight.Regular;
                    }
                    c.Refresh();
                }
            }

            foreach (Control c in metroPanel1.Controls)
            {
                if (link.Tag == c.Tag)
                {
                    c.Visible = true;
                }
                else
                {
                    c.Visible = false;
                }
            }
            Update();
        }

        public void UpdateStyle(int style)
        {
            metroStyleManager1.Style = (MetroColorStyle)style;
            Style = metroStyleManager1.Style;
            metroStyleManager1.Update();
        }
    }
}