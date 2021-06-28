using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 拼多多商品列表输入参数
    /// </summary>
    public class GetPddItemlistQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        [JsonPropertyName("cat_id")]
        public int CatId { get; set; }
        /// <summary>
        /// 排序（1.默认；2.最新；3.日销量从高到底；4.券后价从低到高；5.券后价从高到底；6.券面额从高到低；7.佣金比从高到低；8.佣金金额从高到低）
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 券后价筛选-起始价
        /// </summary>
        [JsonPropertyName("start_price")]
        public int StartPrice { get; set; }
        /// <summary>
        /// 券后价筛选-结束价
        /// </summary>
        [JsonPropertyName("end_price")]
        public int EndPrice { get; set; }


    }
}
