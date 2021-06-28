using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 签到红包商品返回参数
    /// </summary>
    public class SignRedPackGoodsResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<SignRedPackGoodsData > Data { get; set; }
    }

    public class SignRedPackGoodsData
    {
        ///// <summary>
        ///// 商品总数
        ///// </summary>
        //[JsonPropertyName("count")]
        //public string Count { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }

        /// <summary>
        /// 宝贝标题
        /// </summary>
        [JsonPropertyName("itemtitle")]
        public string Itemtitle { get; set; }

        /// <summary>
        /// 宝贝短标题
        /// </summary>
        [JsonPropertyName("itemshorttitle")]
        public string ItemShortTitle { get; set; }

        /// <summary>
        /// 宝贝推荐语
        /// </summary>
        [JsonPropertyName("itemdesc")]
        public string Itemdesc { get; set; }

        /// <summary>
        /// 宝贝月销量
        /// </summary>
        [JsonPropertyName("itemsale")]
        public int ItemSale { get; set; }

        /// <summary>
        /// 宝贝今日销量
        /// </summary>
        [JsonPropertyName("todaysale")]
        public int TodaySale { get; set; }

        /// <summary>
        /// 宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 宝贝原价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public float ItemPrice { get; set; }

        /// <summary>
        /// 宝贝券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        [JsonPropertyName("couponurl")]
        public string Couponurl { get; set; }

        /// <summary>
        /// 优惠券ID
        /// </summary>
        [JsonPropertyName("activityid")]
        public string Activityid { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        [JsonPropertyName("couponmoney")]
        public float CouponMoney { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [JsonPropertyName("tkrates")]
        public float Tkrates { get; set; }

        /// <summary>
        /// 佣金金额
        /// </summary>
        [JsonPropertyName("tkmoney")]
        public float Tkmoney { get; set; }

        /// <summary>
        /// 掌柜名/td>
        /// </summary>
        [JsonPropertyName("sellernick")]
        public string Sellernick { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shopname")]
        public string ShopName { get; set; }


        /// <summary>
        /// 店铺类别
        /// </summary>
        [JsonPropertyName("shoptype")]
        public string ShopType { get; set; }

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

        [JsonPropertyName("taobao_image")]
        public string TaobaoImage { get; set; }

    }

}
