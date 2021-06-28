using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 首单礼金商品API输入参数
    /// </summary>
    public class FristOrderItemsQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        [JsonPropertyName("cat_id")]
        public int CatId { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 已领礼金金额（2-7元）
        /// </summary>
        [JsonPropertyName("received_price")]
        public int ReceivedPrice { get; set; }
        /// <summary>
        /// 自定义排序（1.今日销量倒序；2.今日销量正序；3.预估支付价格正序；4.预估支付价格倒序；5.人气倒序；6.人气正序；7.最新倒序；8.最新正序）
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 关键词搜索
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }


    }
}
