namespace IMS
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.Title = new System.Windows.Forms.Label();
            this.ConSource = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WindowsAuth = new MetroFramework.Controls.MetroCheckBox();
            this.Other = new System.Windows.Forms.GroupBox();
            this.ConShowPass = new MetroFramework.Controls.MetroCheckBox();
            this.ConPwd = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConUid = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Button();
            this.Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(18, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(184, 25);
            this.Title.TabIndex = 45;
            this.Title.Text = "Connection Settings";
            // 
            // ConSource
            // 
            // 
            // 
            // 
            this.ConSource.CustomButton.Image = null;
            this.ConSource.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.ConSource.CustomButton.Name = "";
            this.ConSource.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.ConSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConSource.CustomButton.TabIndex = 1;
            this.ConSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConSource.CustomButton.UseSelectable = true;
            this.ConSource.CustomButton.Visible = false;
            this.ConSource.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ConSource.Lines = new string[0];
            this.ConSource.Location = new System.Drawing.Point(25, 58);
            this.ConSource.MaxLength = 32767;
            this.ConSource.Name = "ConSource";
            this.ConSource.PasswordChar = '\0';
            this.ConSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConSource.SelectedText = "";
            this.ConSource.SelectionLength = 0;
            this.ConSource.SelectionStart = 0;
            this.ConSource.ShortcutsEnabled = true;
            this.ConSource.Size = new System.Drawing.Size(282, 28);
            this.ConSource.TabIndex = 70;
            this.ConSource.UseSelectable = true;
            this.ConSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(22, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Source of the Connection";
            // 
            // WindowsAuth
            // 
            this.WindowsAuth.AutoSize = true;
            this.WindowsAuth.Location = new System.Drawing.Point(52, 74);
            this.WindowsAuth.Name = "WindowsAuth";
            this.WindowsAuth.Size = new System.Drawing.Size(196, 15);
            this.WindowsAuth.TabIndex = 87;
            this.WindowsAuth.Text = "Use My Windows Authentication";
            this.WindowsAuth.UseSelectable = true;
            this.WindowsAuth.CheckedChanged += new System.EventHandler(this.WindowsAuth_CheckedChanged);
            // 
            // Other
            // 
            this.Other.Controls.Add(this.ConShowPass);
            this.Other.Controls.Add(this.ConPwd);
            this.Other.Controls.Add(this.label2);
            this.Other.Controls.Add(this.ConUid);
            this.Other.Controls.Add(this.label1);
            this.Other.Controls.Add(this.ConSource);
            this.Other.Controls.Add(this.label3);
            this.Other.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Other.Location = new System.Drawing.Point(52, 105);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(332, 272);
            this.Other.TabIndex = 88;
            this.Other.TabStop = false;
            this.Other.Text = "Other";
            // 
            // ConShowPass
            // 
            this.ConShowPass.AutoSize = true;
            this.ConShowPass.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ConShowPass.Location = new System.Drawing.Point(25, 227);
            this.ConShowPass.Name = "ConShowPass";
            this.ConShowPass.Size = new System.Drawing.Size(105, 15);
            this.ConShowPass.TabIndex = 89;
            this.ConShowPass.Text = "Show Password";
            this.ConShowPass.UseSelectable = true;
            this.ConShowPass.CheckedChanged += new System.EventHandler(this.ConShowPass_CheckedChanged);
            // 
            // ConPwd
            // 
            // 
            // 
            // 
            this.ConPwd.CustomButton.Image = null;
            this.ConPwd.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.ConPwd.CustomButton.Name = "";
            this.ConPwd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.ConPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConPwd.CustomButton.TabIndex = 1;
            this.ConPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConPwd.CustomButton.UseSelectable = true;
            this.ConPwd.CustomButton.Visible = false;
            this.ConPwd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ConPwd.Lines = new string[0];
            this.ConPwd.Location = new System.Drawing.Point(25, 193);
            this.ConPwd.MaxLength = 32767;
            this.ConPwd.Name = "ConPwd";
            this.ConPwd.PasswordChar = '*';
            this.ConPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConPwd.SelectedText = "";
            this.ConPwd.SelectionLength = 0;
            this.ConPwd.SelectionStart = 0;
            this.ConPwd.ShortcutsEnabled = true;
            this.ConPwd.Size = new System.Drawing.Size(282, 28);
            this.ConPwd.TabIndex = 74;
            this.ConPwd.UseSelectable = true;
            this.ConPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(22, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Connection Password";
            // 
            // ConUid
            // 
            // 
            // 
            // 
            this.ConUid.CustomButton.Image = null;
            this.ConUid.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.ConUid.CustomButton.Name = "";
            this.ConUid.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.ConUid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConUid.CustomButton.TabIndex = 1;
            this.ConUid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConUid.CustomButton.UseSelectable = true;
            this.ConUid.CustomButton.Visible = false;
            this.ConUid.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ConUid.Lines = new string[0];
            this.ConUid.Location = new System.Drawing.Point(25, 127);
            this.ConUid.MaxLength = 32767;
            this.ConUid.Name = "ConUid";
            this.ConUid.PasswordChar = '\0';
            this.ConUid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConUid.SelectedText = "";
            this.ConUid.SelectionLength = 0;
            this.ConUid.SelectionStart = 0;
            this.ConUid.ShortcutsEnabled = true;
            this.ConUid.Size = new System.Drawing.Size(282, 28);
            this.ConUid.TabIndex = 72;
            this.ConUid.UseSelectable = true;
            this.ConUid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConUid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Connection Username";
            // 
            // Process
            // 
            this.Process.BackColor = System.Drawing.Color.White;
            this.Process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Process.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Process.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Process.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Process.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Process.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Process.Image = global::IMS.Properties.Resources.icons8_Check_File_24px_21;
            this.Process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Process.Location = new System.Drawing.Point(223, 393);
            this.Process.Margin = new System.Windows.Forms.Padding(2);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(161, 35);
            this.Process.TabIndex = 89;
            this.Process.Text = "Set Connection";
            this.Process.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Process.UseVisualStyleBackColor = false;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 445);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.WindowsAuth);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Other);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.Other.ResumeLayout(false);
            this.Other.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroTextBox ConSource;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroCheckBox WindowsAuth;
        private System.Windows.Forms.GroupBox Other;
        private MetroFramework.Controls.MetroTextBox ConPwd;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox ConUid;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox ConShowPass;
        private System.Windows.Forms.Button Process;
    }
}