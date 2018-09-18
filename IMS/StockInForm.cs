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
using IMS.Models.Contexts;
using IMS.Models;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using DGVPrinterHelper;

namespace IMS
{
    public partial class StockInForm : MetroForm
    {
        private string ConString = ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;
        public StockInForm()
        {
            InitializeComponent();
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {
            loadVendors();
            ActionEnable();
            loadCategeriesForSearch();
            loadSuppliersForSearch();
            Spinner.Visible = false;
            metroTabControl1.SelectedIndex = 0;
            ActionDisbleForDeleteStockIn();
        }

        public async void loadVendors()
        {
            VendorContext context = new VendorContext();
            try
            {
                var vendors = await context.Venders.ToListAsync();
                if (vendors == null) return;

                vendors.Insert(0, new Vendor { ID = 0, Name = "Select Vendor" });
                AllVendors.DisplayMember = "Name";
                AllVendors.ValueMember = "ID";
                AllVendors.DataSource = vendors;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }
        public async void loadCategeriesForSearch()
        {
            ItemContext context = new ItemContext();
            try
            {
                List<IMS.Models.Category> categories = await context.Categories.ToListAsync();
                if (categories.Count() == 0) return;

                categories.Insert(0, new IMS.Models.Category { ID = 0, Name = "Select Category" });
                SearchByCategoryCombo.DisplayMember = "Name";
                SearchByCategoryCombo.ValueMember = "ID";
                SearchByCategoryCombo.DataSource = categories;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        public async void loadSuppliersForSearch()
        {
            VendorContext context = new VendorContext();


            try
            {
                var suppliers = await context.Suppliers.ToListAsync();
                if (suppliers.Count() == 0) return;
                suppliers.Insert(0, new Supplier { Code = "Select Supplier" });

                SearchBySupplierCombo.DisplayMember = "Code";
                SearchBySupplierCombo.ValueMember = "Code";
                SearchBySupplierCombo.DataSource = suppliers;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void AllVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllVendors.SelectedIndex <= 0)
            {
                SupplierCombo.DataSource = null;
                SupplierName.Clear();
                return;
            }

            loadSuppliers((int)AllVendors.SelectedValue);
        }

        public async void loadSuppliers(int ID)
        {
            VendorContext context = new VendorContext();


            try
            {
                var suppliers = await context.Suppliers.Where(sup => sup.Vendor.ID == ID).ToListAsync();
                if (suppliers.Count() == 0) return;
                suppliers.Insert(0, new Supplier { Code = "Select Supplier" });

                SupplierCombo.DisplayMember = "Code";
                SupplierCombo.ValueMember = "Code";
                SupplierCombo.DataSource = suppliers;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void SupplierCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierCombo.SelectedIndex <= 0)
            {

                SupplierName.Clear();
                return;
            };

            VendorContext context = new VendorContext();
            try
            {
                var supplier = context.Suppliers.FirstOrDefault(sup => sup.Code == SupplierCombo.SelectedValue.ToString());
                if (supplier == null) return;
                SupplierName.Text = supplier.Name.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void SupplierName_TextChanged(object sender, EventArgs e)
        {
            loadCategeries();
            if (this.SupplierName.Text == string.Empty)
            {
                CategoryCombo.Enabled = false;
            }
            else
            {
                CategoryCombo.Enabled = true;
            }
        }

        public async void loadCategeries()
        {
            ItemContext context = new ItemContext();
            try
            {
                List<IMS.Models.Category> categories = await context.Categories.ToListAsync();
                if (categories.Count() == 0) return;

                categories.Insert(0, new IMS.Models.Category { ID = 0, Name = "Select Category" });
                CategoryCombo.DisplayMember = "Name";
                CategoryCombo.ValueMember = "ID";
                CategoryCombo.DataSource = categories;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCombo.SelectedIndex <= 0)
            {
                ItemCombo.DataSource = null;
                ItemInfo.Clear();
                return;
            }
            ItemCombo.DataSource = null;
            loadItemsToEachCategory((int)CategoryCombo.SelectedValue);
        }

        public async void loadItemsToEachCategory(int ID)
        {
            ItemContext context = new ItemContext();
            try
            {
                List<Item> items = await context.Items.Where(i => i.Category.ID == ID).ToListAsync();
                if (items.Count() == 0) return;

                items.Insert(0, new Item { ItemID = "Select Item" });
                ItemCombo.DisplayMember = "ItemID";
                ItemCombo.ValueMember = "ItemID";
                ItemCombo.DataSource = items;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void ItemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemCombo.SelectedIndex <= 0)
            {
                ItemInfo.Clear();
                return;
            }

            ItemContext context = new ItemContext();
            try
            {
                var item = context.Items.FirstOrDefault(i => i.ItemID == ItemCombo.SelectedValue.ToString());
                if (item == null) return;
                ItemInfo.Text = item.ItemName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }

        }

        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void addRecordToGrid()
        {
            DataGridViewRow Row = (DataGridViewRow)RecordGrid.Rows[0].Clone();
            int result = checkIsAvailable(ItemCombo.SelectedValue.ToString());
            if ( result > -1)
            {
                int currentValue = int.Parse(RecordGrid.Rows[result].Cells[2].Value.ToString());
                RecordGrid.Rows[result].Cells[2].Value = (currentValue + int.Parse(Qty.Text)).ToString();
                Recreate();
            }
            else
            {
                Row.Cells[0].Value = ItemCombo.SelectedValue;
                Row.Cells[1].Value = ItemInfo.Text;
                Row.Cells[2].Value = Qty.Text;
                Row.Cells[3].Value = StockInDate.Text;
                Row.Cells[4].Value = SupplierCombo.SelectedValue.ToString();

                RecordGrid.Rows.Add(Row);
                Recreate();
            }
           

        }

        public int checkIsAvailable(string Code)
        {
            for(int i=0; i < RecordGrid.RowCount-1; i++)
            {
                if(RecordGrid.Rows[i].Cells[0].Value.ToString() == Code)
                {
                    return i;
                }
            }

            return -1;
        }

        public void ActionEnable()
        {
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
        }
        public void ActionDisable()
        {
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = true;
        }
        public void Recreate()
        {
            if (CategoryCombo.SelectedIndex > -1)
            {
                CategoryCombo.SelectedIndex = 0;
                Qty.Clear();
            }
        }

        private void RecordGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            try
            {
                if (RecordGrid.Rows[e.RowIndex].Cells[0].Value == null) return;
                ActionDisable();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Qty.Text == string.Empty || SupplierCombo.SelectedIndex < 1 || ItemCombo.SelectedIndex < 1)
            {
                MessageBox.Show("Please Select Item or Supplier Correct !");
                return;
            }

            addRecordToGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            RecordGrid.Rows.RemoveAt(RecordGrid.SelectedRows[0].Index);
            ActionEnable();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            if (RecordGrid.Rows.Count <= 1) return;
            doProcess(RecordGrid.Rows);
        }

        public async void doProcess(DataGridViewRowCollection collection)
        {
            Process.Enabled = false;
            Spinner.Visible = true;
            StockContext context = new StockContext();
            ItemContext itmContext = new ItemContext();
            try
            {
                Task T = new Task(() =>
                 {
                     StockIn St = new StockIn()
                     {
                         Date = DateTime.Parse(collection[0].Cells[3].Value.ToString()),
                         Supplier_ID = collection[0].Cells[4].Value.ToString()
                     };
                     var StIn = context.StockIns.Add(St);
                     context.SaveChanges();

                     for (int i=0; i<collection.Count-1; i++)
                     {
                         string Code = collection[i].Cells[0].Value.ToString();
                         int Qty = int.Parse(collection[i].Cells[2].Value.ToString());
                         context.StockInItems.Add(new StockInItem() { ItemID = Code, StockInID = StIn.StockInID, Quntity = Qty});

                         Item item = itmContext.Items.FirstOrDefault(itm => itm.ItemID == Code);
                         if (item == null) throw new Exception("Item Is Null");

                         item.currentQuntity = item.currentQuntity + Qty;
                         itmContext.SaveChanges();
                     }

                     context.SaveChanges();

                 });

                T.Start();
                await T;
                Process.Enabled = true;
                Spinner.Visible = false;
                RecordGrid.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
                itmContext.Dispose();

            }
        }

        private void SearchByDate_ValueChanged(object sender, EventArgs e)
        {
            CellGrid.DataSource = null;
            if (SearchBySupplierCombo.SelectedIndex > -1) { SearchBySupplierCombo.SelectedIndex = 0; }
            if (SearchByCategoryCombo.SelectedIndex > -1) { SearchByCategoryCombo.SelectedIndex = 0; }
            SearchAll.Checked = false;
        }

        private void SearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchAll.Checked)
            {
                if (SearchBySupplierCombo.SelectedIndex > -1) { SearchBySupplierCombo.SelectedIndex = 0; }
                if (SearchByCategoryCombo.SelectedIndex > -1) { SearchByCategoryCombo.SelectedIndex = 0; }
                SearchAll.Checked = true;
                LoadStockInsAll(DateTime.Parse(SearchByDate.Text));
            }
            else
            {
                CellGrid.DataSource = null;
            }
        }
        public async void LoadStockInsAll(DateTime date)
        {
            ProgressSpinner.Spinning = true;
            ProgressSpinner.Visible = true;

            await Task.Run(() => {
                try
                {
                    using (SqlConnection Con = new SqlConnection(this.ConString))
                    {
                        SqlCommand command = new SqlCommand("LoadStockInsAll", Con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Date", date);
                        SqlDataAdapter DA = new SqlDataAdapter(command);

                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        Action A = () => {
                            if (DS.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("No Result Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                CellGrid.DataSource = null;
                                ProgressSpinner.Visible = false;
                                ProgressSpinner.Spinning = false;
                                SearchAll.Checked = false;
                                return;
                            }

                            CellGrid.DataSource = DS.Tables[0];

                            CellGrid.Columns[0].Visible = false;
                            CellGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            ProgressSpinner.Visible = false;
                            ProgressSpinner.Spinning = false;
                        };

                        BeginInvoke(A);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });
        }

        private void SearchBySupplierCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAll.Checked = false;
            if (SearchBySupplierCombo.SelectedIndex <= 0)
            {
                CellGrid.DataSource = null;
               
                return;
            }

            if (SearchByCategoryCombo.SelectedIndex > -1) { SearchByCategoryCombo.SelectedIndex = 0; }
            LoadStockOutsBySupplier(SearchBySupplierCombo.SelectedValue.ToString(), DateTime.Parse(SearchByDate.Text));
        }

        public async void LoadStockOutsBySupplier(string Code, DateTime date)
        {
            ProgressSpinner.Spinning = true;
            ProgressSpinner.Visible = true;

            await Task.Run(() => {
                try
                {
                    using (SqlConnection Con = new SqlConnection(this.ConString))
                    {
                        SqlCommand command = new SqlCommand("LoadStockInsBySupplier", Con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Supplier_Code", Code);
                        command.Parameters.AddWithValue("@Date", date);
                        SqlDataAdapter DA = new SqlDataAdapter(command);

                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        Action A = () => {
                            if (DS.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("No Result Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                CellGrid.DataSource = null;
                                ProgressSpinner.Visible = false;
                                ProgressSpinner.Spinning = false;
                                SearchBySupplierCombo.SelectedIndex = 0;
                                return;
                            }

                            CellGrid.DataSource = DS.Tables[0];

                            CellGrid.Columns[0].Visible = false;
                            CellGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            ProgressSpinner.Visible = false;
                            ProgressSpinner.Spinning = false;
                        };

                        BeginInvoke(A);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });
        }

        private void SearchByCategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAll.Checked = false;
            if (SearchByCategoryCombo.SelectedIndex <= 0)
            {
                CellGrid.DataSource = null;
                return;
            }

            if (SearchBySupplierCombo.SelectedIndex > -1) { SearchBySupplierCombo.SelectedIndex = 0; }
            LoadStockInsBySupplier((int)SearchByCategoryCombo.SelectedValue, DateTime.Parse(SearchByDate.Text));
        }

        public async void LoadStockInsBySupplier(int ID, DateTime date)
        {
            ProgressSpinner.Spinning = true;
            ProgressSpinner.Visible = true;

            await Task.Run(() => {
                try
                {
                    using (SqlConnection Con = new SqlConnection(this.ConString))
                    {
                        SqlCommand command = new SqlCommand("LoadStockInsByCategory", Con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Categoty_ID", ID);
                        command.Parameters.AddWithValue("@Date", date);
                        SqlDataAdapter DA = new SqlDataAdapter(command);

                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        Action A = () => {
                            if (DS.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("No Result Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                CellGrid.DataSource = null;
                                ProgressSpinner.Visible = false;
                                ProgressSpinner.Spinning = false;
                                SearchByCategoryCombo.SelectedIndex = 0;
                                return;
                            }

                            CellGrid.DataSource = DS.Tables[0];

                            CellGrid.Columns[0].Visible = false;
                            CellGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            ProgressSpinner.Visible = false;
                            ProgressSpinner.Spinning = false;
                        };

                        BeginInvoke(A);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });
        }

        private async void forExcel_Click(object sender, EventArgs e)
        {
            if (CellGrid.Rows.Count <= 1)
            {
                MessageBox.Show("No Data to Export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CopyToClipBord();
                forExcel.Enabled = false;
                ExportSpinner.Visible = true;
                ExportSpinner.Spinning = true;

                await Task.Run(() => { ExportForExcel(CellGrid.Rows.Count); });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                forExcel.Enabled = true;
                ExportSpinner.Visible = false;
                ExportSpinner.Spinning = false;
            }
        }

        private void CopyToClipBord()
        {
            CellGrid.SelectAll();
            DataObject DO = CellGrid.GetClipboardContent();
            if (DO != null)
            {
                Clipboard.SetDataObject(DO);
            }
        }

        public void ExportForExcel(int Count)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application NewExcelApp = new Microsoft.Office.Interop.Excel.Application();
                NewExcelApp.Visible = true;
                object MissVal = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Workbook NewExcelWorkbook = NewExcelApp.Workbooks.Add(MissVal);
                Microsoft.Office.Interop.Excel.Worksheet NewExcelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)NewExcelWorkbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = NewExcelWorksheet.Cells[1, 1];
                CR.Select();
                NewExcelWorksheet.PasteSpecial(CR, MissVal, MissVal, MissVal, MissVal, MissVal, true);
                Microsoft.Office.Interop.Excel.Range Rng = (Microsoft.Office.Interop.Excel.Range)NewExcelWorksheet.get_Range("A1", "E" + (Count + 1).ToString());
                Rng.Columns.ColumnWidth = 20;
                NewExcelWorksheet.get_Range("A1", "E1").Font.Bold = true;
                NewExcelWorksheet.get_Range("A1", "E" + (Count + 1).ToString()).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                Rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (CellGrid.Rows.Count == 0)
            {
                MessageBox.Show("No Records to Print", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Print();
        }

        public void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Stock In Report";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Parse(SearchByDate.Text).ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "IMS";
            printer.FooterSpacing = 15;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;

            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(CellGrid);
        }

        public void ActionEnableForDeleteStockIn()
        {
            Delete.Enabled = true;
        }

        public void ActionDisbleForDeleteStockIn()
        {
            Delete.Enabled = false;
        }

        private async void Delete_Click(object sender, EventArgs e)
        {

            if (CellGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Multiple Selection Delete is Not Valied !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ID = (int)CellGrid.SelectedRows[0].Cells[0].Value;
            string ICode = CellGrid.SelectedRows[0].Cells[1].Value.ToString();
            CellGrid.Rows.RemoveAt(CellGrid.SelectedRows[0].Index);

            if (MessageBox.Show("Do You Want to Delete This Stock In Record ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            StockContext context = new StockContext();
            try
            {
                var StIn = await context.StockInItems.FirstOrDefaultAsync(sto => sto.StockInID == ID && sto.ItemID == ICode);
                context.StockInItems.Remove(StIn);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
                ActionDisbleForDeleteStockIn();
            }
        }

        private void CellGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            try
            {
                if (CellGrid.Rows[e.RowIndex].Cells[0].Value == null) return;
                ActionEnableForDeleteStockIn();
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
    
    }
}
