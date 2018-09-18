using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Controllers;
using IMS.Models;
using IMS.Models.Contexts;
using MetroFramework.Forms;

namespace IMS
{
    public partial class UsersForm : MetroForm
    {
        private bool IsValied = false;
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            loadUsers();
            metroTabControl1.SelectedIndex = 0;
        }


        public async void loadUsers()
        {
            metroGrid1.Rows.Clear();
            UserDataContext context = new UserDataContext();

            try
            {
                var Users = await context.UsersData.OrderBy(ud=>ud.ID).ToListAsync();
                if (Users.Count <= 1) return;
                Users.RemoveAt(0);

                AddUsersToGrid(Users);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        public void AddUsersToGrid(IEnumerable<UserData> Users)
        {
            metroGrid1.Rows.Clear();
            foreach (var user in Users)
            {
                DataGridViewRow Row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
                Row.Cells[0].Value = user.FirstName;
                Row.Cells[1].Value = user.LastName;
                Row.Cells[2].Value = user.Email;
                Row.Cells[3].Value = user.UserType;
                Row.Cells[4].Value = user.ID;

                metroGrid1.Rows.Add(Row);

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UserData UD = new UserData()
            {
                Username = userName.Text,
                Password = password.Text,
                UserType = uType.Text,
                FirstName = fNme.Text,
                LastName = lNme.Text,
                Email = uemail.Text

            };

            if (!this.IsValied)
            {
                MessageBox.Show("Unable To Add User, Username is Allready Exsist !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateUser(UD);
        }

        public void UpdateUser(UserData User)
        {
            try
            {
                ValidationContext context = new ValidationContext(User);
                List<ValidationResult> list = new List<ValidationResult>();

                if (!Validator.TryValidateObject(User, context, list))
                {
                    MessageBox.Show("Validation not Successfull !");
                    return;
                }

                TryUpdateUser tryUser = new TryUpdateUser(User);
                if (tryUser.InsertUser())
                {
                    clearTextBoxes();
                    loadUsers();
                    this.IsValied = false;
                }
                else
                {
                    MessageBox.Show("Unable To Add User, Validation not Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearTextBoxes()
        {
            userName.Clear();
            password.Clear();
            fNme.Clear();
            lNme.Clear();
            uemail.Clear();

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (metroGrid1.Rows[e.RowIndex].Cells[0].Value == null) {
                    BtnDelete.Enabled = false;
                    return;
                }
                BtnDelete.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Tap Content of Table to Edit Records !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = (int)metroGrid1.SelectedRows[0].Cells[4].Value;
                TryUpdateUser tryUser = new TryUpdateUser(null);
                if(MessageBox.Show("Do You Want to Delete This User ?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (tryUser.DeleteUser(ID))
                    {
                        loadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Unable To Delete User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = metroCheckBox1.Checked ? '\0' : '*';
        }

        private async void userName_Leave(object sender, EventArgs e)
        {
            if (await CheckUsernameAvailabe(userName.Text))
            {
                this.IsValied = true;
                return;
            }
            this.IsValied = false;
            MessageBox.Show("Username Is Allready Exsist !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public async Task<bool> CheckUsernameAvailabe(string Uid)
        {
            UserDataContext context = new UserDataContext();
            try
            {
                var User = await context.UsersData.FirstOrDefaultAsync(usr => usr.Username == Uid);
                if (User != null) return false;
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                context.Dispose();
            }
        }
    }
}
