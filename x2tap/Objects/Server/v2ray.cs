using System;

namespace x2tap.Objects.Server
{
    /// <summary>
    ///     v2ray
    /// </summary>
    public class v2ray
    {
        /// <summary>
        ///     地址
        /// </summary>
        public string Address = "www.baidu.com";

        /// <summary>
        ///     额外 ID
        /// </summary>
        public int AlterID = 0;

        /// <summary>
        ///     加密方式
        /// </summary>
        public int EncryptMethod = 0;

        /// <summary>
        ///     伪装域名
        /// </summary>
        public string FakeDomain = "";

        /// <summary>
        ///     伪装类型
        /// </summary>
        public int FakeType = 0;

        /// <summary>
        ///     路径
        /// </summary>
        public string Path = "/";

        /// <summary>
        ///     端口
        /// </summary>
        public int Port = 443;

        /// <summary>
        ///     备注
        /// </summary>
        public string Remark = "百度为您提供强力加速";

        /// <summary>
        ///     TLS 底层传输安全
        /// </summary>
        public bool TLSSecure = true;

        /// <summary>
        ///     传输协议
        /// </summary>
        public int TransferProtocol = 0;

        /// <summary>
        ///     用户 ID
        /// </summary>
        public string UserID = Guid.NewGuid().ToString();
    }
}