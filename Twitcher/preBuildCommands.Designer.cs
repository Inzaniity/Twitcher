namespace Twitcher
{
    partial class preBuildCommands
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
            this.btnSong = new MetroFramework.Controls.MetroButton();
            this.txtBoxSong = new MetroFramework.Controls.MetroTextBox();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(286, 26);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(29, 29);
            this.btnSong.TabIndex = 19;
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
            this.txtBoxSong.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txtBoxSong.CustomButton.Name = "";
            this.txtBoxSong.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBoxSong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSong.CustomButton.TabIndex = 1;
            this.txtBoxSong.CustomButton.Text = "...";
            this.txtBoxSong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSong.CustomButton.UseSelectable = true;
            this.txtBoxSong.CustomButton.Visible = false;
            this.txtBoxSong.Lines = new string[0];
            this.txtBoxSong.Location = new System.Drawing.Point(3, 26);
            this.txtBoxSong.MaxLength = 32767;
            this.txtBoxSong.Name = "txtBoxSong";
            this.txtBoxSong.PasswordChar = '\0';
            this.txtBoxSong.ReadOnly = true;
            this.txtBoxSong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSong.SelectedText = "";
            this.txtBoxSong.SelectionLength = 0;
            this.txtBoxSong.SelectionStart = 0;
            this.txtBoxSong.ShortcutsEnabled = true;
            this.txtBoxSong.Size = new System.Drawing.Size(277, 29);
            this.txtBoxSong.TabIndex = 18;
            this.txtBoxSong.UseSelectable = true;
            this.txtBoxSong.UseStyleColors = true;
            this.txtBoxSong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroToggle2
            // 
            this.metroToggle2.DisplayStatus = false;
            this.metroToggle2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroToggle2.Location = new System.Drawing.Point(48, 2);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(35, 16);
            this.metroToggle2.TabIndex = 17;
            this.metroToggle2.Text = "Aus";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.UseStyleColors = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.metroToggle2_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Song";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // preBuildCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.txtBoxSong);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.metroLabel5);
            this.Name = "preBuildCommands";
            this.Size = new System.Drawing.Size(690, 389);
            this.Tag = "pb";
            this.Load += new System.EventHandler(this.preBuildCommands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSong;
        protected MetroFramework.Controls.MetroTextBox txtBoxSong;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
