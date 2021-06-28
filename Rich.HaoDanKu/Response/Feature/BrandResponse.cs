using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 品牌列表API返回参数
    /// </summary>
    public class BrandResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public BrandData Data { get; set; }

        [JsonPropertyName("todayrecommend")]
        public TodayRecommendResult TodayRecommend { get; set; }

        [JsonPropertyName("subjectitems")]
        public List<SubjectItem> SubjectItems { get; set; }
    }

    public class BrandData
    {
        /// <summary>
        /// 品牌自增ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 淘宝品牌名称
        /// </summary>
        [JsonPropertyName("tb_brand_name")]
        public string TbBrandName { get; set; }

        /// <summary>
        /// 蜂擎品牌名称
        /// </summary>
        [JsonPropertyName("fq_brand_name")]
        public string FqBrandName { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌类目
        /// </summary>
        [JsonPropertyName("brandcat")]
        public int Brandcat { get; set; }

        /// <summary>
        /// 品牌简介
        /// </summary>
        [JsonPropertyName("introduce")]
        public string Introduce { get; set; }

        [JsonPropertyName("item")]
        public List<BrandItem> Items { get; set; }

    }

    public class BrandItem
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }

        [JsonPropertyName("xid")]
        public int Xid { get; set; }

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
        /// 优惠券金额
        /// </summary>
        [JsonPropertyName("couponmoney")]
        public float CouponMoney { get; set; }

        /// <summary>
        /// 优惠券链接
        /// </summary>
        [JsonPropertyName("couponurl")]
        public string Couponurl { get; set; }

        /// <summary>
        /// 淘宝品牌名称
        /// </summary>
        [JsonPropertyName("tb_brand_name")]
        public string TbBrandName { get; set; }

        /// <summary>
        /// 宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如http://img.alicdn.com/imgextra/i2/2923059281/O1CN012IQkLhBE8AFo0Lo_!!2923059281.jpg.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

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
        /// 宝贝券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

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
        /// 当天销量（选择昨日爆单榜没有该字段）
        /// </summary>
        [JsonPropertyName("todaysale")]
        public int Todaysale { get; set; }

        /// <summary>
        /// 推广长图（带http://img-haodanku-com.cdn.fudaiapp.com/0_575092904353_1546066517.jpg-600进行访问）
        /// </summary>
        [JsonPropertyName("itempic_copy")]
        public string ItempicCopy { get; set; }

        /// <summary>
        /// 店铺类型：天猫（B）淘宝店（C）
        /// </summary>
        [JsonPropertyName("shoptype")]
        public string Shoptype { get; set; }

        /// <summary>
        /// 预计可得（宝贝价格 * 佣金比例 / 100）
        /// </summary>
        [JsonPropertyName("tkmoney")]
        public float Tkmoney { get; set; }

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
        /// 好单指数
        /// </summary>
        [JsonPropertyName("general_index")]
        public int GeneralIndex { get; set; }

        [JsonPropertyName("sellernick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 活动类型：普通活动聚划算淘抢购
        /// </summary>
        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shopid")]
        public int ShopId { get; set; }

        [JsonPropertyName("userid")]
        public int UserId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shopname")]
        public string ShopName { get; set; }

        [JsonPropertyName("son_category")]
        public int SonCategory { get; set; }

    }

    public class TodayRecommendResult
    {
        [JsonPropertyName("data")]
        public TodayRecommendData Data { get; set; }

        [JsonPropertyName("items")]
        public List<BrandItem> Items { get; set; }

    }

    public class TodayRecommendData
    {
        /// <summary>
        /// 品牌自增ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 背景图片
        /// </summary>
        [JsonPropertyName("background")]
        public string Background { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("actitvity_endtime")]
        public int ActitvityEndtime { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        [JsonPropertyName("multiple")]
        public List<string> Multiple { get; set; }
    }


    public class SubjectItem
    {
        /// <summary>
        /// 品牌自增ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("brand_image")]
        public string BrandImage { get; set; }

        [JsonPropertyName("brand_id")]
        public int BrandId { get; set; }

        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        [JsonPropertyName("items")]
        public List<BrandItem> Items { get; set; }
    }


}
