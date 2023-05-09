using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        public bool InsertNV(string id, string name, string gender, string position, string year, string phone, string Address)
        {
            string query = string.Format("INSERT NhanVien (MaNV,Hoten,Gioi,ChucVu,NamSinh,SDT,DiaChi) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", id, name, gender, position, year, phone, Address);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNV(string ID, string name, string gender, string position, string year, string phone, string Address)
        {
            string query = string.Format("UPDATE NhanVien SET Hoten = N'{0}', Gioi = N'{1}', ChucVu = N'{2}', NamSinh = N'{3}', SDT = N'{4}', DiaChi = N'{5}' WHERE MaNV = '{6}'", name, gender, position, year, phone, Address, ID);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNV(string ID)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = '" + ID + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
