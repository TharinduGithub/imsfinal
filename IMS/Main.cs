using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using IMS.Models.Contexts;
using IMS.Models;
using System.Data.Entity;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TableDependency.SqlClient;
using System.Configuration;

namespace IMS
{

    public partial class Main : MetroForm
    {
        public Main()
        {
            try
            {
                Application.Run(new Login());
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                if (e.InnerException != null)
                {
                    MessageBox.Show(e.InnerException.Message);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (Program.IsAuthenticated)
                {
                    this.User_Name.Text = Program.User;
                    CreateProfile(Program.User);

                    if (Program.UserRoll == "Administrator")
                    {
                        this.Title.Text = "Inventory Management System (Administrator)";
                    }
                    else if (Program.IsAuthenticated && Program.UserRoll == "User")
                    {
                        this.Title.Text = "Inventory Management System";
                        this.AdminPanal.Hide();
                        this.SearchPanal.Location = new Point(181, 3);
                        this.ExportPanal.Location = new Point(728, 7);
                        this.HeadPanal.Height = 85;
                        this.ItemCellGrid.Height = 515;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            finally
            {
                LoadCategories();
            }

        }

        public async void CreateProfile(string User)
        {
            try
            {
                UserDataContext context = new UserDataContext();
                UserData userData = await context.UsersData.SingleOrDefaultAsync(user => user.Username == User);
                if (userData == null) return;
                Action A = () =>
                {

                    User_Name.Text = userData.FirstName;
                    if (userData.Picture != null)
                    {
                        MemoryStream MS = new MemoryStream(userData.Picture);
                        pictureBox1.Image = System.Drawing.Image.FromStream(MS);
                    }
                };
                BeginInvoke(A);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                if (e.InnerException != null)
                {
                    MessageBox.Show(e.InnerException.Message);
                }
            }

        }

        private void LgOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

        public void Logout()
        {
            this.Close();
            try
            {
                Thread T1 = new Thread(delegate ()
                {
                    Application.Run(new Main());
                });

                T1.SetApartmentState(ApartmentState.STA);
                T1.Start();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                if (e.InnerException != null)
                {
                    MessageBox.Show(e.InnerException.Message);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Label L = this.User_Name;
            PictureBox P = this.pictureBox1;

            Edit edit = new IMS.Edit(ref L, ref P);
            edit.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ComboBox Combo = CategoryCombo;
            Category Cat = new Category(LoadCategories);
            Cat.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Items I = new Items();
            I.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            VendorForm V = new VendorForm();
            V.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SupplierForm S = new SupplierForm();
            S.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ReceverForm C = new ReceverForm();
            C.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StockInForm S = new StockInForm();
            S.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            StockOutForm S = new StockOutForm();
            S.ShowDialog();
        }

        public void AddResultToGrid(IEnumerable<Item> Collection)
        {
            ItemCellGrid.Rows.Clear();

            foreach (var item in Collection)
            {
                DataGridViewRow Row = (DataGridViewRow)ItemCellGrid.Rows[0].Clone();

                Row.Cells[0].Value = item.ItemID;
                Row.Cells[1].Value = item.ItemName;
                Row.Cells[2].Value = item.Category.Code;
                Row.Cells[3].Value = item.Category.Name;
                Row.Cells[4].Value = item.currentQuntity;

                ItemCellGrid.Rows.Add(Row);

            }
        }



        public async void LoadCategories()
        {
            ItemContext context = new ItemContext();
            try
            {
                List<IMS.Models.Category> Cats = await context.Categories.ToListAsync();
                if (Cats.Count == 0) return;
                BindResultToCategoryCombo(Cats);

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

        public void BindResultToCategoryCombo(List<IMS.Models.Category> Collection)
        {
            Action A = () =>
            {
                Collection.Insert(0, new Models.Category() { Name = "Select Category Here ...", ID = 0 });
                CategoryCombo.DisplayMember = "Name";
                CategoryCombo.ValueMember = "ID";
                CategoryCombo.DataSource = Collection;
            };

            BeginInvoke(A);

        }

        private async void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCombo.SelectedIndex <= 0)
            {
                ItemCellGrid.Rows.Clear();
                return;
            }

            ItemContext context = new ItemContext();
            try
            {
                var ID = (int)CategoryCombo.SelectedValue;
                List<Item> Items = await context.Items.Include("Category").Where(itm => itm.Category.ID == ID).ToListAsync();
                if (Items.Count == 0)
                {
                    Action A = () =>
                    {
                        ItemCellGrid.Rows.Clear();
                        MessageBox.Show("No Item Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    };
                    BeginInvoke(A);
                    return;
                }
                AddResultToGrid(Items);

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

        private void SerchByName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SearchByName.Text == string.Empty)
            {
                ItemCellGrid.Rows.Clear();
                return;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                FindItems(SearchByName.Text);
            }
        }

        public void FindItems(string Text)
        {
            ItemContext context = new ItemContext();

            try
            {
                var items = from i in context.Items.Include("Category")
                            where i.ItemName.Contains(Text) || i.ItemID == Text
                            select i;
                if (items.Count() == 0)
                {
                    ItemCellGrid.Rows.Clear();
                    MessageBox.Show("No Item Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                AddResultToGrid(items);
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            UsersForm U = new UsersForm();
            U.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            BackUpForm backUpForm = new BackUpForm();
            backUpForm.ShowDialog();
        }

        private async void forExcel_Click(object sender, EventArgs e)
        {
            if (ItemCellGrid.Rows.Count <= 1)
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

                await Task.Run(() => { ExportForExcel(ItemCellGrid.Rows.Count); });
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
            ItemCellGrid.SelectAll();
            DataObject DO = ItemCellGrid.GetClipboardContent();
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
                Rng.Borders.Weight = 1d;


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private async void forPdf_Click(object sender, EventArgs e)
        {
            if (ItemCellGrid.Rows.Count <= 1)
            {
                MessageBox.Show("No Data to Export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            string path = string.Empty;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath;
            }
            else
            {
                return;
            }

            try
            {
                forPdf.Enabled = false;
                ExportSpinner.Visible = true;
                ExportSpinner.Spinning = true;

                await Task.Run(() => { ExportForPdf(path); });
                MessageBox.Show("Successfully Exported !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                forPdf.Enabled = true;
                ExportSpinner.Visible = false;
                ExportSpinner.Spinning = false;
            }

        }

        private void ExportForPdf(string path)
        {
            Document Doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(Doc, new FileStream(path + "\\IMS_Item_Data-" + DateTime.Now.Ticks.ToString() + ".pdf", FileMode.Create));
            Doc.Open();
            DataTable dt = (DataTable)ItemCellGrid.DataSource;
            Doc.AddTitle("\t\tIMS Current Item info\n");
            Doc.Add(createDataTable());
            Doc.Close();
        }

        private PdfPTable createDataTable()
        {
            PdfPTable TB = new PdfPTable(5);
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);

            TB.AddCell(new Phrase("Item Code", font5));
            TB.AddCell(new Phrase("Item Name", font5));
            TB.AddCell(new Phrase("Category Code", font5));
            TB.AddCell(new Phrase("Category", font5));
            TB.AddCell(new Phrase("Available Quntity", font5));

            for (int i = 0; i < ItemCellGrid.Rows.Count - 1; i++)
            {
                TB.AddCell(new Phrase(ItemCellGrid.Rows[i].Cells[0].Value.ToString(), font5));
                TB.AddCell(new Phrase(ItemCellGrid.Rows[i].Cells[1].Value.ToString(), font5));
                TB.AddCell(new Phrase(ItemCellGrid.Rows[i].Cells[2].Value.ToString(), font5));
                TB.AddCell(new Phrase(ItemCellGrid.Rows[i].Cells[3].Value.ToString(), font5));
                TB.AddCell(new Phrase(ItemCellGrid.Rows[i].Cells[4].Value.ToString(), font5));
            }

            return TB;


        }
    }
}