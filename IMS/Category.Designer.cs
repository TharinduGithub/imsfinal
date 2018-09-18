namespace IMS
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.cat = new MetroFramework.Controls.MetroTextBox();
            this.Title = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noti = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cat
            // 
            // 
            // 
            // 
            this.cat.CustomButton.Image = null;
            this.cat.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.cat.CustomButton.Name = "";
            this.cat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.cat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cat.CustomButton.TabIndex = 1;
            this.cat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cat.CustomButton.UseSelectable = true;
            this.cat.CustomButton.Visible = false;
            this.cat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cat.Lines = new string[0];
            this.cat.Location = new System.Drawing.Point(24, 93);
            this.cat.MaxLength = 32767;
            this.cat.Name = "cat";
            this.cat.PasswordChar = '\0';
            this.cat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cat.SelectedText = "";
            this.cat.SelectionLength = 0;
            this.cat.SelectionStart = 0;
            this.cat.ShortcutsEnabled = true;
            this.cat.Size = new System.Drawing.Size(230, 28);
            this.cat.TabIndex = 0;
            this.cat.UseSelectable = true;
            this.cat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Location = new System.Drawing.Point(19, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "Categories";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(271, 93);
            this.metroTextBox1.MaxLength = 4;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(154, 28);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(267, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code";
            // 
            // noti
            // 
            this.noti.AutoSize = true;
            this.noti.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noti.ForeColor = System.Drawing.Color.Tomato;
            this.noti.Location = new System.Drawing.Point(271, 128);
            this.noti.Name = "noti";
            this.noti.Size = new System.Drawing.Size(0, 13);
            this.noti.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 324);
            this.listBox1.TabIndex = 11;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Save
            // 
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Save.Image = global::IMS.Properties.Resources.icons8_Check_File_24px_2;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(301, 144);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 35);
            this.Save.TabIndex = 52;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.Delete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete.Image = global::IMS.Properties.Resources.icons8_Delete_File_24px;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(301, 258);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 35);
            this.Delete.TabIndex = 51;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Edit.Image = global::IMS.Properties.Resources.icons8_Edit_File_24px_11;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(301, 201);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 35);
            this.Edit.TabIndex = 50;
            this.Edit.Text = "Update";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // New
            // 
            this.New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.New.FlatAppearance.BorderSize = 0;
            this.New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.New.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.New.Image = global::IMS.Properties.Resources.icons8_Add_File_24px;
            this.New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New.Location = new System.Drawing.Point(301, 352);
            this.New.Margin = new System.Windows.Forms.Padding(2);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(94, 35);
            this.New.TabIndex = 49;
            this.New.Text = "New";
            this.New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 503);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.noti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.cat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Category";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox cat;
        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noti;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button New;
    }
}