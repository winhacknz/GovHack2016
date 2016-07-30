using System.Linq;

namespace WinHackNZ.Helper
{
    public class DataStoreSwitch
    {
        private string name;
        private string srcPath;
        public static DataStoreSwitch[] switches = new DataStoreSwitch[]
                        {
                             new DataStoreSwitch(){ name = "STUB", srcPath = "/stubs"},
                             new DataStoreSwitch(){ name = "API", srcPath = ""},
                             new DataStoreSwitch(){ name = "REMOTE_DB", srcPath = ""}
                        };

        public static string GetSwitchBy(string name)
        {
            return switches.First(item => item.name == name).srcPath;
        }
    }
}