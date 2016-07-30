using System;
using System.IO;
using System.Linq;
using System.Web.Configuration;
using Newtonsoft.Json;

namespace WinHackNZ.Helper
{

    public class DataSwitch
    {
        public string name;
        public string rootPath;
        public bool skip;
    }

    public class DataStore
    {
        // TODO: a hack to mimic js data structure. probably need to rethink it.
        private DataSwitch[] switches = new DataSwitch[]
                        {
                             new DataSwitch(){ name = "STUB", rootPath = AppDomain.CurrentDomain.BaseDirectory + "stubs", skip = false},
                             new DataSwitch(){ name = "API", rootPath = "", skip = false},
                             // if it is remote db, we specify db conn in web.config.
                             // so in this case, we should skip data store.
                             new DataSwitch(){ name = "REMOTE_DB", rootPath = "", skip=true}
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

            return Path.GetFullPath(Path.Combine(rootPath, category, dimension)).Replace(@"\\", @"\");
        }
    }
}