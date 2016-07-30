using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinHackNZ.Helper;

namespace WinHackNZTest
{
    [TestClass]
    public class ExternalServices_Test
    {
        [TestMethod]
        public void Test_Get_Rental()
        {
            var x = ExternalServices.GetRentalData();
            Assert.IsNotNull(x);
        }

        [TestMethod]
        public void Test_Get_City_News()
        {
            var x = ExternalServices.GetBadCityNew("Auckland");
            Assert.IsNotNull(x);
        }

        [TestMethod]
        public void Test_Get_External_Date()
        {
            var x = ExternalServices.GetRegionData();
            Assert.IsNotNull(x);
        }
    }
}
