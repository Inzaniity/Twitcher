namespace Twitcher
{
    partial class customCommands
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customCommands));
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.comboBoxUserLevel = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxCommandTrigger = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxCommandReturnText = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trigger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(573, 29);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(114, 29);
            this.metroButton3.TabIndex = 24;
            this.metroButton3.Text = "Add Command";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
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
            this.comboBoxUserLevel.Location = new System.Drawing.Point(446, 29);
            this.comboBoxUserLevel.Name = "comboBoxUserLevel";
            this.comboBoxUserLevel.Size = new System.Drawing.Size(121, 29);
            this.comboBoxUserLevel.TabIndex = 23;
            this.comboBoxUserLevel.UseSelectable = true;
            this.comboBoxUserLevel.UseStyleColors = true;
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
            this.txtBoxCommandTrigger.Location = new System.Drawing.Point(3, 29);
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
            this.txtBoxCommandTrigger.TabIndex = 21;
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
            this.metroGrid1.Location = new System.Drawing.Point(3, 64);
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
            this.metroGrid1.Size = new System.Drawing.Size(684, 322);
            this.metroGrid1.TabIndex = 20;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(3, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 26);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Commands";
            // 
            // txtBoxCommandReturnText
            // 
            // 
            // 
            // 
            this.txtBoxCommandReturnText.CustomButton.Image = null;
            this.txtBoxCommandReturnText.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.txtBoxCommandReturnText.CustomButton.Name = "";
            this.txtBoxCommandReturnText.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBoxCommandReturnText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxCommandReturnText.CustomButton.TabIndex = 1;
            this.txtBoxCommandReturnText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxCommandReturnText.CustomButton.UseSelectable = true;
            this.txtBoxCommandReturnText.CustomButton.Visible = false;
            this.txtBoxCommandReturnText.Icon = ((System.Drawing.Image)(resources.GetObject("txtBoxCommandReturnText.Icon")));
            this.txtBoxCommandReturnText.Lines = new string[0];
            this.txtBoxCommandReturnText.Location = new System.Drawing.Point(80, 29);
            this.txtBoxCommandReturnText.MaxLength = 32767;
            this.txtBoxCommandReturnText.Name = "txtBoxCommandReturnText";
            this.txtBoxCommandReturnText.PasswordChar = '\0';
            this.txtBoxCommandReturnText.PromptText = "Return Text";
            this.txtBoxCommandReturnText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxCommandReturnText.SelectedText = "";
            this.txtBoxCommandReturnText.SelectionLength = 0;
            this.txtBoxCommandReturnText.SelectionStart = 0;
            this.txtBoxCommandReturnText.ShortcutsEnabled = true;
            this.txtBoxCommandReturnText.Size = new System.Drawing.Size(360, 29);
            this.txtBoxCommandReturnText.TabIndex = 22;
            this.metroToolTip1.SetToolTip(this.txtBoxCommandReturnText, "Use {sender} to mention the \r\nsender of the message\r\nand {target} to mention the " +
        "\r\nfirst name after the command.");
            this.txtBoxCommandReturnText.UseSelectable = true;
            this.txtBoxCommandReturnText.UseStyleColors = true;
            this.txtBoxCommandReturnText.WaterMark = "Return Text";
            this.txtBoxCommandReturnText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxCommandReturnText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Action.Width = 44;
            // 
            // customCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.comboBoxUserLevel);
            this.Controls.Add(this.txtBoxCommandReturnText);
            this.Controls.Add(this.txtBoxCommandTrigger);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel6);
            this.Name = "customCommands";
            this.Size = new System.Drawing.Size(690, 389);
            this.Tag = "cc";
            this.Load += new System.EventHandler(this.customCommands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroComboBox comboBoxUserLevel;
        private MetroFramework.Controls.MetroTextBox txtBoxCommandReturnText;
        private MetroFramework.Controls.MetroTextBox txtBoxCommandTrigger;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trigger;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}
