namespace IMS
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.Title = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.uType = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.uemail = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lNme = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fNme = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new MetroFramework.Controls.MetroTextBox();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(23, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(58, 25);
            this.Title.TabIndex = 45;
            this.Title.Text = "Users";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(28, 73);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(773, 442);
            this.metroTabControl1.TabIndex = 46;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.BtnDelete);
            this.metroTabPage1.Controls.Add(this.metroGrid1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(765, 400);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "All Users";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDelete.Image = global::IMS.Properties.Resources.icons8_Delete_File_24px1;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(669, 365);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 35);
            this.BtnDelete.TabIndex = 65;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fName,
            this.lName,
            this.email,
            this.userType,
            this.userID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 14);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 23;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(767, 336);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.uType);
            this.metroTabPage2.Controls.Add(this.metroCheckBox1);
            this.metroTabPage2.Controls.Add(this.BtnAdd);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.uemail);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.lNme);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.fNme);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.password);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.userName);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(765, 400);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Add User";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // uType
            // 
            // 
            // 
            // 
            this.uType.CustomButton.Image = null;
            this.uType.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.uType.CustomButton.Name = "";
            this.uType.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.uType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uType.CustomButton.TabIndex = 1;
            this.uType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uType.CustomButton.UseSelectable = true;
            this.uType.CustomButton.Visible = false;
            this.uType.Enabled = false;
            this.uType.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.uType.Lines = new string[] {
        "User"};
            this.uType.Location = new System.Drawing.Point(89, 163);
            this.uType.MaxLength = 32767;
            this.uType.Name = "uType";
            this.uType.PasswordChar = '\0';
            this.uType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uType.SelectedText = "";
            this.uType.SelectionLength = 0;
            this.uType.SelectionStart = 0;
            this.uType.ShortcutsEnabled = true;
            this.uType.Size = new System.Drawing.Size(210, 28);
            this.uType.TabIndex = 80;
            this.uType.Text = "User";
            this.uType.UseSelectable = true;
            this.uType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.metroCheckBox1.Location = new System.Drawing.Point(89, 130);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(105, 15);
            this.metroCheckBox1.TabIndex = 79;
            this.metroCheckBox1.Text = "Show Password";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAdd.Image = global::IMS.Properties.Resources.icons8_Add_File_24px1;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(573, 232);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 35);
            this.BtnAdd.TabIndex = 78;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(381, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Email";
            // 
            // uemail
            // 
            // 
            // 
            // 
            this.uemail.CustomButton.Image = null;
            this.uemail.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.uemail.CustomButton.Name = "";
            this.uemail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.uemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uemail.CustomButton.TabIndex = 1;
            this.uemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uemail.CustomButton.UseSelectable = true;
            this.uemail.CustomButton.Visible = false;
            this.uemail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.uemail.Lines = new string[0];
            this.uemail.Location = new System.Drawing.Point(457, 163);
            this.uemail.MaxLength = 32767;
            this.uemail.Name = "uemail";
            this.uemail.PasswordChar = '\0';
            this.uemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uemail.SelectedText = "";
            this.uemail.SelectionLength = 0;
            this.uemail.SelectionStart = 0;
            this.uemail.ShortcutsEnabled = true;
            this.uemail.Size = new System.Drawing.Size(210, 28);
            this.uemail.TabIndex = 76;
            this.uemail.UseSelectable = true;
            this.uemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(381, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "Last Name";
            // 
            // lNme
            // 
            // 
            // 
            // 
            this.lNme.CustomButton.Image = null;
            this.lNme.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.lNme.CustomButton.Name = "";
            this.lNme.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.lNme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lNme.CustomButton.TabIndex = 1;
            this.lNme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lNme.CustomButton.UseSelectable = true;
            this.lNme.CustomButton.Visible = false;
            this.lNme.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lNme.Lines = new string[0];
            this.lNme.Location = new System.Drawing.Point(457, 96);
            this.lNme.MaxLength = 32767;
            this.lNme.Name = "lNme";
            this.lNme.PasswordChar = '\0';
            this.lNme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lNme.SelectedText = "";
            this.lNme.SelectionLength = 0;
            this.lNme.SelectionStart = 0;
            this.lNme.ShortcutsEnabled = true;
            this.lNme.Size = new System.Drawing.Size(210, 28);
            this.lNme.TabIndex = 74;
            this.lNme.UseSelectable = true;
            this.lNme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lNme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(381, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 73;
            this.label5.Text = "First Name";
            // 
            // fNme
            // 
            // 
            // 
            // 
            this.fNme.CustomButton.Image = null;
            this.fNme.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.fNme.CustomButton.Name = "";
            this.fNme.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.fNme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fNme.CustomButton.TabIndex = 1;
            this.fNme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fNme.CustomButton.UseSelectable = true;
            this.fNme.CustomButton.Visible = false;
            this.fNme.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.fNme.Lines = new string[0];
            this.fNme.Location = new System.Drawing.Point(457, 34);
            this.fNme.MaxLength = 32767;
            this.fNme.Name = "fNme";
            this.fNme.PasswordChar = '\0';
            this.fNme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fNme.SelectedText = "";
            this.fNme.SelectionLength = 0;
            this.fNme.SelectionStart = 0;
            this.fNme.ShortcutsEnabled = true;
            this.fNme.Size = new System.Drawing.Size(210, 28);
            this.fNme.TabIndex = 72;
            this.fNme.UseSelectable = true;
            this.fNme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fNme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(18, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "User Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Password";
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(89, 96);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(210, 28);
            this.password.TabIndex = 69;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Username";
            // 
            // userName
            // 
            // 
            // 
            // 
            this.userName.CustomButton.Image = null;
            this.userName.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.userName.CustomButton.Name = "";
            this.userName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userName.CustomButton.TabIndex = 1;
            this.userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userName.CustomButton.UseSelectable = true;
            this.userName.CustomButton.Visible = false;
            this.userName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userName.Lines = new string[0];
            this.userName.Location = new System.Drawing.Point(89, 34);
            this.userName.MaxLength = 32767;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.ShortcutsEnabled = true;
            this.userName.Size = new System.Drawing.Size(210, 28);
            this.userName.TabIndex = 4;
            this.userName.UseSelectable = true;
            this.userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // fName
            // 
            this.fName.HeaderText = "First Name";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            this.fName.Width = 180;
            // 
            // lName
            // 
            this.lName.HeaderText = "Last Name";
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            this.lName.Width = 180;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 230;
            // 
            // userType
            // 
            this.userType.HeaderText = "User Type";
            this.userType.Name = "userType";
            this.userType.ReadOnly = true;
            this.userType.Width = 180;
            // 
            // userID
            // 
            this.userID.HeaderText = "ID";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Visible = false;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 538);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
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
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox userName;
        private MetroFramework.Controls.MetroTextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox lNme;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox fNme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox uemail;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox uType;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
    }
}