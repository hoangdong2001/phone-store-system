using Microsoft.VisualStudio.TestTools.UnitTesting;
using saleManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace saleManagement.Tests
{
    [TestClass()]
    public class receiptTests
    {
        [TestMethod()]
        public void isItemExistTest()
        {
            receipt formReceipt = new receipt();

            var createControl = formReceipt.GetType().GetMethod("CreateControl",
                BindingFlags.Instance | BindingFlags.NonPublic);
            createControl.Invoke(formReceipt, new object[] { true });

            string input = "it1";
            bool expected = true;
            formReceipt.ShowDialog();
            bool actual = formReceipt.isItemExist(input);
            Assert.AreEqual(expected, actual);
        }
    }
}