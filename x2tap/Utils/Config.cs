using System.Collections.Generic;
using System.IO;
using IniParser;
using Newtonsoft.Json;
using x2tap.Objects.Server;
using x2tap.Properties;

namespace x2tap.Utils
{
    public static class Config
    {
        /// <summary>
        ///     从文件初始化
        /// </summary>
        public static void InitFromFile()
        {
            // 检查配置文件是否存在，如果不存在则写入一个默认的配置
            if (!File.Exists("x2tap.ini"))
            {
                File.WriteAllBytes("x2tap.ini", Resources.defaultConfig);
            }

            var parser = new FileIniDataParser();
            var data = parser.ReadFile("x2tap.ini");
            Global.Config.v2rayLoggingLevel = int.Parse(data["x2tap"]["v2rayLoggingLevel"]);
            Global.Config.TUNTAP.Address = data["TUNTAP"]["Address"];
            Global.Config.TUNTAP.Netmask = data["TUNTAP"]["Netmask"];
            Global.Config.TUNTAP.Gateway = data["TUNTAP"]["Gateway"];
            Global.Config.TUNTAP.Metric = int.Parse(data["TUNTAP"]["Metric"]);

            if (File.Exists("v2ray.json"))
            {
                Global.v2rayProxies = JsonConvert.DeserializeObject<List<Objects.Server.v2ray>>(File.ReadAllText("v2ray.json"));
            }

            if (File.Exists("Shadowsocks.json"))
            {
                Global.ShadowsocksProxies = JsonConvert.DeserializeObject<List<Shadowsocks>>(File.ReadAllText("Shadowsocks.json"));
            }
        }

        /// <summary>
        ///     保存到文件
        /// </summary>
        public static void SaveToFile()
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile("x2tap.ini");
            data["x2tap"]["v2rayLoggingLevel"] = Global.Config.v2rayLoggingLevel.ToString();
            data["x2tap"]["Address"] = Global.Config.TUNTAP.Address;
            data["x2tap"]["Netmask"] = Global.Config.TUNTAP.Netmask;
            data["x2tap"]["Gateway"] = Global.Config.TUNTAP.Gateway;
            data["x2tap"]["Metric"] = Global.Config.TUNTAP.Metric.ToString();
            parser.WriteFile("x2tap.ini", data);

            File.WriteAllText("v2ray.json", JsonConvert.SerializeObject(Global.v2rayProxies));
            File.WriteAllText("Shadowsocks.json", JsonConvert.SerializeObject(Global.ShadowsocksProxies));
        }
    }
}