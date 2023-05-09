using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO instance;
        public static HangHoaDAO Instance
        {
            get { if (instance == null) instance = new HangHoaDAO(); return HangHoaDAO.instance; }
            private set { HangHoaDAO.instance = value; }
        }
        public bool InsertHH(string id, string name, string from, float price, int number)
        {
            string query = string.Format("INSERT HangHoa (MaHH,TenHH,XuatXu,GiaBan,SL) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", id, name, from, price, number);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHH(string id, string name, string from, float price, int number)
        {
            string query = string.Format("UPDATE HangHoa SET TenHH = N'{0}', XuatXu = N'{1}', GiaBan = N'{2}', SL = N'{3}' WHERE MaHH = '{4}'", name, from, price, number, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHH(string id)
        {
            string query = "DELETE FROM HangHoa WHERE MaHH = '" + id + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
