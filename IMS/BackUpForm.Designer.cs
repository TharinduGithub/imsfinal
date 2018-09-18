namespace IMS
{
    partial class BackUpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpForm));
            this.Title = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.browsForBackup = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.backuplocation = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.browsForRestore = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.RestoreLocation = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(18, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(159, 25);
            this.Title.TabIndex = 75;
            this.Title.Text = "Backup n Restore";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(541, 207);
            this.metroTabControl1.TabIndex = 76;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.browsForBackup);
            this.metroTabPage1.Controls.Add(this.BtnBackup);
            this.metroTabPage1.Controls.Add(this.backuplocation);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(533, 165);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Backup";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // browsForBackup
            // 
            this.browsForBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsForBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsForBackup.Location = new System.Drawing.Point(442, 55);
            this.browsForBackup.Name = "browsForBackup";
            this.browsForBackup.Size = new System.Drawing.Size(91, 28);
            this.browsForBackup.TabIndex = 70;
            this.browsForBackup.Text = "Brows ...";
            this.browsForBackup.UseVisualStyleBackColor = true;
            this.browsForBackup.Click += new System.EventHandler(this.browsForBackup_Click);
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.White;
            this.BtnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnBackup.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBackup.Image = global::IMS.Properties.Resources.icons8_Database_View_24px;
            this.BtnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBackup.Location = new System.Drawing.Point(436, 119);
            this.BtnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(94, 35);
            this.BtnBackup.TabIndex = 69;
            this.BtnBackup.Text = "Backup";
            this.BtnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBackup.UseVisualStyleBackColor = false;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // backuplocation
            // 
            // 
            // 
            // 
            this.backuplocation.CustomButton.Image = null;
            this.backuplocation.CustomButton.Location = new System.Drawing.Point(403, 2);
            this.backuplocation.CustomButton.Name = "";
            this.backuplocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.backuplocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.backuplocation.CustomButton.TabIndex = 1;
            this.backuplocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backuplocation.CustomButton.UseSelectable = true;
            this.backuplocation.CustomButton.Visible = false;
            this.backuplocation.Enabled = false;
            this.backuplocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.backuplocation.Lines = new string[0];
            this.backuplocation.Location = new System.Drawing.Point(6, 55);
            this.backuplocation.MaxLength = 32767;
            this.backuplocation.Name = "backuplocation";
            this.backuplocation.PasswordChar = '\0';
            this.backuplocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.backuplocation.SelectedText = "";
            this.backuplocation.SelectionLength = 0;
            this.backuplocation.SelectionStart = 0;
            this.backuplocation.ShortcutsEnabled = true;
            this.backuplocation.Size = new System.Drawing.Size(429, 28);
            this.backuplocation.TabIndex = 67;
            this.backuplocation.UseSelectable = true;
            this.backuplocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.backuplocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.backuplocation.TextChanged += new System.EventHandler(this.backuplocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Please Select Location Below";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.browsForRestore);
            this.metroTabPage2.Controls.Add(this.restore);
            this.metroTabPage2.Controls.Add(this.RestoreLocation);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(533, 165);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Restore";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // browsForRestore
            // 
            this.browsForRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsForRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsForRestore.Location = new System.Drawing.Point(442, 55);
            this.browsForRestore.Name = "browsForRestore";
            this.browsForRestore.Size = new System.Drawing.Size(91, 28);
            this.browsForRestore.TabIndex = 73;
            this.browsForRestore.Text = "Brows ...";
            this.browsForRestore.UseVisualStyleBackColor = true;
            this.browsForRestore.Click += new System.EventHandler(this.browsForRestore_Click);
            // 
            // restore
            // 
            this.restore.BackColor = System.Drawing.Color.White;
            this.restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.restore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.restore.Image = global::IMS.Properties.Resources.icons8_Data_Backup_24px;
            this.restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restore.Location = new System.Drawing.Point(436, 119);
            this.restore.Margin = new System.Windows.Forms.Padding(2);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(94, 35);
            this.restore.TabIndex = 72;
            this.restore.Text = "Restore";
            this.restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // RestoreLocation
            // 
            // 
            // 
            // 
            this.RestoreLocation.CustomButton.Image = null;
            this.RestoreLocation.CustomButton.Location = new System.Drawing.Point(403, 2);
            this.RestoreLocation.CustomButton.Name = "";
            this.RestoreLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.RestoreLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RestoreLocation.CustomButton.TabIndex = 1;
            this.RestoreLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RestoreLocation.CustomButton.UseSelectable = true;
            this.RestoreLocation.CustomButton.Visible = false;
            this.RestoreLocation.Enabled = false;
            this.RestoreLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RestoreLocation.Lines = new string[0];
            this.RestoreLocation.Location = new System.Drawing.Point(6, 55);
            this.RestoreLocation.MaxLength = 32767;
            this.RestoreLocation.Name = "RestoreLocation";
            this.RestoreLocation.PasswordChar = '\0';
            this.RestoreLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RestoreLocation.SelectedText = "";
            this.RestoreLocation.SelectionLength = 0;
            this.RestoreLocation.SelectionStart = 0;
            this.RestoreLocation.ShortcutsEnabled = true;
            this.RestoreLocation.Size = new System.Drawing.Size(429, 28);
            this.RestoreLocation.TabIndex = 71;
            this.RestoreLocation.UseSelectable = true;
            this.RestoreLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RestoreLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RestoreLocation.TextChanged += new System.EventHandler(this.RestoreLocation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Please Select Location Below";
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 291);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackUpForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox backuplocation;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.Button restore;
        private MetroFramework.Controls.MetroTextBox RestoreLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browsForBackup;
        private System.Windows.Forms.Button browsForRestore;
    }
}