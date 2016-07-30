using Newtonsoft.Json.Linq;
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
            var dataParameters    = HttpUtility.ParseQueryString(Request.RequestUri.Query);
            var personalValues    = new PersonalValues(dataParameters);
            var queryResult       = QueryEngine.GetRankings(personalValues);

            return queryResult;
        }       
    }
}
