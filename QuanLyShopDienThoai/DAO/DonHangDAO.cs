using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class DonHangDAO
    {
        private static DonHangDAO instance;
        public static DonHangDAO Instance
        {
            get { if (instance == null) instance = new DonHangDAO(); return DonHangDAO.instance; }
            private set { DonHangDAO.instance = value; }
        }
        public bool InsertDH(int idhd, string idhh, string name, float price, int num, float totalprice)
        {
            string query = string.Format("INSERT DonHang (SoHD, MaHH, TenHH, DonGia, SL, ThanhTien) VALUES ('{0}',N'{1}',N'{2}','{3}','{4}','{5}')", idhd, idhh, name, price, num, totalprice);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDH(string id)
        {
            string query =  "DELETE FROM DonHang WHERE MaHH = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
