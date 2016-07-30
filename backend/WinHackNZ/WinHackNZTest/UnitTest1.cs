using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinHackNZ.Helper;

namespace WinHackNZTest
{
    [TestClass]
    public class ExternalServices_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = ExternalServices.GetRentalData();
            Assert.IsNotNull(x);
        }
    }
}
