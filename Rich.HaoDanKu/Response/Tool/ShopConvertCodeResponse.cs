using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 店铺转链API返回参数
    /// </summary>
    public class ShopConvertCodeResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<ShopConvertCodeData > Data { get; set; }
    }

    public class ShopConvertCodeData
    {
        /// <summary>
        /// 二合一地址
        /// </summary>
        [JsonPropertyName("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 淘口令
        /// </summary>
        [JsonPropertyName("taocode")]
        public string Taocode { get; set; }

    }

}
