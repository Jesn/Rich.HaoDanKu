using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 精选低价包邮专区API返回参数
    /// </summary>
    public class LowPricePinkageDataResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<LowPricePinkageDataData > Data { get; set; }
    }

    public class LowPricePinkageDataData
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
        /// 放单人ID
        /// </summary>
        [JsonPropertyName("seller_id")]
        public int SellerId { get; set; }

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
        /// 在售价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public float ItemPrice { get; set; }

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
        /// 宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 推广长图（带http://img-haodanku-com.cdn.fudaiapp.com/0_553757100845_1509175123.jpg-600进行访问）
        /// </summary>
        [JsonPropertyName("itempic_copy")]
        public string ItempicCopy { get; set; }

        /// <summary>
        /// 商品类目：1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        [JsonPropertyName("fqcat")]
        public int Fqcat { get; set; }

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
        /// 佣金计划：隐藏营销
        /// </summary>
        [JsonPropertyName("tktype")]
        public string Tktype { get; set; }

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
        /// 优惠券剩余量
        /// </summary>
        [JsonPropertyName("couponsurplus")]
        public int Couponsurplus { get; set; }

        /// <summary>
        /// 优惠券领取量
        /// </summary>
        [JsonPropertyName("couponreceive")]
        public int Couponreceive { get; set; }

        /// <summary>
        /// 2小时内优惠券领取量
        /// </summary>
        [JsonPropertyName("couponreceive2")]
        public int Couponreceive2 { get; set; }

        /// <summary>
        /// 今日优惠券领取量
        /// </summary>
        [JsonPropertyName("todaycouponreceive")]
        public int Todaycouponreceive { get; set; }

        /// <summary>
        /// 优惠券总数量
        /// </summary>
        [JsonPropertyName("couponnum")]
        public int CouponNum { get; set; }

        /// <summary>
        /// 优惠券使用条件
        /// </summary>
        [JsonPropertyName("couponexplain")]
        public string Couponexplain { get; set; }

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
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public int StartTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public int EndTime { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonPropertyName("starttime")]
        public int Starttime { get; set; }

        /// <summary>
        /// 举报处理条件0未举报1为待处理2为忽略3为下架
        /// </summary>
        [JsonPropertyName("report_status")]
        public int ReportStatus { get; set; }

        /// <summary>
        /// 是否为品牌产品（1是）
        /// </summary>
        [JsonPropertyName("is_brand")]
        public int IsBrand { get; set; }

        /// <summary>
        /// 是否为直播产品（1是）
        /// </summary>
        [JsonPropertyName("is_live")]
        public int IsLive { get; set; }

        /// <summary>
        /// 推广导购文案
        /// </summary>
        [JsonPropertyName("guide_article")]
        public string GuideArticle { get; set; }

        /// <summary>
        /// 商品视频ID（id大于0的为有视频单，视频拼接地址http://cloud.video.taobao.com/play/u/1/p/1/e/6/t/1/+videoid+.mp4）
        /// </summary>
        [JsonPropertyName("videoid")]
        public long VideoId { get; set; }

        /// <summary>
        /// 活动类型：普通活动聚划算淘抢购
        /// </summary>
        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 好单指数
        /// </summary>
        [JsonPropertyName("general_index")]
        public int GeneralIndex { get; set; }

        /// <summary>
        /// 营销计划链接
        /// </summary>
        [JsonPropertyName("planlink")]
        public string Planlink { get; set; }

        /// <summary>
        /// 店主的userid
        /// </summary>
        [JsonPropertyName("userid")]
        public long UserId { get; set; }

        /// <summary>
        /// 店铺掌柜名
        /// </summary>
        [JsonPropertyName("sellernick")]
        public string Sellernick { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [JsonPropertyName("shopname")]
        public string ShopName { get; set; }

    }

}
