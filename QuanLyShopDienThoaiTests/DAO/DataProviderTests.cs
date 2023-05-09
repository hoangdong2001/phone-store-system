using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyShopDienThoai.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopDienThoai.DAO.Tests
{
    [TestClass()]
    public class DataProviderTests
    {
        [TestMethod()]
        public void ExcuteQueryTest()
        {
            try
            {
                DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM NhanVien");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
        }

        [TestMethod()]
        public void ExcuteNonQueryTest()
        {
            try
            {
                int result = DataProvider.Instance.ExcuteNonQuery("SELECT * FROM NhanVien");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Lỗi truy vấn dữ liệu", ex.Message);
            }
        }
    }
}