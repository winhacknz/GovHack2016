using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Configuration;
using Newtonsoft.Json;

namespace WinHackNZ.Helper
{
    public class DataStore
    {
        private string name;
        private string rootPath;
        private bool skip;


        // TODO: a hack to mimic js data structure. probably need to rethink it.
        private DataStore[] switches = new DataStore[]
                        {
                             new DataStore(){ name = "STUB", rootPath = "/stubs", skip = false},
                             new DataStore(){ name = "API", rootPath = "", skip = false},
                             // if it is remote db, we specify db conn in web.config.
                             // so in this case, we should skip data store.
                             new DataStore(){ name = "REMOTE_DB", rootPath = "", skip=true}
                        };

        public string GetDataBy(string category, string name)
        {
            var path = GetDataSrcPath(category, name);
            return GetJsonFrom(path);
        }

        private string GetDataSrcPath(string category, string dimension)
        {
            var switchName = WebConfigurationManager.AppSettings["DataStoreSwitch"];
            return GetUriFrom(switchName, category, dimension);
        }

        private string GetJsonFrom(string path)
        {
            using (var r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                return json;
            }
        }

        private string GetUriFrom(string switchName, string category, string dimension)
        {
            var rootPath = switches.First(s => s.name == switchName).rootPath;
            return rootPath + '/' + category + '/' + dimension;


        }
    }
}