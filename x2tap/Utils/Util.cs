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
            string[] units = {"KB", "MB", "GB", "TB", "PB"};
            double result = bandwidth;
            var i = -1;

            do
            {
                i++;
            } while ((result /= 1024) > 1024);

            return string.Format("{0} {1}", Math.Round(result, 2), units[i]);
        }
    }
}