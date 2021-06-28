using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 热搜关键词记录API返回参数
    /// </summary>
    public class HotKeyResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<HotKeyData > Data { get; set; }
    }

    public class HotKeyData
    {
        /// <summary>
        /// 获取下一页（目前一页返回全部昨天100个热搜词，无需下一页）
        /// </summary>
        [JsonPropertyName("mid_id")]
        public int MidId { get; set; }

        /// <summary>
        /// 热搜关键词（每天返回昨天的关键词）
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }

    }

}
