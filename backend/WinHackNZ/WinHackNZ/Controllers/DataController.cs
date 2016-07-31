using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using WinHackNZ.Helper;

namespace WinHackNZ.Controllers
{
    public class DataController : ApiController
    {        
        // GET: api/Data/5
        public JObject Get()
        {
            var regions           = GetRegionCodes();
            var dataParameters    = HttpUtility.ParseQueryString(Request.RequestUri.Query);
            var personalValues    = new PersonalValues(dataParameters);
            var queryResult       = QueryEngine.GetRankings(personalValues);
            var numberOneRegion   = ((JProperty)queryResult.First).Name;
            //var regionID          = regions[numberOneRegion];
            var newsObject        = ExternalServices.GetBadCityNew(numberOneRegion);
            //var rentals           = ExternalServices.GetRentalData(regionID);

            queryResult.Add("TopRegionNews", newsObject); 

            return queryResult;
        }       

        public Dictionary<string, int> GetRegionCodes()
        {
            Dictionary<string, int> regions = new Dictionary<string, int>();

            regions["Wellington"]        = 15;
            regions["Canterbury"]        = 3;
            regions["Auckland"]          = 1;
            regions["Otago"]             = 15;
            regions["Bay of Plenty"]     = 5;
            regions["Hawke's Bay"]       = 6;
            regions["Taranaki"]          = 12;
            regions["Waikato"]           = 14;
            regions["Manawatu-Wanganui"] = 8;
            regions["Tasman/Nelson"]     = 8;
            regions["Gisborne"]          = 5;
            regions["Northland"]         = 1;
            regions["West Coast"]        = 13;
            regions["Tasman"]            = 10;
            regions["Marlborough"]       = 12;
            regions["Southland"]         = 16;

            return regions;
        }
    }
}
