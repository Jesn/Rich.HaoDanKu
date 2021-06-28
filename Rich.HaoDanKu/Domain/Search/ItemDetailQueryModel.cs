using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 单品详情API输入参数
    /// </summary>
    public class ItemDetailQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 获取详情的宝贝ID（目前仅支持好单库站内商品获取详情）itemid字段支持多个商品ID传入（使用英文逗号隔开），例如：111,222,333；批量查询上限为10个。数据将在all_data内返回。
        /// </summary>
        [JsonPropertyName("itemid")]
        public string ItemId { get; set; }
        /// <summary>
        /// 渠道关系ID，仅适用于渠道推广场景
        /// </summary>
        [JsonPropertyName("relation_id")]
        public string RelationId { get; set; }
        /// <summary>
        /// 会员运营ID
        /// </summary>
        [JsonPropertyName("special_id")]
        public string SpecialId { get; set; }


    }
}
