using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using IMS.Models;
using IMS.Controllers;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IMS
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            metroTextBox1.Focus();
        }

        private async void label2_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            ActionDisable();
            bool result = await Task<bool>.Run(() => {
                if(CheckUser(new User() { Username = metroTextBox1.Text, Password = metroTextBox2.Text }))
                {
                    return true;
                }
                return false;
                
            });

            if (result)
            {
                this.Dispose();
                return;
            }

            this.metroTextBox1.Clear();
            this.metroTextBox2.Clear();
            metroTextBox1.Focus();
            ActionEnable();
            label3.Text = "Invalied Credentials !";
        }

        public bool CheckUser(User user)
        {
            try
            {
                ValidationContext context = new ValidationContext(user);
                List<ValidationResult> list = new List<ValidationResult>();

                if (!Validator.TryValidateObject(user, context, list))
                {
                    MessageBox.Show("Fillout All Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                TryLoginUser login = new TryLoginUser(user);
                if (login.IsUser) return true;    

                    return false;              
            }
            catch (Exception)
            {              

                MessageBox.Show("An Error Occured !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (Program.ErrorCode == -2146233079)
                {
                    MessageBox.Show("Please Set Connection Before Login !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
            base.OnClosing(e);
        }

        public void ActionEnable()
        {
            LoadSpinner.Visible = false;
            label2.Enabled = true;
        }

        public void ActionDisable()
        {
            label2.Enabled = false;
            LoadSpinner.Visible = true;         
           
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            ConnectionForm CF = new ConnectionForm();
            CF.ShowDialog();
        }
    }
}
