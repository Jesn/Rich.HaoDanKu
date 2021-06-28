using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 超值买返转链API输入参数
    /// </summary>
    public class GetBuyresultUrlQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }
        /// <summary>
        /// 推广位ID（*必要 需是授权淘宝号下的推广位，如果请求的时候携带了渠道id请求，则该pid需是渠道管理下面的渠道专属推广位）
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 渠道ID
        /// </summary>
        [JsonPropertyName("relation_id")]
        public string RelationId { get; set; }
        /// <summary>
        /// 授权后的淘宝名称（*必要，多授权淘宝号时用于区分哪个淘宝账户的*）
        /// </summary>
        [JsonPropertyName("tb_name")]
        public string TbName { get; set; }
        /// <summary>
        /// 优惠券ID （选填）
        /// </summary>
        [JsonPropertyName("activityid")]
        public string Activityid { get; set; }
        /// <summary>
        /// 商品短标题（*用于返回淘口令，需超过8个字符*）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>
        /// 授权之后的淘宝授权token（选填）
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }


    }
}
