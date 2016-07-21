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
        /// 检查更新间隔
        ///     min
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// 上次检查更新时间
        /// </summary>
        public DateTime LastCheckTime { get; set; }
        /// <summary>
        /// 暂定检查更新时长
        /// </summary>
        public TimeSpan AbortCheckTime { get; set; }
    }
}
