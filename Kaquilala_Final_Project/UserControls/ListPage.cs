using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kaquilala_Final_Project.UserControls
{
    public partial class ListPage : UserControl
    {
        string selectedProductName = "";
        int selectedRowIndex;
        string selectedCellValue;
        public ListPage()
        {
            InitializeComponent();
        }

        private void ListPage_Load(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;Jet OLEDB:Database Password=haruglory");
            string query1 = "SELECT ProductCategory FROM tbl_itemList";
            LoadTable1();

            HashSet<string> uniqueValues = new HashSet<string>();

            using (conn)
            {
                OleDbCommand command = new OleDbCommand(query1, conn);
                conn.Open();

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        object value = reader.GetValue(0);
                        if (value != DBNull.Value)
                        {
                            string category = value.ToString();
                            uniqueValues.Add(category);
                        }
                    }
                }
            }
            CategoryCbox.Items.AddRange(uniqueValues.ToArray());
        }

        private void CategoryCbox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;Jet OLEDB:Database Password=haruglory");
            string query2 = "SELECT * FROM tbl_itemlist WHERE ProductCategory = '" + CategoryCbox.SelectedItem.ToString() + "'";
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(query2, conn);
            DataTable table = new DataTable();
            da.Fill(table);
            ItemList.DataSource = table;
            ItemList.Columns["ID"].Visible = false;
            ItemList.Columns["ProductCategory"].Visible = false;
            ItemList.Columns["Price"].DefaultCellStyle.Format = "₱0.00";
            conn.Close();
        }
        private void ItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProductName = ItemList.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            }
        }

        private void Add_Entry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedProductName))
            {
                if (quantity.Value <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.");
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;Jet OLEDB:Database Password=haruglory"))
                {
                    conn.Open();
                    OleDbCommand selectCommand = new OleDbCommand("SELECT [Price] FROM [tbl_itemList] WHERE [ProductName] = @name", conn);
                    selectCommand.Parameters.AddWithValue("@name", selectedProductName);
                    decimal currencyValue = (decimal)selectCommand.ExecuteScalar();

                    decimal totalValue = currencyValue * Convert.ToInt32(quantity.Value);

                    string register = "INSERT INTO tbl_list VALUES ('" + LoginForm.uname + "', '" + CategoryCbox.SelectedItem.ToString() + "', '" + selectedProductName + "', '" + Convert.ToInt32(quantity.Value) + "', '" + currencyValue + "', '" + totalValue + "' )";
                    OleDbCommand insertCommand = new OleDbCommand(register, conn);
                    insertCommand.ExecuteNonQuery();

                    conn.Close();
                }
                LoadTable1();
            }
        }

        private void LoadTable1()
        {

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;Jet OLEDB:Database Password=haruglory");
            string query2 = "SELECT * FROM tbl_list WHERE username = '" + LoginForm.uname + "'";
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(query2, conn);
            DataTable table = new DataTable();
            da.Fill(table);
            GroceryList.DataSource = table;
            GroceryList.Columns["Username"].Visible = false;
            GroceryList.Columns["PerUnitPrice"].DefaultCellStyle.Format = "₱0.00";
            GroceryList.Columns["TotalPrice"].DefaultCellStyle.Format = "₱0.00";

            decimal totalCost = table.AsEnumerable().Sum(row => row.Field<decimal>("TotalPrice"));
            TotPrice.Text = $"Total Cost: ₱{totalCost:0.00}";
            int totalItems = GroceryList.Rows.Count - 1;
            NoItem.Text = Convert.ToString(totalItems);
            conn.Close();
        }

        private void GroceryList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            string rowNumber = (e.RowIndex + 1).ToString();

            Rectangle rowBounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, GroceryList.RowHeadersWidth - 4, e.RowBounds.Height);

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;


            e.Graphics.DrawString(rowNumber, this.Font, SystemBrushes.ControlText, rowBounds, centerFormat);
        }

        private void ItemList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();

            Rectangle rowBounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, ItemList.RowHeadersWidth - 4, e.RowBounds.Height);

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;


            e.Graphics.DrawString(rowNumber, this.Font, SystemBrushes.ControlText, rowBounds, centerFormat);
        }
 
        private void GroceryList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                selectedCellValue = GroceryList.Rows[selectedRowIndex].Cells["Quantity"].Value.ToString();
            }
        }

        private void Edit_Quant_Click(object sender, EventArgs e)
        {
            GroceryList.Rows[selectedRowIndex].Cells["Quantity"].Value = quantity.Value;
        }

        private void Del_Entry_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < GroceryList.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GroceryList.Rows.RemoveAt(selectedRowIndex);
                }
            }
        }
    }
}
