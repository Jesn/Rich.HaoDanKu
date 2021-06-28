using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 朋友圈API返回参数
    /// </summary>
    public class SelectedItemResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<SelectedItemData > Data { get; set; }
    }

    public class SelectedItemData
    {
        /// <summary>
        /// 单品id
        /// </summary>
        [JsonPropertyName("edit_id")]
        public string EditId { get; set; }

        /// <summary>
        /// 多张宝贝图片，含实拍图（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public List<string> ItemPic { get; set; }

        /// <summary>
        /// 宝贝标题
        /// </summary>
        [JsonPropertyName("itemtitle")]
        public string Itemtitle { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        [JsonPropertyName("couponurl")]
        public string Couponurl { get; set; }

        /// <summary>
        /// 单品导购内容（表情未处理）
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 朋友圈评论内容（表情未处理），多条评论用“|”做区分
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 展示时间戳
        /// </summary>
        [JsonPropertyName("show_time")]
        public int ShowTime { get; set; }

        /// <summary>
        /// 宝贝券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        [JsonPropertyName("couponmoney")]
        public float CouponMoney { get; set; }

        /// <summary>
        /// 该商品被分享次数
        /// </summary>
        [JsonPropertyName("dummy_click_statistics")]
        public string DummyClickStatistics { get; set; }

        /// <summary>
        /// 在售价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public float ItemPrice { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [JsonPropertyName("tkrates")]
        public float Tkrates { get; set; }

        /// <summary>
        /// 导购文案展示内容，含表情
        /// </summary>
        [JsonPropertyName("show_content")]
        public string ShowContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("copy_content")]
        public string CopyContent { get; set; }

    }

}
