using System.Collections.Generic;
using x2tap.Objects.Server;
using x2tap.View;

namespace x2tap
{
    public static class Global
    {
        /// <summary>
        ///     v2ray 代理
        /// </summary>
        public static List<Objects.Server.v2ray> v2rayProxies = new List<Objects.Server.v2ray>();

        /// <summary>
        ///     Shadowsocks 代理
        /// </summary>
        public static List<Shadowsocks> ShadowsocksProxies = new List<Shadowsocks>();

        /// <summary>
        ///     视图
        /// </summary>
        public static class Views
        {
            /// <summary>
            ///     主窗体
            /// </summary>
            public static MainForm MainForm;

            /// <summary>
            ///     高级设置
            /// </summary>
            public static AdvancedForm AdvancedForm;

            /// <summary>
            ///     订阅窗体
            /// </summary>
            public static SubscribeForm SubscribeForm;

            /// <summary>
            ///     服务器配置窗体
            /// </summary>
            public static class Server
            {
                /// <summary>
                ///     v2ray
                /// </summary>
                public static View.Server.v2ray v2ray;

                /// <summary>
                ///     Shadowsocks
                /// </summary>
                public static View.Server.Shadowsocks Shadowsocks;
            }
        }

        /// <summary>
        ///     配置
        /// </summary>
        public static class Config
        {
            public static int v2rayLoggingLevel = 0;

            /// <summary>
            ///     TUN/TAP
            /// </summary>
            public static class TUNTAP
            {
                /// <summary>
                ///     地址
                /// </summary>
                public static string Address = "10.153.1.10";

                /// <summary>
                ///     掩码
                /// </summary>
                public static string Netmask = "255.255.255.0";

                /// <summary>
                ///     网关
                /// </summary>
                public static string Gateway = "10.153.1.1";

                /// <summary>
                ///     跃点数
                /// </summary>
                public static int Metric = 100;
            }
        }
    }
}