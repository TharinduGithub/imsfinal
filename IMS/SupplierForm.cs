using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Controllers;
using IMS.Models;
using IMS.Models.Contexts;
using MetroFramework.Forms;

namespace IMS
{
    public partial class SupplierForm : MetroForm
    {
        private int selectedItemId { get; set; }

        public SupplierForm()
        {
            InitializeComponent();
            this.selectedItemId = 0;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            ActionEnable();
            LoadVendors();
            LoadVendorsForSearch();

        }

        public async void LoadVendors()
        {
            VendorContext context = new VendorContext();
            try
            {
                var AllVends = await context.Venders.ToListAsync();
                if (AllVends == null) return;

                AllVends.Insert(0, new Models.Vendor { Name = "Select Vendor", ID = 0 });
                TVendor.DataSource = AllVends;
                TVendor.DisplayMember = "Name";
                TVendor.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if(ex.InnerException != null) MessageBox.Show(ex.InnerException.Message);
            }
            finally
            {
                context.Dispose();
            }
        }

        public async void LoadVendorsForSearch()
        {
            VendorContext context = new VendorContext();
            try
            {              
                var AllVends = await context.Venders.ToListAsync();
                if (AllVends == null) return;

                AllVends.Insert(0, new Models.Vendor { Name = "Select Vendor", ID = 0 });
                SearchByVendor.DataSource = AllVends;
                SearchByVendor.DisplayMember = "Name";
                SearchByVendor.ValueMember = "ID";
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

        public string MakeNewSupplierCode(int VID)
        {

            VendorContext context = new VendorContext();
            try
            {
                var suppliers = context.Suppliers.Include(s => s.Vendor).Where(sp => sp.Vendor.ID == VID).ToList();
                if (suppliers.Count > 0)
                {
                    var supplier = suppliers.Last();
                    string resultString = Regex.Match(supplier.Code, @"\d+").Value;

                    return "S_"+supplier.Vendor.VendorCode + (int.Parse(resultString) + 1).ToString().PadLeft(4, '0');
                }
                else
                {
                    var Ven = context.Venders.FirstOrDefault(v => v.ID == VID);
                    return "S_"+Ven.VendorCode + 1.ToString().PadLeft(4, '0');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
            finally
            {
                context.Dispose();
            }

        }

        private async void TVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Save.Enabled == false)
            {
                return;
            }
            else if (TVendor.SelectedIndex <= 0)
            {
                ClearTextBoxes();
                return;
            }

            int VID = (int)TVendor.SelectedValue;
            string Code = await Task.Run<string>(() => MakeNewSupplierCode(VID));
            this.TVendorCode.Text = Code.ToString();
        }

        public void ActionEnable()
        {
            Save.Enabled = true;
            Edit.Enabled = false;
            Delete.Enabled = false;
            TVendor.Enabled = true;
        }

        public void ActionDisable()
        {
            Save.Enabled = false;
            Edit.Enabled = true;
            Delete.Enabled = true;
            TVendor.Enabled = false;
        }

        public void ClearTextBoxes()
        {
            TVendorCode.Clear();
            TVendorName.Clear();
            TVendorMobile.Clear();
            TVendorJoinDate.Text=string.Empty;
            TVendor.SelectedIndex = 0;
        }

        public void ReCreate()
        {
            this.selectedItemId = 0;
        }

        public async void saveNewSupplier(int ID)
        {
            try
            {
                if (TVendorMobile.Text == string.Empty || TVendorJoinDate.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields");
                    return;
                }

                Supplier supplier = new Supplier()
                {

                    Code = TVendorCode.Text,
                    Name = TVendorName.Text,
                    Mobile = int.Parse(TVendorMobile.Text),
                    JoinDate = DateTime.Parse(TVendorJoinDate.Text)

                };

                ValidationContext context = new ValidationContext(supplier);
                List<ValidationResult> list = new List<ValidationResult>();
                var builder = new StringBuilder();

                if (!Validator.TryValidateObject(supplier, context, list))
                {

                    foreach (ValidationResult vr in list)
                    {
                        builder.Append(vr.ErrorMessage + "\r\n");
                    }

                    MessageBox.Show(builder.ToString());
                    return;
                }

                TryManageSupplier Insert = new TryManageSupplier(supplier);
                Supplier S = await Insert.InsertSupplier(ID);


                ReCreate();
                ClearTextBoxes();
                if (S != null && (int)SearchByVendor.SelectedValue == ID) setCurrentRow(S);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setCurrentRow(Supplier V)
        {
            DataGridViewRow Row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
            Row.Cells[0].Value = V.Code;
            Row.Cells[1].Value = V.Name;
            Row.Cells[2].Value = V.Vendor.Name;
            Row.Cells[3].Value = V.Mobile;
            Row.Cells[4].Value = V.JoinDate.ToShortDateString();
            Row.Cells[5].Value = V.Vendor.ID;
            metroGrid1.Rows.Add(Row);
        }

        private void TVendorMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchByVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchByVendor.SelectedIndex == 0)
            {
                metroGrid1.Rows.Clear();
                return;
            }

            AddDataToGrid((int)SearchByVendor.SelectedValue);
        }

        public async void AddDataToGrid(int ID)
        {
            VendorContext context = new VendorContext();
            try
            {              
                IEnumerable<Supplier> suppliers = await context.Suppliers.Include(i => i.Vendor).Where(itm => itm.Vendor.ID == ID).ToListAsync();
                if (suppliers == null) return;

                metroGrid1.Rows.Clear();

                foreach (var supplier in suppliers)
                {
                    DataGridViewRow Row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
                    Row.Cells[0].Value = supplier.Code;
                    Row.Cells[1].Value = supplier.Name;
                    Row.Cells[2].Value = supplier.Vendor.Name;
                    Row.Cells[3].Value = supplier.Mobile;
                    Row.Cells[4].Value = supplier.JoinDate.ToShortDateString();
                    Row.Cells[5].Value = supplier.Vendor.ID;
                    metroGrid1.Rows.Add(Row);
                }
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

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            try
            {
                if (metroGrid1.Rows[e.RowIndex].Cells[0].Value == null) return;
                ActionDisable();

                var Row = metroGrid1.Rows[e.RowIndex];

                TVendor.SelectedValue = (int)Row.Cells[5].Value;
                TVendorCode.Text = Row.Cells[0].Value.ToString();
                TVendorName.Text = Row.Cells[1].Value.ToString();
                TVendorMobile.Text = Row.Cells[3].Value.ToString();
                TVendorJoinDate.Text = Row.Cells[4].Value.ToString();
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

        public void UpdateItem(int ID)
        {
            if (TVendorMobile.Text == string.Empty || TVendorJoinDate.Text == string.Empty)
            {
                MessageBox.Show("Fill All Fields");
                return;
            }

            Supplier supplier = new Supplier()
            {

                Code = TVendorCode.Text,
                Name = TVendorName.Text,
                Mobile = int.Parse(TVendorMobile.Text),
                JoinDate = DateTime.Parse(TVendorJoinDate.Text)

            };

            ValidationContext context = new ValidationContext(supplier);
            List<ValidationResult> list = new List<ValidationResult>();

            if (!Validator.TryValidateObject(supplier, context, list))
            {
                MessageBox.Show("Validation Not Successfull !");
                return;
            }

            TryManageSupplier Update = new TryManageSupplier(supplier);

            Thread T1 = new Thread(() =>
            {
                Update.Update(ID);
            });

            T1.Start();
            ReCreate();
            ClearTextBoxes();
            T1.Join();
            AddDataToGrid((int)SearchByVendor.SelectedValue);

        }

        public void DeleteItem()
        {
            if (TVendorCode.Text == null)
            {
                MessageBox.Show("Please Select a Supplier to Delete !");
                return;
            }
            if(MessageBox.Show("Do You Want to Delete This Supplier ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            VendorContext context = new VendorContext();
            try
            {
                var supplier = context.Suppliers.FirstOrDefault(s => s.Code == TVendorCode.Text);
                context.Suppliers.Remove(supplier);
                context.SaveChanges();
                ReCreate();
                ClearTextBoxes();
                AddDataToGrid((int)SearchByVendor.SelectedValue);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            ReCreate();
            metroGrid1.Rows.Clear();
            ClearTextBoxes();
            ActionEnable();
            if (SearchByVendor.SelectedIndex >= 0) SearchByVendor.SelectedIndex = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int ID = (int)TVendor.SelectedValue;
            if (ID == 0) return;

            saveNewSupplier(ID);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int ID = (int)TVendor.SelectedValue;
            if (ID == 0) return;

            UpdateItem(ID);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
    }
}
