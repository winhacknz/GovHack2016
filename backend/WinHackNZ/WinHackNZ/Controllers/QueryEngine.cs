using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using WinHackNZ.Helper;
using System.Linq;

namespace WinHackNZ.Controllers
{
    public class QueryEngine
    {
        public static JObject GetRankings(PersonalValues personalValues)
        {
            var regionData = ExternalServices.GetRegionData();
            var results = new SortedDictionary<string, PersonalValues>();

            for (int i = 0; i < 15; i++)
            {
                var personalResults               = new PersonalValues();
                var region                        = regionData["rows"][0]["doc"][i.ToString()]["Regional_Council"].ToString();
                personalResults.EmploymentRate    = float.Parse(regionData["rows"][0]["doc"][i.ToString()]["Employment_rate"].ToString()) * personalValues.EmploymentRate;
                personalResults.RegionalCrime     = float.Parse(regionData["rows"][0]["doc"][i.ToString()]["Security"].ToString()) * personalValues.RegionalCrime;
                personalResults.LifeSatisfaction  = float.Parse(regionData["rows"][0]["doc"][i.ToString()]["Life_sat"].ToString()) * personalValues.LifeSatisfaction;
                personalResults.HouseSatisfaction = float.Parse(regionData["rows"][0]["doc"][i.ToString()]["House"].ToString()) * personalValues.HouseSatisfaction;
                personalResults.HealthRating      = float.Parse(regionData["rows"][0]["doc"][i.ToString()]["Health_self"].ToString()) * personalValues.HealthRating;
                personalResults.TotalWeighting    = personalResults.EmploymentRate + personalResults.HealthRating + personalResults.RegionalCrime + personalResults.LifeSatisfaction;

                results[region] = personalResults;
            }

            var orderedResults = results.OrderByDescending(x => x.Value.TotalWeighting).ToDictionary(k => k.Key, v => v.Value);

            return JObject.Parse(JsonConvert.SerializeObject(orderedResults));             
        }
    }
}