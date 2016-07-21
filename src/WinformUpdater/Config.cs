using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.EnjoyCodes.WinformUpdater
{
    public class Config
    {
        /// <summary>
        /// 软件更新标识
        /// </summary>
        public string SoftwareUpdateKey { get; set; }
        /// <summary>
        /// 更新服务器地址
        /// </summary>
        public string ServerPath { get; set; }

        /// <summary>
        /// 检查更新间隔
        ///     min
        /// </summary>
        public int Interval { get; set; }
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 上次检查更新时间
        /// </summary>
        public DateTime LastCheckTime { get; set; }
        /// <summary>
        /// 暂定检查更新时长
        /// </summary>
        public TimeSpan AbortCheckTime { get; set; }

        public static Config Load(string path)
        {
            Config config = null;
            try
            {
                SharpSerializer.SharpSerializer serializer = new SharpSerializer.SharpSerializer();
                config = serializer.Deserialize(path) as Config;
            }
            catch { }
            return config;
        }

        public bool Save(string path)
        {
            try
            {
                SharpSerializer.SharpSerializer serializer = new SharpSerializer.SharpSerializer();
                serializer.Serialize(this, path);
            }
            catch { return false; }
            return true;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
