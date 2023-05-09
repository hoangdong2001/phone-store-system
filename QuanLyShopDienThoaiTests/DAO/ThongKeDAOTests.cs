using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyShopDienThoai.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO.Tests
{
    [TestClass()]
    public class ThongKeDAOTests
    {
        [TestMethod()]
        public void InsertTKTest()
        {
            try
            {
                ThongKeDAO.Instance.InsertTK(DateTime.Now);
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
                ThongKeDAO.Instance.DeleteTK(1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
            DataProvider.Instance.ExcuteNonQuery("DBCC CHECKIDENT ('ThongKe', RESEED, 0)");
        }
    }
}