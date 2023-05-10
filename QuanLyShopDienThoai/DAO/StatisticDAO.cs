using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO
{
    public class StatisticDAO
    {
        private static StatisticDAO instance;

        public static StatisticDAO Instance
        {
            get { if (instance == null) instance = new StatisticDAO(); return StatisticDAO.instance; }
            private set { StatisticDAO.instance = value; }
        }

        public bool InsertTK(DateTime date)
        {
            string query = string.Format("INSERT Statistic (NgayTK) VALUES (N'{0}')", date);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTK(int id, float collect, float spend, float income)
        {
            string query = string.Format("UPDATE Statistic SET StatisticIncome = '{0}', StatisticOutcome = '{1}', Revenue = '{2}' WHERE ID = '{3}'", collect, spend, income, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTK(int id)
        {
            string query = "DELETE FROM Statistic WHERE ID = '" + id + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
