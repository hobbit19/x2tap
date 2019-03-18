using System;

namespace x2tap.Utils
{
    public static class Util
    {
        /// <summary>
        ///     计算流量
        /// </summary>
        /// <param name="bandwidth">流量</param>
        /// <returns>带单位的流量字符串</returns>
        public static string ComputeBandwidth(long bandwidth)
        {
            string[] units = {"KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB", "BB", "DB"};
            double result;
            var i = -1;

            while ((result = (double) bandwidth / 1024) < 1024) i++;

            return string.Format("{0} {1}", Math.Round(result, 2), units[i]);
        }
    }
}