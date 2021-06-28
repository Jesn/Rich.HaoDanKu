using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 店铺转链API输入参数
    /// </summary>
    public class ShopConvertCodeQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商家ID（*必要）
        /// </summary>
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
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
        /// 是否返回淘口令（0.否；1.是）（默认0）（选填）
        /// </summary>
        [JsonPropertyName("get_taoword")]
        public int GetTaoword { get; set; }
        /// <summary>
        /// 店铺名（*用于返回淘口令*）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }


    }
}
