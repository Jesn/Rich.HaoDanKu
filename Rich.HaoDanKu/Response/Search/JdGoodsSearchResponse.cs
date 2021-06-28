using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 京东超级搜索返回参数
    /// </summary>
    public class JdGoodsSearchResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<JdGoodsSearchData > Data { get; set; }
    }

    public class JdGoodsSearchData
    {
        /// <summary>
        /// 京东商品ID
        /// </summary>
        [JsonPropertyName("skuid")]
        public long SkuId { get; set; }

        /// <summary>
        /// 京东商品标题
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
        /// 优惠券链接
        /// </summary>
        [JsonPropertyName("couponurl")]
        public string Couponurl { get; set; }

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
        [JsonPropertyName("commission")]
        public float Commission { get; set; }

        /// <summary>
        /// 佣金金额
        /// </summary>
        [JsonPropertyName("commissionshare")]
        public float Commissionshare { get; set; }

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

        /// <summary>
        /// 数据来源：haodanku（来自好单库精选京东商品数据），jd（来自京东联盟商品数据）
        /// </summary>
        [JsonPropertyName("item_from")]
        public string ItemFrom { get; set; }

    }

}
