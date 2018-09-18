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
using IMS.Models.Contexts;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using IMS.Controllers;

namespace IMS
{
    public partial class ReceverForm : MetroForm
    {
        private bool IsValied { get; set; }
        private string CurruntCode = null;

        public ReceverForm()
        {
            InitializeComponent();
           
        }

        private void ReceverForm_Load(object sender, EventArgs e)
        {
            ActionEnable();
            LoadRecevers();
        }

        private void TReceverCode_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            this.IsValied = true;
            if ( checkCodeIsAvailable(TReceverCode.Text))
            {
                this.IsValied = false;
                this.label1.Text = "This Code Is Allready Exsist !";
            }
        }

        public bool checkCodeIsAvailable(string Code)
        {
            ReceverContext context = new ReceverContext();
            try
            {
                var Recever =  context.Recevers.Where(r => r.ReceverCode != this.CurruntCode).Where(re=>re.ReceverCode==Code).ToArray();
                if (Recever.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                context.Dispose();
            }
        }

        private void TReceverMobile_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ActionEnable()
        {
            Save.Enabled = true;
            Edit.Enabled = false;
            Delete.Enabled = false;
        }

        public void ActionDisable()
        {
            Save.Enabled = false;
            Edit.Enabled = true;
            Delete.Enabled = true;
        }

        public async void LoadRecevers()
        {
            ReceverContext context = new ReceverContext();
            try
            {
                
                IEnumerable<Recever> recevers = await context.Recevers.ToListAsync();
                if (recevers == null) return;
                AddToGrid(recevers);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException != null) MessageBox.Show(ex.InnerException.Message);
            }
            finally
            {
                context.Dispose();
            }
        }

        public void AddToGrid(IEnumerable<Recever> R)
        {
            foreach(Recever r in R)
            {
                DataGridViewRow Row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
                Row.Cells[0].Value = r.ReceverCode;
                Row.Cells[1].Value = r.Name;
                Row.Cells[2].Value = r.Mobile;
                Row.Cells[3].Value = r.Designation;
                metroGrid1.Rows.Add(Row);
            }
        }

        public bool Validate(Recever R)
        {
            ValidationContext context = new ValidationContext(R);
            List<ValidationResult> list = new List<ValidationResult>();
            var builder = new StringBuilder();

            if (!Validator.TryValidateObject(R, context, list))
            {

                foreach (ValidationResult vr in list)
                {
                    builder.Append(vr.ErrorMessage + "\r\n");
                }

                MessageBox.Show(builder.ToString());
                return false;
            }

            return true;
        }

        public void ReCreate()
        {
            TReceverCode.Text = "R_";
            TReceverName.Clear();
            TReceverMobile.Clear();
            TReceverDesignasion.Clear();

            this.IsValied = false;
            this.CurruntCode = null;
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (metroGrid1.Rows[e.RowIndex].Cells[0].Value == null) return;
                ActionDisable();


                var Row = metroGrid1.Rows[e.RowIndex];
                this.CurruntCode = Row.Cells[0].Value.ToString();
                TReceverCode.Text = Row.Cells[0].Value.ToString();
                TReceverName.Text = Row.Cells[1].Value.ToString();
                TReceverMobile.Text = Row.Cells[2].Value.ToString();
                TReceverDesignasion.Text = Row.Cells[3].Value.ToString();
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
        private void New_Click(object sender, EventArgs e)
        {
            ReCreate();
            ActionEnable();
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (TReceverMobile.Text == string.Empty) MessageBox.Show("Fill All Fildes !");

                Recever R = new Recever()
                {

                    Name = TReceverName.Text,
                    ReceverCode = TReceverCode.Text,
                    Mobile = int.Parse(TReceverMobile.Text),
                    Designation = TReceverDesignasion.Text

                };

                if (Validate(R))
                {
                    TryManageRecever Tmr = new TryManageRecever(R);
                    await Tmr.InsertAsync();
                    ReCreate();
                    metroGrid1.Rows.Clear();
                    LoadRecevers();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TReceverMobile.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fildes !");
                    return;
                }
                else if (!this.IsValied)
                {
                    MessageBox.Show("Please Select Different Code !");
                    return;
                }

                Recever R = new Recever()
                {

                    Name = TReceverName.Text,
                    ReceverCode = TReceverCode.Text,
                    Mobile = int.Parse(TReceverMobile.Text),
                    Designation = TReceverDesignasion.Text

                };

                if (Validate(R))
                {
                    TryManageRecever Tmr = new TryManageRecever(R);
                    if (!await Tmr.UpdateAsync(this.CurruntCode)) MessageBox.Show("Error !");
                    ReCreate();
                    metroGrid1.Rows.Clear();
                    LoadRecevers();
                    ActionEnable();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Delete This Recever ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            try
            {
                TryManageRecever Tmr = new TryManageRecever(null);
                if (!await Tmr.DeleteAsync(this.CurruntCode)) MessageBox.Show("Error !");
                ReCreate();
                metroGrid1.Rows.Clear();
                LoadRecevers();
                ActionEnable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
