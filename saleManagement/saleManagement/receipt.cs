using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace saleManagement
{
    public partial class receipt : Form
    {
        public SqlConnection con = new SqlConnection();
        public String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;
       
        public receipt()
        {
            InitializeComponent();
            con.ConnectionString = strConn;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.itemGridView.Rows.Add(tbIdItem.Text, tbNameItem.Text, tbQuantity.Text, tbPrice.Text);
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            string idReceipt = tbIdReceipt.Text;
            string idAccountant = tbIdAccountant.Text;
            var createDates = createDate.Value;
            int year = createDates.Year;
            int month = createDates.Month;
            int day = createDates.Day;

            string creationDate = string.Format("{0}/{1}/{2}", month, day, year);
            addReceipt(idReceipt, idAccountant, creationDate);
            for (int i = 0; i < itemGridView.Rows.Count; i++)
            {
                string idItem = itemGridView.Rows[i].Cells[0].Value.ToString();
                string nameItem = itemGridView.Rows[i].Cells[1].Value.ToString();
                string quantity = itemGridView.Rows[i].Cells[2].Value.ToString();
                string price = itemGridView.Rows[i].Cells[3].Value.ToString();
                if (isItemExist(idItem))
                {
                    addDetailReceipt(idReceipt, idItem, quantity, price);
                    updateInventory(idItem, quantity);
                }
                else
                {
                    addNewItem(idItem, nameItem);
                    addDetailReceipt(idReceipt, idItem, quantity, price);
                    updateInventory(idItem, quantity);
                }
            }
            updateTotalPrice(idReceipt);
            clearInput();
            MessageBox.Show("Create receipt successfully!");
        }

        private void clearInput()
        {
            tbIdReceipt.Text = "";
            tbIdAccountant.Text = "";
            createDate.Value = DateTime.Now;
            tbIdItem.Text = "";
            tbNameItem.Text = "";
            tbQuantity.Text = "";
            tbPrice.Text = "";

            itemGridView.Rows.Clear();
            itemGridView.Refresh();
        }

        //GET FROM DATABASE
        public Boolean isItemExist(String idItem)
        {
            int count = 0;
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "Select count(*) from item where idItem = '"+ idItem +"'";

            command = new SqlCommand(sql, con);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }
            count = Int32.Parse(Output);
            dataReader.Close();
            command.Dispose();
            con.Close();
            if (count > 0)
                return true;
            else
                return false;
        }

        //INSERT TO DATABASE
        private void addReceipt(string idReceipt, string idAccountant, string creationDate)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Insert into receipt values('" + idReceipt + "','" + idAccountant + "','" + creationDate.ToString()+"','')";

            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }
        private void addDetailReceipt(string idReceipt, string idItem, string quantity, string price)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "Insert into detailReceipt values('" + idReceipt + "','" + idItem + "'," + quantity+","+price+")";

            command = new SqlCommand(sql, con);

            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        private void addNewItem(string idItem, string nameItem)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "Insert into item values('" + idItem + "','" + nameItem + "', 0)"; 

            command = new SqlCommand(sql, con);

            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        //UPDATE TO DATABASE
        private void updateInventory(string idItem, string quantity)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "Update item set inventory = inventory + "+quantity+"where idItem = '"+idItem+"'";

            command = new SqlCommand(sql, con);

            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        private void updateTotalPrice(string idReceipt)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "update receipt set totalPrice = (select sum(price * quantity) as amount from detailReceipt where idReceipt = '"+idReceipt+ "') where idReceipt = '" + idReceipt + "'";

            command = new SqlCommand(sql, con);

            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleManagementDataSet.detailReceipt' table. You can move, or remove it, as needed.
            this.detailReceiptTableAdapter.Fill(this.saleManagementDataSet.detailReceipt);
            // TODO: This line of code loads data into the 'saleManagementDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.saleManagementDataSet.receipt);

        }

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            export2Excel(dataGridView1, @"C:\", "receipt");
        }
    }
}
