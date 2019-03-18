using System;
using System.Text;
using SimpleJSON;
using x2tap.Objects.Server;

namespace x2tap.Utils
{
    public static class Parse
    {
        public static Objects.Server.v2ray v2ray(string text)
        {
            var data = JSON.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(text.Remove(0, 8))));
            var v2ray = new Objects.Server.v2ray();

            v2ray.Remark = data["ps"].Value;
            v2ray.Address = data["add"].Value;
            v2ray.Port = data["port"].AsInt;
            v2ray.UserID = data["id"].Value;
            v2ray.AlterID = data["aid"].AsInt;

            switch (data["net"].Value)
            {
                case "tcp":
                    v2ray.TransferProtocol = 0;
                    break;
                case "kcp":
                    v2ray.TransferProtocol = 1;
                    break;
                case "ws":
                    v2ray.TransferProtocol = 2;
                    break;
                case "h2":
                    v2ray.TransferProtocol = 3;
                    break;
                default:
                    v2ray.TransferProtocol = 0;
                    break;
            }

            switch (data["type"].Value)
            {
                case "none":
                    v2ray.FakeType = 0;
                    break;
                case "http":
                    v2ray.FakeType = 1;
                    break;
                case "srtp":
                    v2ray.FakeType = 2;
                    break;
                case "utp":
                    v2ray.FakeType = 3;
                    break;
                case "wechat-video":
                    v2ray.FakeType = 4;
                    break;
                case "dtls":
                    v2ray.FakeType = 5;
                    break;
                case "wireguard":
                    v2ray.FakeType = 6;
                    break;
                default:
                    v2ray.FakeType = 0;
                    break;
            }

            v2ray.FakeDomain = data["host"].Value;
            v2ray.Path = data["path"].Value == "" ? "/" : data["path"].Value;
            v2ray.TLSSecure = data["tls"].Value == "" ? false : true;

            return v2ray;
        }

        public static Shadowsocks Shadowsocks(string text)
        {
            var data = new Uri(text);
            var shadowsocks = new Shadowsocks();

            shadowsocks.Remark = Uri.UnescapeDataString(data.Fragment.Remove(0, 1));
            shadowsocks.Address = data.Host;
            shadowsocks.Port = data.Port;

            var info = Encoding.UTF8.GetString(Convert.FromBase64String(data.UserInfo)).Split(':');

            switch (info[0])
            {
                case "aes-256-cfb":
                    shadowsocks.EncryptMethod = 0;
                    break;
                case "aes-128-cfb":
                    shadowsocks.EncryptMethod = 1;
                    break;
                case "chacha20":
                    shadowsocks.EncryptMethod = 2;
                    break;
                case "chacha20-ietf":
                    shadowsocks.EncryptMethod = 3;
                    break;
                case "aes-256-gcm":
                    shadowsocks.EncryptMethod = 4;
                    break;
                case "aes-128-gcm":
                    shadowsocks.EncryptMethod = 5;
                    break;
                case "chacha20-poly1305":
                    shadowsocks.EncryptMethod = 6;
                    break;
                default:
                    throw new Exception(string.Format("不支持的加密方式：{0}", info[0]));
            }

            shadowsocks.Password = info[1];

            return shadowsocks;
        }
    }
}