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
    public class EmployeeDAOTests
    {
        [TestMethod()]
        public void InsertNVTest()
        {
            try
            {
                EmployeeDAO.Instance.InsertNV("3", "new staff", "nữ", "nhân viên bán hàng", "2000", "51800xxx", "HCM");
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
                EmployeeDAO.Instance.UpdateNV("3", "update new staff", "nữ", "nhân viên kho", "2000", "51800xxx", "HCM");
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
                EmployeeDAO.Instance.DeleteNV("3");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Nhan viên không tồn tại", ex.Message);
            }
        }
    }
}