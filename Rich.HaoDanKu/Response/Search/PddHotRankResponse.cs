using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 拼多多实时热榜返回参数
    /// </summary>
    public class PddHotRankResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<PddHotRankData > Data { get; set; }
    }

    public class PddHotRankData
    {
        /// <summary>
        /// 拼多多商品ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 拼多多商品goods_sign
        /// </summary>
        [JsonPropertyName("goods_sign")]
        public string GoodsSign { get; set; }

        /// <summary>
        /// 拼多多商品标题
        /// </summary>
        [JsonPropertyName("goodsname")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public float ItemPrice { get; set; }

        /// <summary>
        /// 商品券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 宝贝月销量
        /// </summary>
        [JsonPropertyName("itemsale")]
        public int ItemSale { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        [JsonPropertyName("couponmoney")]
        public float CouponMoney { get; set; }

        /// <summary>
        /// 优惠券总量
        /// </summary>
        [JsonPropertyName("couponnum")]
        public int CouponNum { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [JsonPropertyName("promotion_rate")]
        public float PromotionRate { get; set; }

        /// <summary>
        /// 佣金金额
        /// </summary>
        [JsonPropertyName("commission")]
        public float Commission { get; set; }

        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        [JsonPropertyName("couponstarttime")]
        public int CouponStartTime { get; set; }

        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        [JsonPropertyName("couponendtime")]
        public int CouponendTime { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shopname")]
        public string ShopName { get; set; }

    }

}
