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

namespace saleManagement
{
    public partial class statistical : Form
    {
        SqlConnection con = new SqlConnection();
        String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;
        public statistical()
        {
            InitializeComponent();
            con.ConnectionString = strConn;
            getIncomingStock();
            getOutgoingStock();
        }

        private void getIncomingStock()
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            string sql = "";
            sql = "select i.nameItem, sum(quantity) as quantity, sum(quantity*price) as totalMoney from detailReceipt dr, item i where dr.idItem = i.idItem group by  i.nameItem ";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            incomingStockGridView.DataSource = dt;
            con.Close();
        }
        private void getOutgoingStock()
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            string sql = "";
            sql = "select i.nameItem, sum(quantity) as quantity, sum(quantity*price) as totalMoney from detailOrder orders, item i where orders.idItem = i.idItem group by  i.nameItem ";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            outgoingStockGridView.DataSource = dt;
            con.Close();
        }
    }
}
