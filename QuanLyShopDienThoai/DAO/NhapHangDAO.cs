using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class NhapHangDAO
    {
        private static NhapHangDAO instance;
        public static NhapHangDAO Instance
        {
            get { if (instance == null) instance = new NhapHangDAO(); return NhapHangDAO.instance; }
            private set { NhapHangDAO.instance = value; }
        }
        public bool InsertNH(int id, DateTime date)
        {
            string query = string.Format("INSERT NhapHang (MaNH,NgayNH) VALUES ({0},N'{1}')", id, date);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNH(int id)
        {
            string query = "DELETE FROM NhapHang WHERE MaNH = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
