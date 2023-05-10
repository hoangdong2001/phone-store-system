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
    public class ImportDAOTests
    {
        [TestMethod()]
        public void InsertNHTest()
        {
            try
            {
                ImportDAO.Instance.InsertNH(2, DateTime.Today);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
        }

        [TestMethod()]
        public void DeleteNHTest()
        {
            try
            {
                ImportDAO.Instance.DeleteNH(2);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
        }
    }
}