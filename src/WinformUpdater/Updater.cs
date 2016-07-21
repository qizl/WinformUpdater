using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.EnjoyCodes.WinformUpdater
{
    public class Updater
    {
        private static Updater uniqueInstance;
        private static object syncRoot = new object();

        private Updater() { }

        public void initialize()
        {
            Common.Config = Config.Load(Common.ConfigPath);
            if (Common.Config == null)
                Common.Config = Common.DefaultConfig.Clone() as Config;
            Common.Config.UpdateTime = DateTime.Now;
            Common.Config.Save(Common.ConfigPath);
        }

        public static Updater GetUpdater()
        {
            if (uniqueInstance == null)
                lock (syncRoot)
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Updater();
                        uniqueInstance.initialize();
                    }

            return uniqueInstance;
        }

        public static void Start()
        {
            var u = GetUpdater();
        }
    }
}
