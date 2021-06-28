using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 会场转链API返回参数
    /// </summary>
    public class CreateConferenceCodeResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<CreateConferenceCodeData > Data { get; set; }
    }

    public class CreateConferenceCodeData
    {
        /// <summary>
        /// 二合一地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 淘口令
        /// </summary>
        [JsonPropertyName("tao_code")]
        public string TaoCode { get; set; }

    }

}
