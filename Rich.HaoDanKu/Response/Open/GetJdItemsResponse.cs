using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 京东福利购商品API返回参数
    /// </summary>
    public class GetJdItemsResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetJdItemsData > Data { get; set; }
    }

    public class GetJdItemsData
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("sku")]
        public long Sku { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("class")]
        public string Class { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        [JsonPropertyName("coupon_amount")]
        public string CouponAmount { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonPropertyName("itemtitle")]
        public string Itemtitle { get; set; }

        /// <summary>
        /// 商品链接
        /// </summary>
        [JsonPropertyName("itemlink")]
        public string Itemlink { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 佣金金额
        /// </summary>
        [JsonPropertyName("commission_rate")]
        public float CommissionRate { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 商品类型（1.五元购；2.三元购）
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

    }

}
