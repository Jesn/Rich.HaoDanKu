using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 超值买返转链API返回参数
    /// </summary>
    public class GetBuyresultUrlResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetBuyresultUrlData > Data { get; set; }
    }

    public class GetBuyresultUrlData
    {
        /// <summary>
        /// 领券口令
        /// </summary>
        [JsonPropertyName("get_quan_code")]
        public string GetQuanCode { get; set; }

        /// <summary>
        /// 下单淘口令
        /// </summary>
        [JsonPropertyName("place_order_code")]
        public string PlaceOrderCode { get; set; }

    }

}
