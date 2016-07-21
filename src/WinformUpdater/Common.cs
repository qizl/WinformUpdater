using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.EnjoyCodes.WinformUpdater
{
    public class Common
    {
        public static string ConfigPath = Path.Combine(Environment.CurrentDirectory, "updaterconfig.xml");

        public static Config DefaultConfig = new Config()
        {
            SoftwareUpdateKey = Guid.Empty.ToString(),
            ServerPath = "http://update.enjoycodes.com/",
            Interval = 10,
            LastCheckTime = DateTime.Now,
            AbortCheckTime = new TimeSpan()
        };
        public static Config Config { get; set; }
    }
}
