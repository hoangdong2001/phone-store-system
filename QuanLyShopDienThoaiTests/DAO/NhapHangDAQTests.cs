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
    public class NhapHangDAQTests
    {
        [TestMethod()]
        public void InsertNHTest()
        {
            try
            {
                NhapHangDAO.Instance.InsertNH(2, DateTime.Today);
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
                NhapHangDAO.Instance.DeleteNH(2);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
        }
    }
}