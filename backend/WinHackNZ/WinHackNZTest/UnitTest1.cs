using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinHackNZ.Helper;
using WinHackNZ.Controllers;
using Newtonsoft.Json.Linq;

namespace WinHackNZTest
{
    [TestClass]
    public class ExternalServices_Test
    {
        [TestMethod]
        public void Test_Get_Rental()
        {
            var x = ExternalServices.GetRentalData("Auckland");
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
                EmploymentRate = 1,
                HealthRating = 2,
                HouseSatisfaction = 4,
                LifeSatisfaction = 8,
                RegionalCrime = 10
            };

            var queryResult = QueryEngine.GetRankings(personalValues);

            var numberOneRegion = ((JProperty)queryResult.Last).Name;
            var newsObject = ExternalServices.GetBadCityNew(numberOneRegion);

            queryResult.Add("TopRegionNews", newsObject);

            Assert.IsNotNull(queryResult);
        }
    }
}
