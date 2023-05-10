using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO
{
    public class ImportDAO
    {
        private static ImportDAO instance;
        public static ImportDAO Instance
        {
            get { if (instance == null) instance = new ImportDAO(); return ImportDAO.instance; }
            private set { ImportDAO.instance = value; }
        }
        public bool InsertNH(int id, DateTime date)
        {
            string query = string.Format("INSERT Import (ImportID,ImportDate) VALUES ({0},N'{1}')", id, date);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNH(int id)
        {
            string query = "DELETE FROM Import WHERE ImportID = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
