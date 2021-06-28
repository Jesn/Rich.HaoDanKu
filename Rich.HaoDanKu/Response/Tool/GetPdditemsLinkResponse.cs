using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 拼多多商品转链返回参数
    /// </summary>
    public class GetPdditemsLinkResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetPdditemsLinkData > Data { get; set; }
    }

    public class GetPdditemsLinkData
    {
        /// <summary>
        /// 使用此推广链接，用户安装拼多多APP的情况下会唤起APP，否则唤起H5页面
        /// </summary>
        [JsonPropertyName("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// 推广短链接
        /// </summary>
        [JsonPropertyName("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// 普通推广长链接，唤起H5页面
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 推广短链接
        /// </summary>
        [JsonPropertyName("short_url")]
        public string ShortUrl { get; set; }

    }

}
