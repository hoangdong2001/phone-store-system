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
    public class HangHoaDAOTests
    {
        [TestMethod()]
        public void InsertHHTest()
        {
            try
            {
                HangHoaDAO.Instance.InsertHH("4", "product name", "from", 5000, 20);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mã hàng hóa đã tồn tại", ex.Message);
            }
        }

        [TestMethod()]
        public void UpdateHHTest()
        {
            try
            {
                HangHoaDAO.Instance.UpdateHH("4", "update product name", "from", 7000, 20);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mã hàng hóa đã tồn tại", ex.Message);
            }
        }

        [TestMethod()]
        public void DeleteHHTest()
        {
            try
            {
                HangHoaDAO.Instance.DeleteHH("4");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Hàng hóa không tồn tại", ex.Message);
            }
        }
    }
}