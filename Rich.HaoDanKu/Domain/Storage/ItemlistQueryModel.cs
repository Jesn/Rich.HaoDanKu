using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 商品列表页API输入参数
    /// </summary>
    public class ItemlistQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 默认是全部商品（3全部商品，4纯视频单，5聚淘专区）
        /// </summary>
        [JsonPropertyName("nav")]
        public int Nav { get; set; }
        /// <summary>
        /// 商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物（支持多类目筛选，如1,2获取类目为女装、男装的商品，逗号仅限英文逗号）
        /// </summary>
        [JsonPropertyName("cid")]
        public int Cid { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,10,20,50,100,120,200,500中选择一个数值返回）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 0.综合（最新），1.券后价(低到高)，2.券后价（高到低），3.券面额（高到低），4.月销量（高到低），5.佣金比例（高到低），6.券面额（低到高），7.月销量（低到高），8.佣金比例（低到高），9.全天销量（高到低），10全天销量（低到高），11.近2小时销量（高到低），12.近2小时销量（低到高），13.优惠券领取量（高到低）
        /// </summary>
        [JsonPropertyName("sort")]
        public int Sort { get; set; }
        /// <summary>
        /// 券后价筛选，筛选大于等于所设置的券后价的商品
        /// </summary>
        [JsonPropertyName("price_min")]
        public int PriceMin { get; set; }
        /// <summary>
        /// 券后价筛选，筛选小于等于所设置的券后价的商品
        /// </summary>
        [JsonPropertyName("price_max")]
        public int PriceMax { get; set; }
        /// <summary>
        /// 销量筛选，筛选大于等于所设置的销量的商品
        /// </summary>
        [JsonPropertyName("sale_min")]
        public int SaleMin { get; set; }
        /// <summary>
        /// 销量筛选，筛选小于等于所设置的销量的商品
        /// </summary>
        [JsonPropertyName("sale_max")]
        public int SaleMax { get; set; }
        /// <summary>
        /// 券金额筛选，筛选大于等于所设置的券金额的商品
        /// </summary>
        [JsonPropertyName("coupon_min")]
        public int CouponMin { get; set; }
        /// <summary>
        /// 券金额筛选，筛选小于等于所设置的券金额的商品
        /// </summary>
        [JsonPropertyName("coupon_max")]
        public int CouponMax { get; set; }
        /// <summary>
        /// 佣金比例筛选，筛选大于等于所设置的佣金比例的商品
        /// </summary>
        [JsonPropertyName("tkrates_min")]
        public int TkratesMin { get; set; }
        /// <summary>
        /// 佣金比例筛选，筛选小于所设置的佣金比例的商品
        /// </summary>
        [JsonPropertyName("tkrates_max")]
        public int TkratesMax { get; set; }
        /// <summary>
        /// 佣金筛选，筛选大于等于所设置的佣金的商品
        /// </summary>
        [JsonPropertyName("tkmoney_min")]
        public int TkmoneyMin { get; set; }
        /// <summary>
        /// 是否只获取营销返利商品，1是，0否
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }


    }
}
