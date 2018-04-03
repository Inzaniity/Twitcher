namespace Twitcher
{
    partial class Form1
    {
        protected MetroFramework.Controls.MetroTextBox txtBoxSong;

        private System.Windows.Forms.DataGridViewButtonColumn Action;

        private MetroFramework.Controls.MetroButton btnSendChat;

        private MetroFramework.Controls.MetroButton btnSong;

        private MetroFramework.Controls.MetroButton button1;

        private MetroFramework.Controls.MetroButton button2;

        private MetroFramework.Controls.MetroComboBox comboBoxUserLevel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;

        private MetroFramework.Controls.MetroButton metroButton3;

        private MetroFramework.Controls.MetroGrid metroGrid1;

        private MetroFramework.Controls.MetroLabel metroLabel5;

        private MetroFramework.Controls.MetroLabel metroLabel6;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        private MetroFramework.Controls.MetroTabControl metroTabControl2;

        private MetroFramework.Controls.MetroTabControl metroTabControl3;

        private MetroFramework.Controls.MetroTabPage metroTabPage1;

        private MetroFramework.Controls.MetroTabPage metroTabPage2;

        private MetroFramework.Controls.MetroTabPage metroTabPage3;

        private MetroFramework.Controls.MetroTabPage metroTabPage4;

        private MetroFramework.Controls.MetroTabPage metroTabPage5;

        private MetroFramework.Controls.MetroTabPage metroTabPage6;

        private MetroFramework.Controls.MetroTabPage metroTabPage7;

        private MetroFramework.Controls.MetroTabPage metroTabPage8;

        private MetroFramework.Controls.MetroToggle metroToggle2;

        private MetroFramework.Components.MetroToolTip metroToolTip1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnText;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Trigger;

        private MetroFramework.Controls.MetroTextBox txtBoxChatMsg;

        private MetroFramework.Controls.MetroTextBox txtBoxCommandReturnText;

        private MetroFramework.Controls.MetroTextBox txtBoxCommandTrigger;

        private System.Windows.Forms.DataGridViewTextBoxColumn Userlevel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Connection");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Prebuild");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Custom");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Timer");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Commands", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Appearance");
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSendChat = new MetroFramework.Controls.MetroButton();
            this.txtBoxChatMsg = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl3 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.btnSong = new MetroFramework.Controls.MetroButton();
            this.txtBoxSong = new MetroFramework.Controls.MetroTextBox();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.comboBoxUserLevel = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxCommandReturnText = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxCommandTrigger = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trigger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.metroTabControl3.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(665, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.richTextBox1, true);
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(801, 348);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(751, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Disconnect";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(815, 446);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.Controls.Add(this.btnSendChat);
            this.metroTabPage1.Controls.Add(this.txtBoxChatMsg);
            this.metroTabPage1.Controls.Add(this.richTextBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(807, 398);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "   Chat   ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(729, 357);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(75, 38);
            this.btnSendChat.TabIndex = 3;
            this.btnSendChat.Text = "Chat";
            this.btnSendChat.UseSelectable = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // txtBoxChatMsg
            // 
            // 
            // 
            // 
            this.txtBoxChatMsg.CustomButton.Image = null;
            this.txtBoxChatMsg.CustomButton.Location = new System.Drawing.Point(684, 2);
            this.txtBoxChatMsg.CustomButton.Name = "";
            this.txtBoxChatMsg.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtBoxChatMsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxChatMsg.CustomButton.TabIndex = 1;
            this.txtBoxChatMsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxChatMsg.CustomButton.UseSelectable = true;
            this.txtBoxChatMsg.CustomButton.Visible = false;
            this.txtBoxChatMsg.Lines = new string[0];
            this.txtBoxChatMsg.Location = new System.Drawing.Point(3, 357);
            this.txtBoxChatMsg.MaxLength = 32767;
            this.txtBoxChatMsg.Multiline = true;
            this.txtBoxChatMsg.Name = "txtBoxChatMsg";
            this.txtBoxChatMsg.PasswordChar = '\0';
            this.txtBoxChatMsg.PromptText = "Click here to chat!";
            this.txtBoxChatMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxChatMsg.SelectedText = "";
            this.txtBoxChatMsg.SelectionLength = 0;
            this.txtBoxChatMsg.SelectionStart = 0;
            this.txtBoxChatMsg.ShortcutsEnabled = true;
            this.txtBoxChatMsg.Size = new System.Drawing.Size(720, 38);
            this.txtBoxChatMsg.TabIndex = 2;
            this.txtBoxChatMsg.UseSelectable = true;
            this.txtBoxChatMsg.UseStyleColors = true;
            this.txtBoxChatMsg.WaterMark = "Click here to chat!";
            this.txtBoxChatMsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxChatMsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxChatMsg.Click += new System.EventHandler(this.txtBoxChatMsg_Click);
            this.txtBoxChatMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxChatMsg_KeyDown);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel1);
            this.metroTabPage2.Controls.Add(this.treeView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(807, 398);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "   Settings   ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(117, 21);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(690, 374);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl2.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl2.ItemSize = new System.Drawing.Size(150, 34);
            this.metroTabControl2.Location = new System.Drawing.Point(844, 114);
            this.metroTabControl2.Multiline = true;
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 2;
            this.metroTabControl2.Size = new System.Drawing.Size(690, 388);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.UseStyleColors = true;
            this.metroTabControl2.Visible = false;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(682, 346);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "   Connection   ";
            this.metroTabPage3.UseVisualStyleBackColor = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(682, 346);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "   Appearance   ";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage5.Controls.Add(this.metroTabControl3);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(682, 346);
            this.metroTabPage5.TabIndex = 2;
            this.metroTabPage5.Text = "   Commands   ";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabControl3
            // 
            this.metroTabControl3.Controls.Add(this.metroTabPage6);
            this.metroTabControl3.Controls.Add(this.metroTabPage7);
            this.metroTabControl3.Controls.Add(this.metroTabPage8);
            this.metroTabControl3.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl3.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl3.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl3.Name = "metroTabControl3";
            this.metroTabControl3.SelectedIndex = 1;
            this.metroTabControl3.Size = new System.Drawing.Size(676, 354);
            this.metroTabControl3.TabIndex = 2;
            this.metroTabControl3.UseSelectable = true;
            this.metroTabControl3.UseStyleColors = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage6.Controls.Add(this.btnSong);
            this.metroTabPage6.Controls.Add(this.txtBoxSong);
            this.metroTabPage6.Controls.Add(this.metroToggle2);
            this.metroTabPage6.Controls.Add(this.metroLabel5);
            this.metroTabPage6.ForeColor = System.Drawing.Color.Black;
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(668, 312);
            this.metroTabPage6.TabIndex = 0;
            this.metroTabPage6.Text = "Prebuild";
            this.metroTabPage6.VerticalScrollbar = true;
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(295, 37);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(24, 22);
            this.btnSong.TabIndex = 15;
            this.btnSong.Text = "...";
            this.btnSong.UseSelectable = true;
            this.btnSong.UseStyleColors = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // txtBoxSong
            // 
            // 
            // 
            // 
            this.txtBoxSong.CustomButton.Image = null;
            this.txtBoxSong.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtBoxSong.CustomButton.Name = "";
            this.txtBoxSong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSong.CustomButton.TabIndex = 1;
            this.txtBoxSong.CustomButton.Text = "...";
            this.txtBoxSong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSong.CustomButton.UseSelectable = true;
            this.txtBoxSong.CustomButton.Visible = false;
            this.txtBoxSong.Lines = new string[0];
            this.txtBoxSong.Location = new System.Drawing.Point(12, 37);
            this.txtBoxSong.MaxLength = 32767;
            this.txtBoxSong.Name = "txtBoxSong";
            this.txtBoxSong.PasswordChar = '\0';
            this.txtBoxSong.ReadOnly = true;
            this.txtBoxSong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSong.SelectedText = "";
            this.txtBoxSong.SelectionLength = 0;
            this.txtBoxSong.SelectionStart = 0;
            this.txtBoxSong.ShortcutsEnabled = true;
            this.txtBoxSong.Size = new System.Drawing.Size(277, 23);
            this.txtBoxSong.TabIndex = 14;
            this.txtBoxSong.UseSelectable = true;
            this.txtBoxSong.UseStyleColors = true;
            this.txtBoxSong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroToggle2
            // 
            this.metroToggle2.DisplayStatus = false;
            this.metroToggle2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroToggle2.Location = new System.Drawing.Point(57, 13);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(35, 16);
            this.metroToggle2.TabIndex = 13;
            this.metroToggle2.Text = "Aus";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.UseStyleColors = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.metroToggle2_CheckedChanged_1);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Song";
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.AutoScroll = true;
            this.metroTabPage7.Controls.Add(this.metroButton3);
            this.metroTabPage7.Controls.Add(this.comboBoxUserLevel);
            this.metroTabPage7.Controls.Add(this.txtBoxCommandReturnText);
            this.metroTabPage7.Controls.Add(this.txtBoxCommandTrigger);
            this.metroTabPage7.Controls.Add(this.metroGrid1);
            this.metroTabPage7.Controls.Add(this.metroLabel6);
            this.metroTabPage7.HorizontalScrollbar = true;
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(668, 312);
            this.metroTabPage7.TabIndex = 1;
            this.metroTabPage7.Text = "Custom";
            this.metroTabPage7.VerticalScrollbar = true;
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(551, 42);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(114, 29);
            this.metroButton3.TabIndex = 18;
            this.metroButton3.Text = "Add Command";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // comboBoxUserLevel
            // 
            this.comboBoxUserLevel.FormattingEnabled = true;
            this.comboBoxUserLevel.ItemHeight = 23;
            this.comboBoxUserLevel.Items.AddRange(new object[] {
            "Everyone",
            "Regular",
            "Subscriber",
            "Moderator",
            "Owner"});
            this.comboBoxUserLevel.Location = new System.Drawing.Point(424, 42);
            this.comboBoxUserLevel.Name = "comboBoxUserLevel";
            this.comboBoxUserLevel.Size = new System.Drawing.Size(121, 29);
            this.comboBoxUserLevel.TabIndex = 17;
            this.comboBoxUserLevel.UseSelectable = true;
            this.comboBoxUserLevel.UseStyleColors = true;
            // 
            // txtBoxCommandReturnText
            // 
            // 
            // 
            // 
            this.txtBoxCommandReturnText.CustomButton.Image = null;
            this.txtBoxCommandReturnText.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.txtBoxCommandReturnText.CustomButton.Name = "";
            this.txtBoxCommandReturnText.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBoxCommandReturnText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxCommandReturnText.CustomButton.TabIndex = 1;
            this.txtBoxCommandReturnText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxCommandReturnText.CustomButton.UseSelectable = true;
            this.txtBoxCommandReturnText.CustomButton.Visible = false;
            this.txtBoxCommandReturnText.Icon = ((System.Drawing.Image)(resources.GetObject("txtBoxCommandReturnText.Icon")));
            this.txtBoxCommandReturnText.Lines = new string[0];
            this.txtBoxCommandReturnText.Location = new System.Drawing.Point(80, 42);
            this.txtBoxCommandReturnText.MaxLength = 32767;
            this.txtBoxCommandReturnText.Name = "txtBoxCommandReturnText";
            this.txtBoxCommandReturnText.PasswordChar = '\0';
            this.txtBoxCommandReturnText.PromptText = "Return Text";
            this.txtBoxCommandReturnText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxCommandReturnText.SelectedText = "";
            this.txtBoxCommandReturnText.SelectionLength = 0;
            this.txtBoxCommandReturnText.SelectionStart = 0;
            this.txtBoxCommandReturnText.ShortcutsEnabled = true;
            this.txtBoxCommandReturnText.Size = new System.Drawing.Size(338, 29);
            this.txtBoxCommandReturnText.TabIndex = 16;
            this.metroToolTip1.SetToolTip(this.txtBoxCommandReturnText, "Use {sender} to mention the \r\nsender of the message\r\nand {target} to mention the " +
        "\r\nfirst name after the command");
            this.txtBoxCommandReturnText.UseSelectable = true;
            this.txtBoxCommandReturnText.UseStyleColors = true;
            this.txtBoxCommandReturnText.WaterMark = "Return Text";
            this.txtBoxCommandReturnText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxCommandReturnText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxCommandTrigger
            // 
            // 
            // 
            // 
            this.txtBoxCommandTrigger.CustomButton.Image = null;
            this.txtBoxCommandTrigger.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.txtBoxCommandTrigger.CustomButton.Name = "";
            this.txtBoxCommandTrigger.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBoxCommandTrigger.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxCommandTrigger.CustomButton.TabIndex = 1;
            this.txtBoxCommandTrigger.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxCommandTrigger.CustomButton.UseSelectable = true;
            this.txtBoxCommandTrigger.CustomButton.Visible = false;
            this.txtBoxCommandTrigger.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBoxCommandTrigger.Lines = new string[0];
            this.txtBoxCommandTrigger.Location = new System.Drawing.Point(3, 42);
            this.txtBoxCommandTrigger.MaxLength = 32767;
            this.txtBoxCommandTrigger.Name = "txtBoxCommandTrigger";
            this.txtBoxCommandTrigger.PasswordChar = '\0';
            this.txtBoxCommandTrigger.PromptText = "!command";
            this.txtBoxCommandTrigger.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxCommandTrigger.SelectedText = "";
            this.txtBoxCommandTrigger.SelectionLength = 0;
            this.txtBoxCommandTrigger.SelectionStart = 0;
            this.txtBoxCommandTrigger.ShortcutsEnabled = true;
            this.txtBoxCommandTrigger.Size = new System.Drawing.Size(71, 29);
            this.txtBoxCommandTrigger.TabIndex = 15;
            this.txtBoxCommandTrigger.UseSelectable = true;
            this.txtBoxCommandTrigger.UseStyleColors = true;
            this.txtBoxCommandTrigger.WaterMark = "!command";
            this.txtBoxCommandTrigger.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxCommandTrigger.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Trigger,
            this.ReturnText,
            this.Userlevel,
            this.Action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.HighLightPercentage = 0.1F;
            this.metroGrid1.Location = new System.Drawing.Point(3, 77);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.ShowEditingIcon = false;
            this.metroGrid1.Size = new System.Drawing.Size(662, 226);
            this.metroGrid1.TabIndex = 14;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.metroGrid1_CellPainting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 41;
            // 
            // Trigger
            // 
            this.Trigger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trigger.HeaderText = "Trigger";
            this.Trigger.Name = "Trigger";
            this.Trigger.ReadOnly = true;
            // 
            // ReturnText
            // 
            this.ReturnText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReturnText.HeaderText = "ReturnText";
            this.ReturnText.Name = "ReturnText";
            this.ReturnText.ReadOnly = true;
            // 
            // Userlevel
            // 
            this.Userlevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Userlevel.HeaderText = "Userlevel";
            this.Userlevel.Name = "Userlevel";
            this.Userlevel.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 44;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(3, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 26);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Commands";
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(668, 312);
            this.metroTabPage8.TabIndex = 2;
            this.metroTabPage8.Text = "Timers";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // treeView1
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.treeView1, true);
            this.treeView1.Location = new System.Drawing.Point(3, 21);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeCon";
            treeNode1.Tag = "cs";
            treeNode1.Text = "Connection";
            treeNode2.Name = "NodeCmdPreBuild";
            treeNode2.Tag = "pb";
            treeNode2.Text = "Prebuild";
            treeNode3.Name = "NodeCmdCustom";
            treeNode3.Tag = "cc";
            treeNode3.Text = "Custom";
            treeNode4.Name = "NodeCmdTimer";
            treeNode4.Text = "Timer";
            treeNode5.Name = "NodeCmd";
            treeNode5.Text = "Commands";
            treeNode6.Name = "NodeDesign";
            treeNode6.Tag = "ds";
            treeNode6.Text = "Appearance";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(108, 374);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // toolStrip1
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.toolStrip1, true);
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(20, 512);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(822, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.metroToolTip1.SetToolTip(this.toolStrip1, "This is a single line log which displays information like \"Connected to #Channel\"" +
        "");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 557);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(862, 557);
            this.Name = "Form1";
            this.Style = this.metroStyleManager1.Style;
            this.Text = "Twitcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabControl3.ResumeLayout(false);
            this.metroTabPage6.ResumeLayout(false);
            this.metroTabPage6.PerformLayout();
            this.metroTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

