namespace Twitcher
{
    partial class Form1
    {

        private MetroFramework.Controls.MetroButton btnSendChat;

        private MetroFramework.Controls.MetroButton button1;

        private MetroFramework.Controls.MetroButton button2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        private MetroFramework.Controls.MetroTabPage metroTabPage1;

        private MetroFramework.Controls.MetroTabPage metroTabPage2;

        private MetroFramework.Components.MetroToolTip metroToolTip1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private MetroFramework.Controls.MetroTextBox txtBoxChatMsg;

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
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSendChat = new MetroFramework.Controls.MetroButton();
            this.txtBoxChatMsg = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink5 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
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
            this.metroTabPage2.Controls.Add(this.metroLink4);
            this.metroTabPage2.Controls.Add(this.metroLink3);
            this.metroTabPage2.Controls.Add(this.metroLink2);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroLink5);
            this.metroTabPage2.Controls.Add(this.metroLink1);
            this.metroTabPage2.Controls.Add(this.metroPanel1);
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
            // metroLink4
            // 
            this.metroLink4.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink4.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink4.Location = new System.Drawing.Point(3, 225);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(108, 23);
            this.metroLink4.TabIndex = 7;
            this.metroLink4.Text = "   Timers";
            this.metroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink4.UseSelectable = true;
            this.metroLink4.UseStyleColors = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // metroLink3
            // 
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink3.Location = new System.Drawing.Point(3, 191);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(108, 23);
            this.metroLink3.TabIndex = 7;
            this.metroLink3.Tag = "cc";
            this.metroLink3.Text = "   Custom";
            this.metroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.UseStyleColors = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink2.Location = new System.Drawing.Point(3, 157);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(108, 23);
            this.metroLink2.TabIndex = 7;
            this.metroLink2.Tag = "pb";
            this.metroLink2.Text = "   Prebuild";
            this.metroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(3, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 23);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "General";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(3, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 23);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Commands";
            // 
            // metroLink5
            // 
            this.metroLink5.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink5.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink5.Location = new System.Drawing.Point(3, 89);
            this.metroLink5.Name = "metroLink5";
            this.metroLink5.Size = new System.Drawing.Size(108, 23);
            this.metroLink5.TabIndex = 4;
            this.metroLink5.Tag = "ds";
            this.metroLink5.Text = "   Appearance";
            this.metroLink5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink5.UseSelectable = true;
            this.metroLink5.UseStyleColors = true;
            this.metroLink5.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink1.Location = new System.Drawing.Point(3, 55);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(108, 23);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Tag = "cs";
            this.metroLink1.Text = "   Connection";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink5;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

