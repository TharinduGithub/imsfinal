namespace IMS
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.SearchByVendor = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.SupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchByCategory = new System.Windows.Forms.Label();
            this.LableForItemOpStock = new System.Windows.Forms.Label();
            this.LableForReOrderPoint = new System.Windows.Forms.Label();
            this.LableForItemCategory = new System.Windows.Forms.Label();
            this.LableForItemName = new System.Windows.Forms.Label();
            this.LableForItemCode = new System.Windows.Forms.Label();
            this.TVendorMobile = new MetroFramework.Controls.MetroTextBox();
            this.TVendor = new MetroFramework.Controls.MetroComboBox();
            this.TVendorName = new MetroFramework.Controls.MetroTextBox();
            this.TVendorCode = new MetroFramework.Controls.MetroTextBox();
            this.TVendorJoinDate = new MetroFramework.Controls.MetroDateTime();
            this.Title = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByVendor
            // 
            this.SearchByVendor.FormattingEnabled = true;
            this.SearchByVendor.ItemHeight = 23;
            this.SearchByVendor.Items.AddRange(new object[] {
            "Select Category"});
            this.SearchByVendor.Location = new System.Drawing.Point(428, 79);
            this.SearchByVendor.Name = "SearchByVendor";
            this.SearchByVendor.Size = new System.Drawing.Size(463, 29);
            this.SearchByVendor.TabIndex = 41;
            this.SearchByVendor.UseSelectable = true;
            this.SearchByVendor.SelectedIndexChanged += new System.EventHandler(this.SearchByVendor_SelectedIndexChanged);
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
            this.SupplierCode,
            this.SupplierName,
            this._Vendor,
            this.mobile,
            this.joinInDate,
            this.vendorID});
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
            this.metroGrid1.Location = new System.Drawing.Point(428, 125);
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
            this.metroGrid1.Size = new System.Drawing.Size(463, 413);
            this.metroGrid1.TabIndex = 36;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // SupplierCode
            // 
            this.SupplierCode.HeaderText = "Supplier Code";
            this.SupplierCode.Name = "SupplierCode";
            this.SupplierCode.ReadOnly = true;
            this.SupplierCode.Width = 90;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 118;
            // 
            // _Vendor
            // 
            this._Vendor.HeaderText = "Vendor";
            this._Vendor.Name = "_Vendor";
            this._Vendor.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile No";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 90;
            // 
            // joinInDate
            // 
            this.joinInDate.HeaderText = "Join In Date";
            this.joinInDate.Name = "joinInDate";
            this.joinInDate.ReadOnly = true;
            this.joinInDate.Width = 90;
            // 
            // vendorID
            // 
            this.vendorID.HeaderText = "Vendor ID";
            this.vendorID.Name = "vendorID";
            this.vendorID.ReadOnly = true;
            this.vendorID.Width = 5;
            // 
            // SearchByCategory
            // 
            this.SearchByCategory.AutoSize = true;
            this.SearchByCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SearchByCategory.Location = new System.Drawing.Point(424, 56);
            this.SearchByCategory.Name = "SearchByCategory";
            this.SearchByCategory.Size = new System.Drawing.Size(188, 20);
            this.SearchByCategory.TabIndex = 35;
            this.SearchByCategory.Text = "Search Supplier By Vendor ...";
            // 
            // LableForItemOpStock
            // 
            this.LableForItemOpStock.AutoSize = true;
            this.LableForItemOpStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemOpStock.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemOpStock.Location = new System.Drawing.Point(36, 360);
            this.LableForItemOpStock.Name = "LableForItemOpStock";
            this.LableForItemOpStock.Size = new System.Drawing.Size(91, 21);
            this.LableForItemOpStock.TabIndex = 34;
            this.LableForItemOpStock.Text = "Join In Date";
            // 
            // LableForReOrderPoint
            // 
            this.LableForReOrderPoint.AutoSize = true;
            this.LableForReOrderPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForReOrderPoint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForReOrderPoint.Location = new System.Drawing.Point(36, 291);
            this.LableForReOrderPoint.Name = "LableForReOrderPoint";
            this.LableForReOrderPoint.Size = new System.Drawing.Size(58, 21);
            this.LableForReOrderPoint.TabIndex = 33;
            this.LableForReOrderPoint.Text = "Mobile";
            // 
            // LableForItemCategory
            // 
            this.LableForItemCategory.AutoSize = true;
            this.LableForItemCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemCategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemCategory.Location = new System.Drawing.Point(36, 83);
            this.LableForItemCategory.Name = "LableForItemCategory";
            this.LableForItemCategory.Size = new System.Drawing.Size(60, 21);
            this.LableForItemCategory.TabIndex = 32;
            this.LableForItemCategory.Text = "Vendor";
            // 
            // LableForItemName
            // 
            this.LableForItemName.AutoSize = true;
            this.LableForItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemName.Location = new System.Drawing.Point(36, 222);
            this.LableForItemName.Name = "LableForItemName";
            this.LableForItemName.Size = new System.Drawing.Size(114, 21);
            this.LableForItemName.TabIndex = 31;
            this.LableForItemName.Text = "Supplier Name";
            // 
            // LableForItemCode
            // 
            this.LableForItemCode.AutoSize = true;
            this.LableForItemCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableForItemCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LableForItemCode.Location = new System.Drawing.Point(36, 153);
            this.LableForItemCode.Name = "LableForItemCode";
            this.LableForItemCode.Size = new System.Drawing.Size(108, 21);
            this.LableForItemCode.TabIndex = 30;
            this.LableForItemCode.Text = "Supplier Code";
            // 
            // TVendorMobile
            // 
            // 
            // 
            // 
            this.TVendorMobile.CustomButton.Image = null;
            this.TVendorMobile.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TVendorMobile.CustomButton.Name = "";
            this.TVendorMobile.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TVendorMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TVendorMobile.CustomButton.TabIndex = 1;
            this.TVendorMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TVendorMobile.CustomButton.UseSelectable = true;
            this.TVendorMobile.CustomButton.Visible = false;
            this.TVendorMobile.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TVendorMobile.Lines = new string[0];
            this.TVendorMobile.Location = new System.Drawing.Point(183, 287);
            this.TVendorMobile.MaxLength = 32767;
            this.TVendorMobile.Name = "TVendorMobile";
            this.TVendorMobile.PasswordChar = '\0';
            this.TVendorMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TVendorMobile.SelectedText = "";
            this.TVendorMobile.SelectionLength = 0;
            this.TVendorMobile.SelectionStart = 0;
            this.TVendorMobile.ShortcutsEnabled = true;
            this.TVendorMobile.Size = new System.Drawing.Size(190, 28);
            this.TVendorMobile.TabIndex = 28;
            this.TVendorMobile.UseSelectable = true;
            this.TVendorMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TVendorMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TVendorMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVendorMobile_KeyPress);
            // 
            // TVendor
            // 
            this.TVendor.FormattingEnabled = true;
            this.TVendor.ItemHeight = 23;
            this.TVendor.Items.AddRange(new object[] {
            "Select Category"});
            this.TVendor.Location = new System.Drawing.Point(183, 79);
            this.TVendor.Name = "TVendor";
            this.TVendor.Size = new System.Drawing.Size(190, 29);
            this.TVendor.TabIndex = 27;
            this.TVendor.UseSelectable = true;
            this.TVendor.SelectedIndexChanged += new System.EventHandler(this.TVendor_SelectedIndexChanged);
            // 
            // TVendorName
            // 
            // 
            // 
            // 
            this.TVendorName.CustomButton.Image = null;
            this.TVendorName.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TVendorName.CustomButton.Name = "";
            this.TVendorName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TVendorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TVendorName.CustomButton.TabIndex = 1;
            this.TVendorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TVendorName.CustomButton.UseSelectable = true;
            this.TVendorName.CustomButton.Visible = false;
            this.TVendorName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TVendorName.Lines = new string[0];
            this.TVendorName.Location = new System.Drawing.Point(183, 218);
            this.TVendorName.MaxLength = 32767;
            this.TVendorName.Name = "TVendorName";
            this.TVendorName.PasswordChar = '\0';
            this.TVendorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TVendorName.SelectedText = "";
            this.TVendorName.SelectionLength = 0;
            this.TVendorName.SelectionStart = 0;
            this.TVendorName.ShortcutsEnabled = true;
            this.TVendorName.Size = new System.Drawing.Size(190, 28);
            this.TVendorName.TabIndex = 26;
            this.TVendorName.UseSelectable = true;
            this.TVendorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TVendorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TVendorCode
            // 
            // 
            // 
            // 
            this.TVendorCode.CustomButton.Image = null;
            this.TVendorCode.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.TVendorCode.CustomButton.Name = "";
            this.TVendorCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TVendorCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TVendorCode.CustomButton.TabIndex = 1;
            this.TVendorCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TVendorCode.CustomButton.UseSelectable = true;
            this.TVendorCode.CustomButton.Visible = false;
            this.TVendorCode.Enabled = false;
            this.TVendorCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TVendorCode.Lines = new string[0];
            this.TVendorCode.Location = new System.Drawing.Point(183, 149);
            this.TVendorCode.MaxLength = 32767;
            this.TVendorCode.Name = "TVendorCode";
            this.TVendorCode.PasswordChar = '\0';
            this.TVendorCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TVendorCode.SelectedText = "";
            this.TVendorCode.SelectionLength = 0;
            this.TVendorCode.SelectionStart = 0;
            this.TVendorCode.ShortcutsEnabled = true;
            this.TVendorCode.Size = new System.Drawing.Size(190, 28);
            this.TVendorCode.TabIndex = 25;
            this.TVendorCode.UseSelectable = true;
            this.TVendorCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TVendorCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TVendorJoinDate
            // 
            this.TVendorJoinDate.Location = new System.Drawing.Point(183, 356);
            this.TVendorJoinDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.TVendorJoinDate.Name = "TVendorJoinDate";
            this.TVendorJoinDate.Size = new System.Drawing.Size(190, 29);
            this.TVendorJoinDate.TabIndex = 42;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(26, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(90, 25);
            this.Title.TabIndex = 43;
            this.Title.Text = "Suppliers";
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
            this.Save.Location = new System.Drawing.Point(42, 501);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 35);
            this.Save.TabIndex = 67;
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
            this.Delete.Location = new System.Drawing.Point(292, 501);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 35);
            this.Delete.TabIndex = 66;
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
            this.Edit.Location = new System.Drawing.Point(189, 501);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 35);
            this.Edit.TabIndex = 65;
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
            this.New.Location = new System.Drawing.Point(292, 427);
            this.New.Margin = new System.Windows.Forms.Padding(2);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(94, 35);
            this.New.TabIndex = 64;
            this.New.Text = "New";
            this.New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TVendorJoinDate);
            this.Controls.Add(this.SearchByVendor);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.SearchByCategory);
            this.Controls.Add(this.LableForItemOpStock);
            this.Controls.Add(this.LableForReOrderPoint);
            this.Controls.Add(this.LableForItemCategory);
            this.Controls.Add(this.LableForItemName);
            this.Controls.Add(this.LableForItemCode);
            this.Controls.Add(this.TVendorMobile);
            this.Controls.Add(this.TVendor);
            this.Controls.Add(this.TVendorName);
            this.Controls.Add(this.TVendorCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox SearchByVendor;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Label SearchByCategory;
        private System.Windows.Forms.Label LableForItemOpStock;
        private System.Windows.Forms.Label LableForReOrderPoint;
        private System.Windows.Forms.Label LableForItemCategory;
        private System.Windows.Forms.Label LableForItemName;
        private System.Windows.Forms.Label LableForItemCode;
        private MetroFramework.Controls.MetroTextBox TVendorMobile;
        private MetroFramework.Controls.MetroComboBox TVendor;
        private MetroFramework.Controls.MetroTextBox TVendorName;
        private MetroFramework.Controls.MetroTextBox TVendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
        private MetroFramework.Controls.MetroDateTime TVendorJoinDate;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button New;
    }
}