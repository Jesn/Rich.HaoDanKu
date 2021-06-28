using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 淘宝商品转链输入参数
    /// </summary>
    public class RatesurlQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 宝贝ID（*必要）
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }
        /// <summary>
        /// 团长与下游渠道合作的特殊标识，用于统计渠道推广效果（*itemid、xid二选一 或 二选二）
        /// </summary>
        [JsonPropertyName("xid")]
        public string Xid { get; set; }
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
        /// 会员运营ID
        /// </summary>
        [JsonPropertyName("special_id")]
        public string SpecialId { get; set; }
        /// <summary>
        /// 淘宝客外部用户标记，如自身系统账户ID；微信ID等
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }
        /// <summary>
        /// 授权后的淘宝名称（*必要，多授权淘宝号时用于区分哪个淘宝账户的）
        /// </summary>
        [JsonPropertyName("tb_name")]
        public string TbName { get; set; }
        /// <summary>
        /// 阿里妈妈推广券ID （选填）
        /// </summary>
        [JsonPropertyName("activityid")]
        public string Activityid { get; set; }
        /// <summary>
        /// 营销计划（选填）
        /// </summary>
        [JsonPropertyName("me")]
        public string Me { get; set; }
        /// <summary>
        /// 授权之后的淘宝授权token（选填）
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 是否返回淘口令（0.否；1.是）（默认0）（选填）
        /// </summary>
        [JsonPropertyName("get_taoword")]
        public int GetTaoword { get; set; }
        /// <summary>
        /// 商品标题（用于返回淘口令*get_taoword等于1时为必填参数*，需超过8个字符）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>
        /// 商品主图链接地址（选填，可为空）
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        /// <summary>
        /// 特殊玩法处理：1.签到红包；2.百亿补贴；3.淘宝吃货（*该玩法转链结果请按照官方玩法使用）
        /// </summary>
        [JsonPropertyName("is_special")]
        public int IsSpecial { get; set; }


    }
}
