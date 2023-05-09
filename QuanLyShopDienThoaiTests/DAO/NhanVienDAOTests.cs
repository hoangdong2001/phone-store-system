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
    public class NhanVienDAOTests
    {
        [TestMethod()]
        public void InsertNVTest()
        {
            try
            {
                NhanVienDAO.Instance.InsertNV("3", "new staff", "nữ", "nhân viên bán hàng", "2000", "51800xxx", "HCM");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mã nhân viên đã tồn tại", ex.Message);
            }
        }

        [TestMethod()]
        public void UpdateNVTest()
        {
            try
            {
                NhanVienDAO.Instance.UpdateNV("3", "update new staff", "nữ", "nhân viên kho", "2000", "51800xxx", "HCM");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mã nhân viên đã tồn tại", ex.Message);
            }
        }

        [TestMethod()]
        public void DeleteNVTest()
        {
            try
            {
                NhanVienDAO.Instance.DeleteNV("3");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Nhan viên không tồn tại", ex.Message);
            }
        }
    }
}