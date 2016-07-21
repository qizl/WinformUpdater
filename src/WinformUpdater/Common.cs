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
        public string ConfigPath = Path.Combine(Environment.CurrentDirectory, "updaterconfig.xml");

        public Config DefaultConfig = new Config()
        {
            Interval = 10,
            LastCheckTime = DateTime.Now,
            AbortCheckTime = new TimeSpan()
        };
        public Config Config { get; set; }
    }
}
