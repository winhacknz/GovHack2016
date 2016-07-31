using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinHackNZ.Helper;
using WinHackNZ.Controllers;

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
        public void Test_Get_External_Data()
        {
            var x = ExternalServices.GetRegionData();
            Assert.IsNotNull(x);
        }

        [TestMethod]
        public void Test_QueryEngine()
        {
            var personalValues = new PersonalValues()
            {
                EmploymentRate = 10,
                HealthRating = 10,
                HouseSatisfaction = 10,
                LifeSatisfaction = 10,
                RegionalCrime = 10
            };

            var x = QueryEngine.GetRankings(personalValues);
            Assert.IsNotNull(x);
        }
    }
}
