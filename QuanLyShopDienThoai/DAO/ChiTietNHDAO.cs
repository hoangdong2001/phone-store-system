using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO
{
    public class ChiTietNHDAO
    {
        private static ChiTietNHDAO instance;
        public static ChiTietNHDAO Instance
        {
            get { if (instance == null) instance = new ChiTietNHDAO(); return ChiTietNHDAO.instance; }
            private set { ChiTietNHDAO.instance = value; }
        }
        public bool InsertCTNH(int idnh, string idhh, string name, string from, float price, int num, float totalprice)
        {
            string query = "INSERT INTO ChiTietNH (MaNH,MaHH,TenHH,XuatXu,DonGia,SL,ThanhTien) VALUES (" + idnh + ",'" + idhh + "','" + name + "','" + from + "'," + price + "," + num + "," + totalprice + ")";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCTNH(string id)
        {
            string query = "DELETE FROM ChiTietNH WHERE MaHH = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
