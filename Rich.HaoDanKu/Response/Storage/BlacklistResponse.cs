using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 完整黑名单库API返回参数
    /// </summary>
    public class BlacklistResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<BlacklistData > Data { get; set; }
    }

    public class BlacklistData
    {
        /// <summary>
        /// 获取下一页（目前一页返回，无需下一页）
        /// </summary>
        [JsonPropertyName("mid_id")]
        public int MidId { get; set; }

        /// <summary>
        /// 掌柜名
        /// </summary>
        [JsonPropertyName("sellernick")]
        public string Sellernick { get; set; }

    }

}
