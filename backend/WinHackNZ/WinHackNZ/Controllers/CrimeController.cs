﻿using System;
using System.Web.Configuration;
using System.Web.Http;
using WinHackNZ.Helper;

namespace WinHackNZ.Controllers
{
    [RoutePrefix("api/crime")]
    public class CrimeController : ApiController
    {
        private string getDataSrcPath()
        {
            var name = WebConfigurationManager.AppSettings["DataStoreSwitch"];

            return DataStoreSwitch.GetSwitchBy(name);
        }

        // GET api/<controller>
        public string Get()
        {
            var dataSrcPath = getDataSrcPath();

            var result = "";

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