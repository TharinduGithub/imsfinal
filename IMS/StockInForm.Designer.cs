namespace IMS
{
    partial class StockInForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SupplierName = new MetroFramework.Controls.MetroTextBox();
            this.SupplierCombo = new MetroFramework.Controls.MetroComboBox();
            this.AllVendors = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ItemInfo = new MetroFramework.Controls.MetroTextBox();
            this.ItemCombo = new MetroFramework.Controls.MetroComboBox();
            this.CategoryCombo = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StockInDate = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.Qty = new MetroFramework.Controls.MetroTextBox();
            this.RecordGrid = new MetroFramework.Controls.MetroGrid();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stInSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.label12 = new System.Windows.Forms.Label();
            this.ProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SearchAll = new MetroFramework.Controls.MetroCheckBox();
            this.CellGrid = new MetroFramework.Controls.MetroGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchByCategoryCombo = new MetroFramework.Controls.MetroComboBox();
            this.SearchBySupplierCombo = new MetroFramework.Controls.MetroComboBox();
            this.SearchByDate = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.forExcel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordGrid)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.SupplierName);
            this.groupBox1.Controls.Add(this.SupplierCombo);
            this.groupBox1.Controls.Add(this.AllVendors);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(278, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor";
            // 
            // SupplierName
            // 
            // 
            // 
            // 
            this.SupplierName.CustomButton.Image = null;
            this.SupplierName.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.SupplierName.CustomButton.Name = "";
            this.SupplierName.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.SupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SupplierName.CustomButton.TabIndex = 1;
            this.SupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SupplierName.CustomButton.UseSelectable = true;
            this.SupplierName.CustomButton.Visible = false;
            this.SupplierName.Enabled = false;
            this.SupplierName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SupplierName.Lines = new string[0];
            this.SupplierName.Location = new System.Drawing.Point(34, 127);
            this.SupplierName.MaxLength = 32767;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.PasswordChar = '\0';
            this.SupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SupplierName.SelectedText = "";
            this.SupplierName.SelectionLength = 0;
            this.SupplierName.SelectionStart = 0;
            this.SupplierName.ShortcutsEnabled = true;
            this.SupplierName.Size = new System.Drawing.Size(210, 28);
            this.SupplierName.TabIndex = 2;
            this.SupplierName.UseSelectable = true;
            this.SupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SupplierName.TextChanged += new System.EventHandler(this.SupplierName_TextChanged);
            // 
            // SupplierCombo
            // 
            this.SupplierCombo.FormattingEnabled = true;
            this.SupplierCombo.ItemHeight = 23;
            this.SupplierCombo.Items.AddRange(new object[] {
            "Select Supplier"});
            this.SupplierCombo.Location = new System.Drawing.Point(34, 81);
            this.SupplierCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SupplierCombo.Name = "SupplierCombo";
            this.SupplierCombo.Size = new System.Drawing.Size(211, 29);
            this.SupplierCombo.TabIndex = 1;
            this.SupplierCombo.UseSelectable = true;
            this.SupplierCombo.SelectedIndexChanged += new System.EventHandler(this.SupplierCombo_SelectedIndexChanged);
            // 
            // AllVendors
            // 
            this.AllVendors.FormattingEnabled = true;
            this.AllVendors.ItemHeight = 23;
            this.AllVendors.Location = new System.Drawing.Point(34, 33);
            this.AllVendors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllVendors.Name = "AllVendors";
            this.AllVendors.Size = new System.Drawing.Size(211, 29);
            this.AllVendors.TabIndex = 0;
            this.AllVendors.UseSelectable = true;
            this.AllVendors.SelectedIndexChanged += new System.EventHandler(this.AllVendors_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.ItemInfo);
            this.groupBox2.Controls.Add(this.ItemCombo);
            this.groupBox2.Controls.Add(this.CategoryCombo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(278, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // ItemInfo
            // 
            // 
            // 
            // 
            this.ItemInfo.CustomButton.Image = null;
            this.ItemInfo.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.ItemInfo.CustomButton.Name = "";
            this.ItemInfo.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.ItemInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ItemInfo.CustomButton.TabIndex = 1;
            this.ItemInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ItemInfo.CustomButton.UseSelectable = true;
            this.ItemInfo.CustomButton.Visible = false;
            this.ItemInfo.Enabled = false;
            this.ItemInfo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ItemInfo.Lines = new string[0];
            this.ItemInfo.Location = new System.Drawing.Point(34, 124);
            this.ItemInfo.MaxLength = 32767;
            this.ItemInfo.Name = "ItemInfo";
            this.ItemInfo.PasswordChar = '\0';
            this.ItemInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemInfo.SelectedText = "";
            this.ItemInfo.SelectionLength = 0;
            this.ItemInfo.SelectionStart = 0;
            this.ItemInfo.ShortcutsEnabled = true;
            this.ItemInfo.Size = new System.Drawing.Size(210, 28);
            this.ItemInfo.TabIndex = 4;
            this.ItemInfo.UseSelectable = true;
            this.ItemInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ItemInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ItemCombo
            // 
            this.ItemCombo.DropDownHeight = 200;
            this.ItemCombo.FormattingEnabled = true;
            this.ItemCombo.IntegralHeight = false;
            this.ItemCombo.ItemHeight = 23;
            this.ItemCombo.Location = new System.Drawing.Point(34, 77);
            this.ItemCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemCombo.Name = "ItemCombo";
            this.ItemCombo.Size = new System.Drawing.Size(211, 29);
            this.ItemCombo.TabIndex = 3;
            this.ItemCombo.UseSelectable = true;
            this.ItemCombo.SelectedIndexChanged += new System.EventHandler(this.ItemCombo_SelectedIndexChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.ItemHeight = 23;
            this.CategoryCombo.Location = new System.Drawing.Point(34, 30);
            this.CategoryCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(211, 29);
            this.CategoryCombo.TabIndex = 2;
            this.CategoryCombo.UseSelectable = true;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Date";
            // 
            // StockInDate
            // 
            this.StockInDate.Location = new System.Drawing.Point(93, 52);
            this.StockInDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StockInDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StockInDate.Name = "StockInDate";
            this.StockInDate.Size = new System.Drawing.Size(202, 30);
            this.StockInDate.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(20, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "Quntity";
            // 
            // Qty
            // 
            // 
            // 
            // 
            this.Qty.CustomButton.Image = null;
            this.Qty.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.Qty.CustomButton.Name = "";
            this.Qty.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Qty.CustomButton.TabIndex = 1;
            this.Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Qty.CustomButton.UseSelectable = true;
            this.Qty.CustomButton.Visible = false;
            this.Qty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Qty.Lines = new string[0];
            this.Qty.Location = new System.Drawing.Point(94, 471);
            this.Qty.MaxLength = 32767;
            this.Qty.Name = "Qty";
            this.Qty.PasswordChar = '\0';
            this.Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Qty.SelectedText = "";
            this.Qty.SelectionLength = 0;
            this.Qty.SelectionStart = 0;
            this.Qty.ShortcutsEnabled = true;
            this.Qty.Size = new System.Drawing.Size(201, 28);
            this.Qty.TabIndex = 68;
            this.Qty.UseSelectable = true;
            this.Qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_KeyPress);
            // 
            // RecordGrid
            // 
            this.RecordGrid.AllowUserToResizeRows = false;
            this.RecordGrid.BackgroundColor = System.Drawing.Color.White;
            this.RecordGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RecordGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RecordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.itemName,
            this.quntity,
            this.stInDate,
            this.stInSupplier});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecordGrid.EnableHeadersVisualStyles = false;
            this.RecordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RecordGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.RecordGrid.Location = new System.Drawing.Point(319, 14);
            this.RecordGrid.Name = "RecordGrid";
            this.RecordGrid.ReadOnly = true;
            this.RecordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RecordGrid.RowHeadersVisible = false;
            this.RecordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RecordGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordGrid.Size = new System.Drawing.Size(375, 451);
            this.RecordGrid.TabIndex = 69;
            this.RecordGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordGrid_CellClick);
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "Item Code";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 173;
            // 
            // quntity
            // 
            this.quntity.HeaderText = "Quntity";
            this.quntity.Name = "quntity";
            this.quntity.ReadOnly = true;
            this.quntity.Width = 150;
            // 
            // stInDate
            // 
            this.stInDate.HeaderText = "StInDate";
            this.stInDate.Name = "stInDate";
            this.stInDate.ReadOnly = true;
            this.stInDate.Visible = false;
            // 
            // stInSupplier
            // 
            this.stInSupplier.HeaderText = "StInSupplier";
            this.stInSupplier.Name = "stInSupplier";
            this.stInSupplier.ReadOnly = true;
            this.stInSupplier.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(28, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(80, 25);
            this.Title.TabIndex = 70;
            this.Title.Text = "Stock In";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(22, 63);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(709, 592);
            this.metroTabControl1.TabIndex = 72;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage1.Controls.Add(this.Spinner);
            this.metroTabPage1.Controls.Add(this.BtnAdd);
            this.metroTabPage1.Controls.Add(this.Process);
            this.metroTabPage1.Controls.Add(this.RecordGrid);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.Controls.Add(this.Qty);
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.BtnDelete);
            this.metroTabPage1.Controls.Add(this.StockInDate);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(701, 550);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "New Stock In ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(664, 502);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(25, 25);
            this.Spinner.Speed = 3F;
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 73;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 30;
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
            this.BtnAdd.Location = new System.Drawing.Point(198, 514);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 35);
            this.BtnAdd.TabIndex = 72;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.Process.Image = global::IMS.Properties.Resources.icons8_Export_24px;
            this.Process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Process.Location = new System.Drawing.Point(477, 497);
            this.Process.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(182, 35);
            this.Process.TabIndex = 71;
            this.Process.Text = "Proccess This Stock";
            this.Process.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Process.UseVisualStyleBackColor = false;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDelete.Image = global::IMS.Properties.Resources.icons8_Delete_File_24px1;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(90, 514);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 35);
            this.BtnDelete.TabIndex = 64;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.ExportSpinner);
            this.metroTabPage2.Controls.Add(this.label12);
            this.metroTabPage2.Controls.Add(this.ProgressSpinner);
            this.metroTabPage2.Controls.Add(this.SearchAll);
            this.metroTabPage2.Controls.Add(this.CellGrid);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.Controls.Add(this.SearchByDate);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.Delete);
            this.metroTabPage2.Controls.Add(this.forExcel);
            this.metroTabPage2.Controls.Add(this.BtnPrint);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(701, 550);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "  Search Stock Ins";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(641, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 40);
            this.panel1.TabIndex = 92;
            // 
            // ExportSpinner
            // 
            this.ExportSpinner.Location = new System.Drawing.Point(545, 134);
            this.ExportSpinner.Maximum = 100;
            this.ExportSpinner.Name = "ExportSpinner";
            this.ExportSpinner.Size = new System.Drawing.Size(16, 16);
            this.ExportSpinner.Speed = 2F;
            this.ExportSpinner.Spinning = false;
            this.ExportSpinner.TabIndex = 91;
            this.ExportSpinner.UseSelectable = true;
            this.ExportSpinner.Value = 40;
            this.ExportSpinner.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(525, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Export For ...";
            // 
            // ProgressSpinner
            // 
            this.ProgressSpinner.Location = new System.Drawing.Point(325, 317);
            this.ProgressSpinner.Maximum = 100;
            this.ProgressSpinner.Name = "ProgressSpinner";
            this.ProgressSpinner.Size = new System.Drawing.Size(50, 50);
            this.ProgressSpinner.Spinning = false;
            this.ProgressSpinner.TabIndex = 87;
            this.ProgressSpinner.UseSelectable = true;
            this.ProgressSpinner.Value = 35;
            this.ProgressSpinner.Visible = false;
            // 
            // SearchAll
            // 
            this.SearchAll.AutoSize = true;
            this.SearchAll.Location = new System.Drawing.Point(655, 37);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(37, 15);
            this.SearchAll.TabIndex = 86;
            this.SearchAll.Text = "All";
            this.SearchAll.UseSelectable = true;
            this.SearchAll.CheckedChanged += new System.EventHandler(this.SearchAll_CheckedChanged);
            // 
            // CellGrid
            // 
            this.CellGrid.AllowUserToResizeRows = false;
            this.CellGrid.BackgroundColor = System.Drawing.Color.White;
            this.CellGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CellGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CellGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CellGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CellGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.CellGrid.EnableHeadersVisualStyles = false;
            this.CellGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CellGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CellGrid.Location = new System.Drawing.Point(9, 164);
            this.CellGrid.Name = "CellGrid";
            this.CellGrid.ReadOnly = true;
            this.CellGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CellGrid.RowHeadersVisible = false;
            this.CellGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CellGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CellGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CellGrid.Size = new System.Drawing.Size(683, 347);
            this.CellGrid.TabIndex = 85;
            this.CellGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellGrid_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SearchByCategoryCombo);
            this.groupBox3.Controls.Add(this.SearchBySupplierCombo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Location = new System.Drawing.Point(9, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(462, 85);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By ...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(233, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 69;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 68;
            this.label4.Text = "Supplier";
            // 
            // SearchByCategoryCombo
            // 
            this.SearchByCategoryCombo.FormattingEnabled = true;
            this.SearchByCategoryCombo.ItemHeight = 23;
            this.SearchByCategoryCombo.Location = new System.Drawing.Point(236, 40);
            this.SearchByCategoryCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchByCategoryCombo.Name = "SearchByCategoryCombo";
            this.SearchByCategoryCombo.Size = new System.Drawing.Size(211, 29);
            this.SearchByCategoryCombo.TabIndex = 1;
            this.SearchByCategoryCombo.UseSelectable = true;
            this.SearchByCategoryCombo.SelectedIndexChanged += new System.EventHandler(this.SearchByCategoryCombo_SelectedIndexChanged);
            // 
            // SearchBySupplierCombo
            // 
            this.SearchBySupplierCombo.FormattingEnabled = true;
            this.SearchBySupplierCombo.ItemHeight = 23;
            this.SearchBySupplierCombo.Location = new System.Drawing.Point(16, 40);
            this.SearchBySupplierCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBySupplierCombo.Name = "SearchBySupplierCombo";
            this.SearchBySupplierCombo.Size = new System.Drawing.Size(211, 29);
            this.SearchBySupplierCombo.TabIndex = 0;
            this.SearchBySupplierCombo.UseSelectable = true;
            this.SearchBySupplierCombo.SelectedIndexChanged += new System.EventHandler(this.SearchBySupplierCombo_SelectedIndexChanged);
            // 
            // SearchByDate
            // 
            this.SearchByDate.Location = new System.Drawing.Point(95, 30);
            this.SearchByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchByDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(202, 29);
            this.SearchByDate.TabIndex = 83;
            this.SearchByDate.ValueChanged += new System.EventHandler(this.SearchByDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "Select Date";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.White;
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
            this.Delete.Location = new System.Drawing.Point(598, 516);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 35);
            this.Delete.TabIndex = 93;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // forExcel
            // 
            this.forExcel.BackColor = System.Drawing.Color.White;
            this.forExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.forExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.forExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.forExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.forExcel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.forExcel.Image = global::IMS.Properties.Resources.icons8_Microsoft_Excel;
            this.forExcel.Location = new System.Drawing.Point(594, 114);
            this.forExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forExcel.Name = "forExcel";
            this.forExcel.Size = new System.Drawing.Size(40, 40);
            this.forExcel.TabIndex = 89;
            this.forExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.forExcel.UseVisualStyleBackColor = false;
            this.forExcel.Click += new System.EventHandler(this.forExcel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.White;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPrint.Image = global::IMS.Properties.Resources.icons8_Print1;
            this.BtnPrint.Location = new System.Drawing.Point(649, 114);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(40, 40);
            this.BtnPrint.TabIndex = 88;
            this.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 675);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockInForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.StockInForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordGrid)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox AllVendors;
        private MetroFramework.Controls.MetroComboBox SupplierCombo;
        private MetroFramework.Controls.MetroComboBox ItemCombo;
        private MetroFramework.Controls.MetroComboBox CategoryCombo;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime StockInDate;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox Qty;
        private MetroFramework.Controls.MetroGrid RecordGrid;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Process;
        private MetroFramework.Controls.MetroTextBox SupplierName;
        private MetroFramework.Controls.MetroTextBox ItemInfo;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button BtnAdd;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroProgressSpinner ExportSpinner;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button forExcel;
        private System.Windows.Forms.Button BtnPrint;
        private MetroFramework.Controls.MetroProgressSpinner ProgressSpinner;
        private MetroFramework.Controls.MetroCheckBox SearchAll;
        private MetroFramework.Controls.MetroGrid CellGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox SearchByCategoryCombo;
        private MetroFramework.Controls.MetroComboBox SearchBySupplierCombo;
        private MetroFramework.Controls.MetroDateTime SearchByDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stInSupplier;
    }
}