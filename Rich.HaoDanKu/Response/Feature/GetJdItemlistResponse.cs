using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 京东商品列表返回参数
    /// </summary>
    public class GetJdItemlistResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetJdItemlistData > Data { get; set; }
    }

    public class GetJdItemlistData
    {
        /// <summary>
        /// 京东商品ID
        /// </summary>
        [JsonPropertyName("skuid")]
        public long SkuId { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonPropertyName("goodsname")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品短标题
        /// </summary>
        [JsonPropertyName("goodsnameshort")]
        public string Goodsnameshort { get; set; }

        /// <summary>
        /// 宝贝推荐语
        /// </summary>
        [JsonPropertyName("goodsdesc")]
        public string Goodsdesc { get; set; }

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
        /// 商品主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("itempic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 轮播主图，用英文逗号分隔开来（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("jd_image")]
        public string JdImage { get; set; }

        /// <summary>
        /// 商品类目：1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        [JsonPropertyName("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// 商品券后价
        /// </summary>
        [JsonPropertyName("itemendprice")]
        public float ItemEndPrice { get; set; }

        /// <summary>
        /// 店铺类型：1.自营店
        /// </summary>
        [JsonPropertyName("shoptype")]
        public int Shoptype { get; set; }

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
        [JsonPropertyName("commissionshare")]
        public float Commissionshare { get; set; }

        /// <summary>
        /// 预计可得（宝贝价格 * 佣金比例 / 100）
        /// </summary>
        [JsonPropertyName("commission")]
        public float Commission { get; set; }

        /// <summary>
        /// 优惠券剩余量
        /// </summary>
        [JsonPropertyName("couponsurplus")]
        public int Couponsurplus { get; set; }

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
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public int StartTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public int EndTime { get; set; }

    }

}
