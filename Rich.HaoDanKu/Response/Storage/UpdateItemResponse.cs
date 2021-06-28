using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 商品更新API返回参数
    /// </summary>
    public class UpdateItemResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<UpdateItemData > Data { get; set; }
    }

    public class UpdateItemData
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }

        /// <summary>
        /// 宝贝月销量
        /// </summary>
        [JsonPropertyName("itemsale")]
        public int ItemSale { get; set; }

        /// <summary>
        /// 宝贝近2小时跑单
        /// </summary>
        [JsonPropertyName("itemsale2")]
        public int Itemsale2 { get; set; }

        /// <summary>
        /// 当天销量
        /// </summary>
        [JsonPropertyName("todaysale")]
        public int Todaysale { get; set; }

        /// <summary>
        /// 好单指数
        /// </summary>
        [JsonPropertyName("general_index")]
        public string GeneralIndex { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        [JsonPropertyName("couponurl")]
        public string Couponurl { get; set; }

        /// <summary>
        /// 优惠券领取量
        /// </summary>
        [JsonPropertyName("couponreceive")]
        public int Couponreceive { get; set; }

        /// <summary>
        /// 优惠券剩余量
        /// </summary>
        [JsonPropertyName("couponsurplus")]
        public int Couponsurplus { get; set; }

        /// <summary>
        /// 优惠券id
        /// </summary>
        [JsonPropertyName("activityid")]
        public string Activityid { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        [JsonPropertyName("couponmoney")]
        public string CouponMoney { get; set; }

    }

}
