using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 我的收藏返回参数
    /// </summary>
    public class GetCollectItemsResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetCollectItemsData > Data { get; set; }
    }

    public class GetCollectItemsData
    {
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
        /// 轮播主图，用英文逗号分隔开来（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        /// </summary>
        [JsonPropertyName("taobao_image")]
        public string TaobaoImage { get; set; }

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
        /// 店铺掌柜名
        /// </summary>
        [JsonPropertyName("sellernick")]
        public string Sellernick { get; set; }

        /// <summary>
        /// 店铺名
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
        /// 放单人名号
        /// </summary>
        [JsonPropertyName("seller_name")]
        public string SellerName { get; set; }

    }

}
