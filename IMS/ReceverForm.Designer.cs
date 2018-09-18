namespace IMS
{
    partial class ReceverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceverForm));
            this.Title = new System.Windows.Forms.Label();
            this.LableForItemOpStock = new System.Windows.Forms.Label();
            this.LableForReOrderPoint = new System.Windows.Forms.Label();
            this.LableForItemName = new System.Windows.Forms.Label();
            this.LableForItemCode = new System.Windows.Forms.Label();
            this.TReceverMobile = new MetroFramework.Controls.MetroTextBox();
            this.TReceverName = new MetroFramework.Controls.MetroTextBox();
            this.TReceverCode = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ReceverCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TReceverDesignasion = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(23, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(87, 25);
            this.Title.TabIndex = 44;
            this.Title.Text = "Recevers";
            // 
            // LableForItemOpStock
            // 
            this.LableForItemOpStock.AutoSize = true;
            this.LableForItemOpStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemOpStock.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemOpStock.Location = new System.Drawing.Point(32, 299);
            this.LableForItemOpStock.Name = "LableForItemOpStock";
            this.LableForItemOpStock.Size = new System.Drawing.Size(93, 21);
            this.LableForItemOpStock.TabIndex = 51;
            this.LableForItemOpStock.Text = "Designation";
            // 
            // LableForReOrderPoint
            // 
            this.LableForReOrderPoint.AutoSize = true;
            this.LableForReOrderPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForReOrderPoint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForReOrderPoint.Location = new System.Drawing.Point(32, 230);
            this.LableForReOrderPoint.Name = "LableForReOrderPoint";
            this.LableForReOrderPoint.Size = new System.Drawing.Size(58, 21);
            this.LableForReOrderPoint.TabIndex = 50;
            this.LableForReOrderPoint.Text = "Mobile";
            // 
            // LableForItemName
            // 
            this.LableForItemName.AutoSize = true;
            this.LableForItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemName.Location = new System.Drawing.Point(32, 161);
            this.LableForItemName.Name = "LableForItemName";
            this.LableForItemName.Size = new System.Drawing.Size(111, 21);
            this.LableForItemName.TabIndex = 49;
            this.LableForItemName.Text = "Recever Name";
            // 
            // LableForItemCode
            // 
            this.LableForItemCode.AutoSize = true;
            this.LableForItemCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemCode.Location = new System.Drawing.Point(32, 92);
            this.LableForItemCode.Name = "LableForItemCode";
            this.LableForItemCode.Size = new System.Drawing.Size(105, 21);
            this.LableForItemCode.TabIndex = 48;
            this.LableForItemCode.Text = "Recever Code";
            // 
            // TReceverMobile
            // 
            // 
            // 
            // 
            this.TReceverMobile.CustomButton.Image = null;
            this.TReceverMobile.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TReceverMobile.CustomButton.Name = "";
            this.TReceverMobile.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TReceverMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TReceverMobile.CustomButton.TabIndex = 1;
            this.TReceverMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TReceverMobile.CustomButton.UseSelectable = true;
            this.TReceverMobile.CustomButton.Visible = false;
            this.TReceverMobile.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TReceverMobile.Lines = new string[0];
            this.TReceverMobile.Location = new System.Drawing.Point(179, 226);
            this.TReceverMobile.MaxLength = 32767;
            this.TReceverMobile.Name = "TReceverMobile";
            this.TReceverMobile.PasswordChar = '\0';
            this.TReceverMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TReceverMobile.SelectedText = "";
            this.TReceverMobile.SelectionLength = 0;
            this.TReceverMobile.SelectionStart = 0;
            this.TReceverMobile.ShortcutsEnabled = true;
            this.TReceverMobile.Size = new System.Drawing.Size(190, 28);
            this.TReceverMobile.TabIndex = 47;
            this.TReceverMobile.UseSelectable = true;
            this.TReceverMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TReceverMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TReceverMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TReceverMobile_KeyPress);
            // 
            // TReceverName
            // 
            // 
            // 
            // 
            this.TReceverName.CustomButton.Image = null;
            this.TReceverName.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TReceverName.CustomButton.Name = "";
            this.TReceverName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TReceverName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TReceverName.CustomButton.TabIndex = 1;
            this.TReceverName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TReceverName.CustomButton.UseSelectable = true;
            this.TReceverName.CustomButton.Visible = false;
            this.TReceverName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TReceverName.Lines = new string[0];
            this.TReceverName.Location = new System.Drawing.Point(179, 157);
            this.TReceverName.MaxLength = 32767;
            this.TReceverName.Name = "TReceverName";
            this.TReceverName.PasswordChar = '\0';
            this.TReceverName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TReceverName.SelectedText = "";
            this.TReceverName.SelectionLength = 0;
            this.TReceverName.SelectionStart = 0;
            this.TReceverName.ShortcutsEnabled = true;
            this.TReceverName.Size = new System.Drawing.Size(190, 28);
            this.TReceverName.TabIndex = 46;
            this.TReceverName.UseSelectable = true;
            this.TReceverName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TReceverName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TReceverCode
            // 
            // 
            // 
            // 
            this.TReceverCode.CustomButton.Image = null;
            this.TReceverCode.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TReceverCode.CustomButton.Name = "";
            this.TReceverCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TReceverCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TReceverCode.CustomButton.TabIndex = 1;
            this.TReceverCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TReceverCode.CustomButton.UseSelectable = true;
            this.TReceverCode.CustomButton.Visible = false;
            this.TReceverCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TReceverCode.Lines = new string[] {
        "R_"};
            this.TReceverCode.Location = new System.Drawing.Point(179, 88);
            this.TReceverCode.MaxLength = 6;
            this.TReceverCode.Name = "TReceverCode";
            this.TReceverCode.PasswordChar = '\0';
            this.TReceverCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TReceverCode.SelectedText = "";
            this.TReceverCode.SelectionLength = 0;
            this.TReceverCode.SelectionStart = 0;
            this.TReceverCode.ShortcutsEnabled = true;
            this.TReceverCode.Size = new System.Drawing.Size(190, 28);
            this.TReceverCode.TabIndex = 45;
            this.TReceverCode.Text = "R_";
            this.TReceverCode.UseSelectable = true;
            this.TReceverCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TReceverCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TReceverCode.TextChanged += new System.EventHandler(this.TReceverCode_TextChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.ReceverCode,
            this.receverName,
            this.mobile,
            this.designation});
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
            this.metroGrid1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.metroGrid1.Location = new System.Drawing.Point(397, 29);
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
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(460, 478);
            this.metroGrid1.TabIndex = 57;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // ReceverCode
            // 
            this.ReceverCode.HeaderText = "Recever Code";
            this.ReceverCode.Name = "ReceverCode";
            this.ReceverCode.ReadOnly = true;
            this.ReceverCode.Width = 115;
            // 
            // receverName
            // 
            this.receverName.HeaderText = "Recever Name";
            this.receverName.Name = "receverName";
            this.receverName.ReadOnly = true;
            this.receverName.Width = 115;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile No";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 115;
            // 
            // designation
            // 
            this.designation.HeaderText = "Designation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 115;
            // 
            // TReceverDesignasion
            // 
            // 
            // 
            // 
            this.TReceverDesignasion.CustomButton.Image = null;
            this.TReceverDesignasion.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TReceverDesignasion.CustomButton.Name = "";
            this.TReceverDesignasion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TReceverDesignasion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TReceverDesignasion.CustomButton.TabIndex = 1;
            this.TReceverDesignasion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TReceverDesignasion.CustomButton.UseSelectable = true;
            this.TReceverDesignasion.CustomButton.Visible = false;
            this.TReceverDesignasion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TReceverDesignasion.Lines = new string[0];
            this.TReceverDesignasion.Location = new System.Drawing.Point(179, 297);
            this.TReceverDesignasion.MaxLength = 32767;
            this.TReceverDesignasion.Name = "TReceverDesignasion";
            this.TReceverDesignasion.PasswordChar = '\0';
            this.TReceverDesignasion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TReceverDesignasion.SelectedText = "";
            this.TReceverDesignasion.SelectionLength = 0;
            this.TReceverDesignasion.SelectionStart = 0;
            this.TReceverDesignasion.ShortcutsEnabled = true;
            this.TReceverDesignasion.Size = new System.Drawing.Size(190, 28);
            this.TReceverDesignasion.TabIndex = 58;
            this.TReceverDesignasion.UseSelectable = true;
            this.TReceverDesignasion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TReceverDesignasion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(179, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 59;
            // 
            // Save
            // 
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Save.Image = global::IMS.Properties.Resources.icons8_Check_File_24px_2;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(36, 457);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 35);
            this.Save.TabIndex = 63;
            this.Save.Text = "Save";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.Delete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete.Image = global::IMS.Properties.Resources.icons8_Delete_File_24px;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(286, 457);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 35);
            this.Delete.TabIndex = 62;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Edit.Image = global::IMS.Properties.Resources.icons8_Edit_File_24px_11;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(183, 457);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 35);
            this.Edit.TabIndex = 61;
            this.Edit.Text = "Update";
            this.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // New
            // 
            this.New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.New.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.New.Image = global::IMS.Properties.Resources.icons8_Add_File_24px;
            this.New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New.Location = new System.Drawing.Point(286, 383);
            this.New.Margin = new System.Windows.Forms.Padding(2);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(94, 35);
            this.New.TabIndex = 60;
            this.New.Text = "New";
            this.New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // ReceverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TReceverDesignasion);
            this.Controls.Add(this.LableForItemOpStock);
            this.Controls.Add(this.LableForReOrderPoint);
            this.Controls.Add(this.LableForItemName);
            this.Controls.Add(this.LableForItemCode);
            this.Controls.Add(this.TReceverMobile);
            this.Controls.Add(this.TReceverName);
            this.Controls.Add(this.TReceverCode);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceverForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.ReceverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LableForItemOpStock;
        private System.Windows.Forms.Label LableForReOrderPoint;
        private System.Windows.Forms.Label LableForItemName;
        private System.Windows.Forms.Label LableForItemCode;
        private MetroFramework.Controls.MetroTextBox TReceverMobile;
        private MetroFramework.Controls.MetroTextBox TReceverName;
        private MetroFramework.Controls.MetroTextBox TReceverCode;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceverCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn receverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private MetroFramework.Controls.MetroTextBox TReceverDesignasion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button New;
    }
}