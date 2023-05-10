using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }
        public bool InsertHH(string id, string name, string from, float price, int number)
        {
            string query = string.Format("INSERT Product (ProductID,ProductName,ProductOrigin,ProductPrice,Quantity) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", id, name, from, price, number);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHH(string id, string name, string from, float price, int number)
        {
            string query = string.Format("UPDATE Product SET ProductName = N'{0}', ProductOrigin = N'{1}', ProductPrice = N'{2}', Quantity = N'{3}' WHERE ProductID = '{4}'", name, from, price, number, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHH(string id)
        {
            string query = "DELETE FROM Product WHERE ProductID = '" + id + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
