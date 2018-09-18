namespace IMS
{
    partial class Splash
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.loading = new System.Windows.Forms.Label();
            this.Signature = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(564, 12);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(30, 30);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 30;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.loading.Location = new System.Drawing.Point(600, 15);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(100, 25);
            this.loading.TabIndex = 1;
            this.loading.Text = "Loading ...";
            // 
            // Signature
            // 
            this.Signature.AutoSize = true;
            this.Signature.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signature.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Signature.Location = new System.Drawing.Point(149, 152);
            this.Signature.Name = "Signature";
            this.Signature.Size = new System.Drawing.Size(427, 40);
            this.Signature.TabIndex = 2;
            this.Signature.Text = "Inventory Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMS.Properties.Resources.Splash2;
            this.pictureBox1.Location = new System.Drawing.Point(-96, -297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 882);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 485);
            this.Controls.Add(this.Signature);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Label Signature;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}