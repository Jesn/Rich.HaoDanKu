using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 今日推荐品牌API返回参数
    /// </summary>
    public class BrandTodayRecommendResponse : HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public BrandTodayRecommendData Data { get; set; }
    }

    public class BrandTodayRecommendData
    {
        [JsonPropertyName("data")]
        public BrandTodayRecommendSummary Data { get; set; }


        [JsonPropertyName("items")]
        public List<BrandTodayRecommendItem> Items { get; set; }
    }

    public class BrandTodayRecommendSummary
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 品牌介绍
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 背景图
        /// </summary>
        [JsonPropertyName("background")]
        public string Background { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("actitvity_endtime")]
        public string ActitvityEndtime { get; set; }

        /// <summary>
        /// 品牌商品总数
        /// </summary>
        [JsonPropertyName("num")]
        public int Num { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }


        [JsonPropertyName("multiple")]
        public List<string> Multiple { get; set; }

    }

    public class BrandTodayRecommendItem
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public long Itemid { get; set; }

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
        /// 在售价
        /// </summary>
        [JsonPropertyName("itemprice")]
        public float ItemPrice { get; set; }

        /// <summary>
        /// 宝贝推荐语
        /// </summary>
        [JsonPropertyName("itemdesc")]
        public string Itemdesc { get; set; }

        /// <summary>
        /// 推广长图（带http://img-haodanku-com.cdn.fudaiapp.com/0_553757100845_1509175123.jpg-600进行访问）
        /// </summary>
        [JsonPropertyName("itempic_copy")]
        public string ItempicCopy { get; set; }

        /// <summary>
        /// 店铺类型：天猫（B）淘宝店（C）
        /// </summary>
        [JsonPropertyName("shoptype")]
        public string Shoptype { get; set; }


        [JsonPropertyName("is_foreshow")]
        public int IsForeshow { get; set; }

        /// <summary>
        /// 商品视频ID（id大于0的为有视频单，视频拼接地址http://cloud.video.taobao.com/play/u/1/p/1/e/6/t/1/+videoid+.mp4）
        /// </summary>
        [JsonPropertyName("videoid")]
        public long VideoId { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonPropertyName("activityid")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型：普通活动聚划算淘抢购
        /// </summary>
        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonPropertyName("shopid")]
        public int ShopId { get; set; }

        [JsonPropertyName("userid")]
        public long UserId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shopname")]
        public string ShopName { get; set; }

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
        public int CouponsurPlus { get; set; }

        /// <summary>
        /// 优惠券领取量
        /// </summary>
        [JsonPropertyName("couponreceive")]
        public int CouponReceive { get; set; }

        /// <summary>
        /// 优惠券总数量
        /// </summary>
        [JsonPropertyName("couponnum")]
        public int CouponNum { get; set; }

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
        /// 宝贝券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 好单指数
        /// </summary>
        [JsonPropertyName("general_index")]
        public int GeneralIndex { get; set; }

        [JsonPropertyName("grade_avg")]
        public float GradeAvg { get; set; }

        [JsonPropertyName("rate_total")]
        public int RateTotal { get; set; }

        /// <summary>
        /// 当天销量（选择昨日爆单榜没有该字段）
        /// </summary>
        [JsonPropertyName("todaysale")]
        public int Todaysale { get; set; }

        [JsonPropertyName("stock")]
        public int Stock { get; set; }

        /// <summary>
        /// 宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 折扣力度
        /// </summary>
        [JsonPropertyName("discount")]
        public float Discount { get; set; }

        /// <summary>
        /// 放单人名号
        /// </summary>
        [JsonPropertyName("seller_name")]
        public string SellerName { get; set; }

        [JsonPropertyName("report_status")]
        public int ReportStatus { get; set; }

        [JsonPropertyName("down_type")]
        public int DownType { get; set; }

        [JsonPropertyName("activity_plan")]
        public int ActivityPlan { get; set; }

        [JsonPropertyName("is_flagship_store")]
        public int IsFlagshipStore { get; set; }

    }



}
