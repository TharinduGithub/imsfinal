using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IMS
{
    public partial class BackUpForm : MetroForm
    {
        private string ConString = ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;

        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            ActionDisableForBackup();
            ActionDisableForRestore();
            metroTabControl1.SelectedIndex = 0;

        }

        public void ActionEnableForBackup()
        {
            this.BtnBackup.Enabled = true;
        }

        public void ActionDisableForBackup()
        {
            this.BtnBackup.Enabled = false;
        }

        public void ActionEnableForRestore()
        {
            this.restore.Enabled = true;
        }

        public void ActionDisableForRestore()
        {
            this.restore.Enabled = false;
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            BackUp();
        }

        private void backuplocation_TextChanged(object sender, EventArgs e)
        {
            if(backuplocation.Text != string.Empty)
            {
                ActionEnableForBackup();
            }
        }

        public void BackUp()
        {
            try
            {
                using(SqlConnection Con = new SqlConnection(this.ConString))
                {
                    string sqlQuery = "BACKUP DATABASE IMS TO DISK = '" + backuplocation.Text.ToString() + "\\IMS_Backup-" + DateTime.Now.Ticks.ToString() + ".bak'";
                    SqlCommand command = new SqlCommand(sqlQuery, Con);
                    Con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Backup Successfull !");
                    ActionDisableForBackup();
                    backuplocation.Clear();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want to Restore This Backup File ?","Warning !",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Restore();
            }            
        }

        public void Restore()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(this.ConString))
                {
                    string sqlQuery = "Alter Database IMS Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sqlQuery += "Use master Restore Database IMS From Disk = '" + RestoreLocation.Text.ToString() + "' With Replace";
                    SqlCommand command = new SqlCommand(sqlQuery, Con);
                    Con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Restore Compleated !");
                    ActionDisableForRestore();
                    RestoreLocation.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreLocation_TextChanged(object sender, EventArgs e)
        {
            if (RestoreLocation.Text != string.Empty)
            {
                ActionEnableForRestore();
            }
        }

        private void browsForRestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    RestoreLocation.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browsForBackup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    backuplocation.Text = dialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
