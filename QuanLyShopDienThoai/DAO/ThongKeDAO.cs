using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return ThongKeDAO.instance; }
            private set { ThongKeDAO.instance = value; }
        }

        public bool InsertTK(DateTime date)
        {
            string query = string.Format("INSERT ThongKe (NgayTK) VALUES (N'{0}')", date);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTK(int id, float collect, float spend, float income)
        {
            string query = string.Format("UPDATE ThongKe SET Thu = '{0}', Chi = '{1}', DoanhThu = '{2}' WHERE ID = '{3}'", collect, spend, income, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTK(int id)
        {
            string query = "DELETE FROM ThongKe WHERE ID = '" + id + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
