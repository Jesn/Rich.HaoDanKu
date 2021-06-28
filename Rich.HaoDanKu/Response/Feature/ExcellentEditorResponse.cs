using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 精编文案API返回参数
    /// </summary>
    public class ExcellentEditorResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<ExcellentEditorData > Data { get; set; }
    }

    public class ExcellentEditorData
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
        /// 发布时间时间戳
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 宝贝短标题
        /// </summary>
        [JsonPropertyName("itemshorttitle")]
        public string ItemShortTitle { get; set; }

        /// <summary>
        /// 在售价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public float ItemPrice { get; set; }

        /// <summary>
        /// 宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i4/716824265/TB29otVd7fb_uJkHFrdXXX2IVXa_!!716824265.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 宝贝券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 店铺类型：天猫（B）淘宝店（C）
        /// </summary>
        [JsonPropertyName("shoptype")]
        public string Shoptype { get; set; }

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
        /// 佣金比例
        /// </summary>
        [JsonPropertyName("tkrates")]
        public float Tkrates { get; set; }

        /// <summary>
        /// 预计可得（宝贝价格 * 佣金比例 / 100）
        /// </summary>
        [JsonPropertyName("tkmoney")]
        public float Tkmoney { get; set; }

        /// <summary>
        /// 文案展示内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("copy_text")]
        public string CopyText { get; set; }

    }

}
