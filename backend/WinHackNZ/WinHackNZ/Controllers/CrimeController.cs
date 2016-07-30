using System.Web.Http;
using WinHackNZ.Helper;

namespace WinHackNZ.Controllers
{
    [RoutePrefix("api/crime")]
    public class CrimeController : ApiController
    {
        DataStore dbStore = new DataStore();
        
        // GET api/<controller>
        public string Get()
        {
            // TODO: remove testing code
            var dimension = "housing";
            var category = "Housing";
            var result = dbStore.GetDataBy(category, dimension);
            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}