using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 淘宝超级搜索输入参数
    /// </summary>
    public class SupersearchQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 搜索关键词，同时也支持宝贝ID搜索即keyword=itemid（由于存在特殊符号搜索的关键词必须进行两次urlencode编码）
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,10,20,50,100中选择一个数值返回）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 淘宝分页，用于实现类似分页抓取效果，来源于上次获取后的数据的tb_p值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("tb_p")]
        public int TbP { get; set; }
        /// <summary>
        /// 0.综合，1.最新，2.销量（高到低），3.销量（低到高），4.价格(低到高)，5.价格（高到低），6.佣金比例（高到低）
        /// </summary>
        [JsonPropertyName("sort")]
        public int Sort { get; set; }
        /// <summary>
        /// 是否只取天猫商品：0否；1是，默认是0
        /// </summary>
        [JsonPropertyName("is_tmall")]
        public int IsTmall { get; set; }
        /// <summary>
        /// 是否只取有券商品：0否；1是，默认是0
        /// </summary>
        [JsonPropertyName("is_coupon")]
        public int IsCoupon { get; set; }
        /// <summary>
        /// 是否只取偏远地区包邮商品：0否；1是，默认是0
        /// </summary>
        [JsonPropertyName("is_shopping")]
        public int IsShopping { get; set; }
        /// <summary>
        /// 佣金比例过滤0~100
        /// </summary>
        [JsonPropertyName("limitrate")]
        public int Limitrate { get; set; }
        /// <summary>
        /// 最低原价（默认为0），例如传10则只取大于等于10元的原价商品数据
        /// </summary>
        [JsonPropertyName("startprice")]
        public int Startprice { get; set; }
        /// <summary>
        /// 渠道关系ID，仅适用于渠道推广场景
        /// </summary>
        [JsonPropertyName("relation_id")]
        public string RelationId { get; set; }
        /// <summary>
        /// 会员运营ID
        /// </summary>
        [JsonPropertyName("special_id")]
        public string SpecialId { get; set; }


    }
}
