using IMS.Models.Contexts;
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
using System.Data.Entity;

namespace IMS
{
    public partial class VendorForm : MetroForm
    {
        private string CurruntCode { get; set; }
        private bool IsValied { get; set; }
        private int selectedItemId { get; set; }

        public VendorForm()
        {
            InitializeComponent();
            this.selectedItemId = 0;
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            ActionEnable();
            loadVendors();
        }

        public void ReCreate()
        {
            this.metroTextBox1.Clear();
            this.Ven.Clear();
            this.IsValied = false;
            this.selectedItemId = 0;
            this.CurruntCode = null;
            Ven.Focus();
        }

        public bool checkVen(string Val)
        {

            VendorContext context = new VendorContext();
            try
            {
                var Ven = context.Venders.Where(ven => ven.VendorCode != CurruntCode).Where(ct => ct.VendorCode == Val).FirstOrDefault();
                if (Ven != null)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                context.Dispose();
            }
        }

        public void saveNewVendor(dynamic O)
        {
            if (this.IsValied == false)
            {
                MessageBox.Show("Please Change Code");
                return;
            }

            VendorContext context = new VendorContext();
            try
            {              
                context.Venders.Add(new IMS.Models.Vendor() { Name = O.Name, VendorCode = O.VendorCode });
                context.SaveChanges();
                ReCreate();
                loadVendors();

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                foreach (var errors in e.EntityValidationErrors)
                {
                    foreach (var error in errors.ValidationErrors)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                if (e.InnerException != null)
                {
                    MessageBox.Show(e.InnerException.Message);
                }
            }
            finally
            {
                context.Dispose();
            }

        }

        public async void loadVendors()
        {
            VendorContext context = new VendorContext();
            try
            {
                listBox1.Items.Clear();               
                IEnumerable<Models.Vendor> Vends = await context.Venders.ToListAsync();
                foreach (Models.Vendor ven in Vends)
                {
                    listBox1.Items.Add(ven.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                if (e.InnerException != null)
                {
                    MessageBox.Show(e.InnerException.Message);
                }
            }
            finally
            {
                context.Dispose();
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

        private void metroTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            noti.Text = string.Empty;
            IsValied = true;

            if (checkVen(metroTextBox1.Text))
            {
                noti.Text = "This Code Is Allready Exits !";
                IsValied = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            ActionDisable();
            VendorContext context = new VendorContext();
            IMS.Models.Vendor V = context.Venders.FirstOrDefault(ven => ven.Name == listBox1.SelectedItem.ToString());
            if (V != null)
            {
                this.selectedItemId = V.ID;
                this.CurruntCode = V.VendorCode;
                metroTextBox1.Text = V.VendorCode;
                Ven.Text = V.Name;
            }
            noti.Text = string.Empty;
            context.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Ven.Text != string.Empty && metroTextBox1.Text != string.Empty && IsValied == true)
            {
                saveNewVendor(new { Name = Ven.Text, VendorCode = metroTextBox1.Text });
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (this.selectedItemId == 0)
            {
                MessageBox.Show("Please Select a Vendor to Update !");
                return;
            }
            else if (this.IsValied == false)
            {
                MessageBox.Show("Please Change Code");
                return;
            }
            else
            {
                VendorContext context = new VendorContext();
                try
                {
                    var Ven = context.Venders.FirstOrDefault(ven => ven.ID == this.selectedItemId);
                    Ven.Name = this.Ven.Text;
                    Ven.VendorCode = metroTextBox1.Text;
                    context.SaveChanges();
                    ReCreate();
                    loadVendors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    context.Dispose();
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.selectedItemId == 0)
            {
                MessageBox.Show("Please Select a Vendor to Delete !");
                return;
            }
            VendorContext context = new VendorContext();
            try
            {
                if (MessageBox.Show("If You Delete This Vendor, All The Suppliers Will Be Deleted According To This Vendor !\n\nDo You Want To Delete This Vendor", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var Ven = context.Venders.FirstOrDefault(ven => ven.ID == this.selectedItemId);
                    context.Venders.Remove(Ven);
                    context.SaveChanges();
                    ReCreate();
                    loadVendors();
                }
                else
                {
                    return;
                }

            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("This Vendor Contain Some Suppliers. If You Delete This Vendor Delete All The Suppliers Accroding To This Vendor First !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                context.Dispose();
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            ActionEnable();
            ReCreate();
        }
    }
}
