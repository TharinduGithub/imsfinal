using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IMS
{
    public partial class ConnectionForm : MetroForm
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void WindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowsAuth.Checked)
            {
                ActionDisable();
            }
            else
            {
                ActionEnable();
            }
        }

        public void ActionDisable()
        {
            ConSource.Clear();
            ConUid.Clear();
            ConPwd.Clear();
            ConShowPass.Checked = false;
            Other.Enabled = false;
        }
        public void ActionEnable()
        {
            Other.Enabled = true;
        }

        private void Process_Click(object sender, EventArgs e)
        {
            if (WindowsAuth.Checked)
            {
                setConnectionForWindowsAuth();
                return;
            }
            else if(ConSource.Text !=string.Empty && ConUid.Text != string.Empty && ConPwd.Text != string.Empty)
            {
                setConnectionForCustomWay();
            }
            else
            {
                MessageBox.Show("All 3 Fields are Requird !", "Wanring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

        }

        public void setConnectionForWindowsAuth()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var Con = new ConnectionStringSettings("ConnectionName", String.Format("data source =.; initial catalog=IMS; integrated security =SSPI"));
                Con.ProviderName = "System.Data.SqlClient";
                config.ConnectionStrings.ConnectionStrings.Remove(Con);
                config.ConnectionStrings.ConnectionStrings.Add(Con);
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Connection Set Successfull !\n\n Please Restart the Application.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setConnectionForCustomWay()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ConString = "data source =" + ConSource.Text + "; initial catalog=IMS; User ID =" + ConUid.Text + "; password =" + ConPwd.Text + ";";
                var Con = new ConnectionStringSettings("ConnectionName", String.Format(ConString));
                Con.ProviderName = "System.Data.SqlClient";
                config.ConnectionStrings.ConnectionStrings.Remove(Con);
                config.ConnectionStrings.ConnectionStrings.Add(Con);
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Connection Set Successfull !\n\n Please Restart the Application.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConShowPass_CheckedChanged(object sender, EventArgs e)
        {
            ConPwd.PasswordChar = ConShowPass.Checked ? '\0' : '*';
        }
    }
}
