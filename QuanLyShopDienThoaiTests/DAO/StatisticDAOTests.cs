using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneStoreSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreSystem.DAO.Tests
{
    [TestClass()]
    public class StatisticDAOTests
    {
        [TestMethod()]
        public void InsertTKTest()
        {
            try
            {
                StatisticDAO.Instance.InsertTK(DateTime.Now);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
        }

        [TestMethod()]
        public void DeleteTKTest()
        {
            try
            {
                StatisticDAO.Instance.DeleteTK(1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
            DataProvider.Instance.ExcuteNonQuery("DBCC CHECKIDENT ('ThongKe', RESEED, 0)");
        }
    }
}