using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO
{
    public class ImportDetailDAO
    {
        private static ImportDetailDAO instance;
        public static ImportDetailDAO Instance
        {
            get { if (instance == null) instance = new ImportDetailDAO(); return ImportDetailDAO.instance; }
            private set { ImportDetailDAO.instance = value; }
        }
        public bool InsertCTNH(int idnh, string idhh, string name, string from, float price, int num, float totalprice)
        {
            string query = "INSERT INTO ImportDetail (ImportID,ProductID,ProductName,ProductOrigin,Price,Quantity,TotalPrice) VALUES (" + idnh + ",'" + idhh + "','" + name + "','" + from + "'," + price + "," + num + "," + totalprice + ")";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCTNH(string id)
        {
            string query = "DELETE FROM ImportDetail WHERE ProductID = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
