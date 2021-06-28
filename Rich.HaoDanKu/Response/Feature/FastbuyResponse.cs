using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 快抢商品API返回参数
    /// </summary>
    public class FastbuyResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<FastbuyData > Data { get; set; }
    }

    public class FastbuyData
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
        /// 店铺类型：天猫店（B）淘宝店（C）
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
        /// 快抢开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public int StartTime { get; set; }

        /// <summary>
        /// 快抢结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public int EndTime { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonPropertyName("starttime")]
        public int Starttime { get; set; }

        /// <summary>
        /// 下架类型：1用户自主下架；2被拉黑下架；3被举报下架；4取消认证下架；5过期下架；6结算下架；7优惠券失效下架；8平台下架（一般7是已抢光的情况）
        /// </summary>
        [JsonPropertyName("down_type")]
        public int DownType { get; set; }

        /// <summary>
        /// 好单指数
        /// </summary>
        [JsonPropertyName("general_index")]
        public int GeneralIndex { get; set; }

        /// <summary>
        /// 放单人名号
        /// </summary>
        [JsonPropertyName("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 素材id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 导购短语
        /// </summary>
        [JsonPropertyName("short_itemdesc")]
        public string ShortItemdesc { get; set; }


        /// <summary>
        /// 实拍视频封面，可以通过改变链接中的w和h值分别改变宽高
        /// </summary>
        [JsonPropertyName("detial_video_cover")]
        public string DetialVideoCover { get; set; }

        /// <summary>
        /// 更多实拍视频封面，可以通过改变链接中的w和h值分别改变宽高
        /// </summary>
        [JsonPropertyName("main_video_cover")]
        public string MainVideoCover { get; set; }

        /// <summary>
        /// 快抢开抢状态：1快抢即将开始；2快抢商品已抢光；3快抢商品正在快抢中
        /// </summary>
        [JsonPropertyName("grab_type")]
        public string GrabType { get; set; }

        /// <summary>
        /// 素材内容
        /// </summary>
        [JsonPropertyName("material_info")]
        public MaterialInfo MaterialInfo { get; set; }

    }

    /// <summary>
    /// 素材内容
    /// </summary>
    public class MaterialInfo
    {
        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("seckill_content")]
        public string SeckillContent { get; set; }

        /// <summary>
        /// 实拍视频地址
        /// </summary>
        [JsonPropertyName("main_video_url")]
        public string MainVideoUrl { get; set; }

        /// <summary>
        /// 更多实拍视频地址
        /// </summary>
        [JsonPropertyName("detail_video_url")]
        public string DetailVideoUrl { get; set; }
    }

}
