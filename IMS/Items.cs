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
using System.Text.RegularExpressions;
using System.Threading;

namespace IMS
{
    public partial class Items : MetroForm
    {
        private int selectedItemId { get; set; }

        public Items()
        {
            InitializeComponent();
            this.selectedItemId = 0;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            ActionEnable();
            LoadCategories();
            LoadCatsForSearch();
        }

        public async void LoadCatsForSearch()
        {
            ItemContext context = new ItemContext();
            try
            {
                var AllCats = await context.Categories.ToListAsync();
                if (AllCats == null) return;

                AllCats.Insert(0, new Models.Category { Name = "Select Category", ID = 0 });
                SearchByCat.DataSource = AllCats;
                SearchByCat.DisplayMember = "Name";
                SearchByCat.ValueMember = "ID";
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

        public async void LoadCategories()
        {
            ItemContext context = new ItemContext();
            try
            {
                var AllCats = await context.Categories.ToListAsync();
                if (AllCats == null) return;

                AllCats.Insert(0, new Models.Category { Name = "Select Category", ID = 0 });
                bindingSource1.DataSource = AllCats;
                TCategory.DataSource = bindingSource1.DataSource;
                TCategory.DisplayMember = "Name";
                TCategory.ValueMember = "ID";


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

        public string MakeNewItemCode(int CID)
        {

            ItemContext context = new ItemContext();
            try
            {
                var items = context.Items.Include(i => i.Category).Where(itm => itm.Category.ID == CID).ToList();
                if (items.Count > 0)
                {
                    var item = items.Last();
                    string resultString = Regex.Match(item.ItemID, @"\d+").Value;

                    return "I_"+item.Category.Code + (int.Parse(resultString) + 1).ToString().PadLeft(4, '0');
                }
                else
                {
                    var Cat = context.Categories.FirstOrDefault(cat => cat.ID == CID);
                    return "I_" + Cat.Code + 1.ToString().PadLeft(4, '0');
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

        private async void TCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Save.Enabled == false)
            {
                return;
            }
            else if (TCategory.SelectedIndex <= 0)
            {
                ClearTextBoxes();
                return;
            }

            int CID = (int)TCategory.SelectedValue;
            string Code = await Task.Run<string>(() => MakeNewItemCode(CID));
            this.TItemCode.Text = Code.ToString();

        }

        public void ActionEnable()
        {
            Save.Enabled = true;
            Edit.Enabled = false;
            Delete.Enabled = false;
            TCategory.Enabled = true;
        }

        public void ActionDisable()
        {
            Save.Enabled = false;
            Edit.Enabled = true;
            Delete.Enabled = true;
            TCategory.Enabled = false;
        }

        public void ClearTextBoxes()
        {
            TItemCode.Clear();
            TItemName.Clear();
            TReorderPoint.Clear();
            TOpeningStock.Clear();
            TCost.Clear();
            TCategory.SelectedIndex = 0;
        }

        public void ReCreate()
        {
            this.selectedItemId = 0;
        }

        

        public async void saveNewItem(int ID)
        {
            if (TReorderPoint.Text == string.Empty || TOpeningStock.Text == string.Empty)
            {
                MessageBox.Show("Fill All Fields");
                return;
            }

            Item item = new Item()
            {

                ItemID = TItemCode.Text,
                ItemName = TItemName.Text,
                ReorderPoint = int.Parse(TReorderPoint.Text),
                OpenningStock = int.Parse(TOpeningStock.Text),
                currentQuntity = int.Parse(TOpeningStock.Text),
                costPrice = (TCost.Text == string.Empty) ? 0 : double.Parse(TCost.Text),
            };

            ValidationContext context = new ValidationContext(item);
            List<ValidationResult> list = new List<ValidationResult>();

            if (!Validator.TryValidateObject(item, context, list))
            {
                MessageBox.Show("Validation Not Successfull !");
                return;
            }

            TryManageItem Insert = new TryManageItem(item);
            Item i = await Insert.InsertItem(ID);
            
   
            ReCreate();
            ClearTextBoxes();
            if (i != null && (int)SearchByCat.SelectedValue == ID) setCurrentRow(i);
        }

        public void setCurrentRow(Item I)
        {
            DataGridViewRow Row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
            Row.Cells[0].Value = I.ItemID;
            Row.Cells[1].Value = I.ItemName;
            Row.Cells[2].Value = I.Category.Name;
            Row.Cells[3].Value = I.ReorderPoint;
            Row.Cells[4].Value = I.OpenningStock;
            Row.Cells[5].Value = I.costPrice;
            Row.Cells[6].Value = I.Category.ID;
            metroGrid1.Rows.Add(Row);
        }

        private void TReorderPoint_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TOpeningStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchByCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchByCat.SelectedIndex == 0)
            {
                metroGrid1.Rows.Clear();
                return;
            }

            AddDataToGrid((int)SearchByCat.SelectedValue);

        }

        public async void AddDataToGrid(int ID)
        {
            ItemContext context = new ItemContext();
            try
            {                
                IEnumerable<Item> items = await context.Items.Include(i => i.Category).Where(itm => itm.Category.ID == ID).ToListAsync();
                if (items == null) return;

                metroGrid1.Rows.Clear();

                foreach (var item in items)
                {
                    DataGridViewRow Row = (DataGridViewRow)metroGrid1.Rows[0].Clone();
                    Row.Cells[0].Value = item.ItemID;
                    Row.Cells[1].Value = item.ItemName;
                    Row.Cells[2].Value = item.Category.Name;
                    Row.Cells[3].Value = item.ReorderPoint;
                    Row.Cells[4].Value = item.OpenningStock;
                    Row.Cells[5].Value = item.costPrice;
                    Row.Cells[6].Value = item.Category.ID;
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

                TCategory.SelectedValue = (int)Row.Cells[6].Value;
                TItemCode.Text = Row.Cells[0].Value.ToString();
                TItemName.Text = Row.Cells[1].Value.ToString();
                TReorderPoint.Text = Row.Cells[3].Value.ToString();
                TOpeningStock.Text = Row.Cells[4].Value.ToString();
                TCost.Text = Row.Cells[5].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Tap Content of Table to Edit Records !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public void UpdateItem(int ID)
        {
            if (TReorderPoint.Text == string.Empty || TOpeningStock.Text == string.Empty)
            {
                MessageBox.Show("Fill All Fields");
                return;
            }

            Item item = new Item()
            {

                ItemID = TItemCode.Text,
                ItemName = TItemName.Text,
                ReorderPoint = int.Parse(TReorderPoint.Text),
                OpenningStock = int.Parse(TOpeningStock.Text),
                currentQuntity = int.Parse(TOpeningStock.Text),
                costPrice = (TCost.Text == string.Empty) ? 0 : double.Parse(TCost.Text),

            };

            ValidationContext context = new ValidationContext(item);
            List<ValidationResult> list = new List<ValidationResult>();

            if (!Validator.TryValidateObject(item, context, list))
            {
                MessageBox.Show("Validation Not Successfull !");
                return;
            }

            TryManageItem Update = new TryManageItem(item);

            Thread T1 = new Thread(() =>
            {
                Update.Update(ID);
            });

            T1.Start();
            T1.Join();
            int curVal = (int)SearchByCat.SelectedValue != 0 ? (int)SearchByCat.SelectedValue : (int)TCategory.SelectedValue;
            AddDataToGrid(curVal);
            ReCreate();
            ClearTextBoxes();
            
            

        }

        public  void DeleteItem()
        {
            if(TItemCode.Text == null)
            {
                MessageBox.Show("Please Select a Item to Delete !");
                return;
            }

            ItemContext context = new ItemContext();

            try
            {
                var item = context.Items.FirstOrDefault(itm => itm.ItemID == TItemCode.Text);
                context.Items.Remove(item);
                context.SaveChanges();
                int curVal = (int)SearchByCat.SelectedValue != 0 ? (int)SearchByCat.SelectedValue : (int)TCategory.SelectedValue;
                AddDataToGrid(curVal);
                ReCreate();
                ClearTextBoxes();
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                context.Dispose();
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int ID = (int)TCategory.SelectedValue;
            if (ID == 0) return;

            saveNewItem(ID);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int ID = (int)TCategory.SelectedValue;
            if (ID == 0) return;

            UpdateItem(ID);
        }

        private void New_Click(object sender, EventArgs e)
        {
            ReCreate();
            metroGrid1.Rows.Clear();
            ClearTextBoxes();
            ActionEnable();
            if (SearchByCat.SelectedIndex >= 0) SearchByCat.SelectedIndex = 0;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Delete This Item ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            DeleteItem();
        }

        private void TCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
   
    }
}
