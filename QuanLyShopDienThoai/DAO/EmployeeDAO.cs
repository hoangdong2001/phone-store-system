using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }

        public bool InsertNV(string id, string name, string gender, string position, string year, string phone, string Address)
        {
            string query = string.Format("INSERT Employee (EmployeeID,FullName,Gender,Position,Birthday,PhoneNumber,Address) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", id, name, gender, position, year, phone, Address);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNV(string ID, string name, string gender, string position, string year, string phone, string Address)
        {
            string query = string.Format("UPDATE Employee SET FullName = N'{0}', Gender = N'{1}', Position = N'{2}', Birthday = N'{3}', PhoneNumber = N'{4}', Address = N'{5}' WHERE EmployeeID = '{6}'", name, gender, position, year, phone, Address, ID);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNV(string ID)
        {
            string query = "DELETE FROM Employee WHERE EmployeeID = '" + ID + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
