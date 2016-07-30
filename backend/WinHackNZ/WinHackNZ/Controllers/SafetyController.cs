using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WinHackNZ.Helper;

namespace WinHackNZ.Controllers
{
    [RoutePrefix("api/Safety")]
    public class SafetyController : ApiController
    {
        // GET api/
        public string Get()
        {
            var endPoint = @"http:\\myRestService.com\api\";

            var client = new RestClient(endPoint);
            var json = client.MakeRequest();

            return json;
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