using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 京东商品转链返回参数
    /// </summary>
    public class GetJditemsLinkResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public GetJditemsLinkData Data { get; set; }
    }

    public class GetJditemsLinkData
    {
        /// <summary>
        /// 推广链接
        /// </summary>
        [JsonPropertyName("short_url")]
        public string ShortUrl { get; set; }

    }

}
