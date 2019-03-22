namespace x2tap.Utils
{
    public static class Route
    {
        /// <summary>
        ///     路由工具位置
        /// </summary>
        public static string Location = "C:\\Windows\\System32\\ROUTE.EXE";

        /// <summary>
        ///     增加路由规则
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="netmask">掩码</param>
        /// <param name="gateway">网关</param>
        /// <param name="metric">跃点数</param>
        /// <returns></returns>
        public static bool Add(string address, string netmask, string gateway, int metric)
        {
            return Shell.Execute(Location, "add", address, "mask", netmask, gateway, "metric", metric.ToString()).Ok;
        }

        /// <summary>
        ///     删除路由规则
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        public static bool Delete(string address)
        {
            return Shell.Execute(Location, "delete", address).Ok;
        }

        /// <summary>
        ///     修改路由规则
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="metric">跃点数</param>
        /// <returns></returns>
        public static bool Change(string address, string netmask, string gateway, int metric)
        {
            return Shell.Execute(Location, "change", address, "mask", netmask, gateway, "metric", metric.ToString()).Ok;
        }
    }
}