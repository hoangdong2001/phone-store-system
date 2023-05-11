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
    public partial class revenueMonthly : Form
    {
        SqlConnection con = new SqlConnection();
        String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;
        public revenueMonthly()
        {
            InitializeComponent();
            con.ConnectionString = strConn;
            getRevenueMonthly();
        }

        private void getRevenueMonthly()
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            string sql = "";
            sql = "select year(rc.creationDate) as year, month(rc.creationDate) as month, (sum(ord.totalPrice)-sum(rc.totalPrice)) as revenue from orders ord, deliveryBill db, receipt rc where ord.idOrder = db.idOrder and month(ord.creationDate) = month(rc.creationDate) group by month(rc.creationDate), year(rc.creationDate) order by month(rc.creationDate), year(rc.creationDate)";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            revenueMonthlyGridView.DataSource = dt;
            con.Close();
        }
    }
}
