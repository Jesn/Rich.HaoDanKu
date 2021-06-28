using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 京东超级搜索输入参数
    /// </summary>
    public class JdGoodsSearchQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 搜索关键词，支持京东商品链接、京东商品skuID、商品标题（由于存在特殊符号搜索的关键词必须进行两次urlencode编码）
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 是否是优惠券商品，1：有优惠券（默认0）
        /// </summary>
        [JsonPropertyName("has_coupon")]
        public int HasCoupon { get; set; }


    }
}
