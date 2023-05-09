using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLShopDienThoai;Integrated Security=True"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string query)
        {
            int data=0;
            using (SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLShopDienThoai;Integrated Security=True"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                data = command.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        public string ExcuteScalar(string query)
        {
            string data;
            using (SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLShopDienThoai;Integrated Security=True"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                data = command.ExecuteScalar().ToString();
                con.Close();
            }
            return data;
        }

    }
}
