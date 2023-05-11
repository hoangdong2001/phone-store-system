using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace saleManagement
{
    public partial class item : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;
        public item()
        {
            InitializeComponent();
            con.ConnectionString = strConn;
        }

        private void item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleManagementDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.saleManagementDataSet.item);

        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            saleManagementDataSet.itemRow item = this.saleManagementDataSet.item.AdditemRow(tbIdItem.Text, tbNameItem.Text, 0);
            this.itemTableAdapter.Update(item);

            MessageBox.Show("Add item successfully");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.itemGridView.Rows[e.RowIndex];
            tbIdItem.Text = row.Cells[0].Value.ToString();
            tbNameItem.Text = row.Cells[1].Value.ToString();
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            tbIdItem.Text = "";
            tbNameItem.Text = "";
            itemGridView.ClearSelection();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.itemGridView.CurrentCell.RowIndex;
            saleManagementDataSet.itemRow item = (saleManagementDataSet.itemRow) this.saleManagementDataSet.item.Rows[rowIndex];
            item.idItem = tbIdItem.Text;
            item.nameItem = tbNameItem.Text;

            this.itemTableAdapter.Update(item);

            MessageBox.Show("Update item successfully");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure", "Item Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int rowIndex = this.itemGridView.CurrentCell.RowIndex;
                saleManagementDataSet.itemRow item = (saleManagementDataSet.itemRow)this.saleManagementDataSet.item.Rows[rowIndex];
                item.Delete();
                this.itemTableAdapter.Update(item);

                MessageBox.Show("Item has been deleted successfully");
            }
        }
    }
}
