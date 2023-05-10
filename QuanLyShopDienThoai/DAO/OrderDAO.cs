using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return OrderDAO.instance; }
            private set { OrderDAO.instance = value; }
        }
        public bool InsertDH(int idhd, string idhh, string name, float price, int num, float totalprice)
        {
            string query = string.Format("INSERT Order (OrderNumber, ProductID, ProductName, Price, Quantity, TotalPrice) VALUES ('{0}',N'{1}',N'{2}','{3}','{4}','{5}')", idhd, idhh, name, price, num, totalprice);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDH(string id)
        {
            string query =  "DELETE FROM Order WHERE ProductID = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
