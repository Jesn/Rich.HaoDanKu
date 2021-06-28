using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 各大榜单API输入参数
    /// </summary>
    public class SalesListQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 榜单类型：sale_type=1是实时销量榜（近2小时销量），type=2是今日爆单榜，type=3是昨日爆单榜，type=4是出单指数版
        /// </summary>
        [JsonPropertyName("sale_type")]
        public int SaleType { get; set; }
        /// <summary>
        /// 商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        [JsonPropertyName("cid")]
        public int Cid { get; set; }
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,10,20,50,100中选择一个数值返回，最多返回top100条数据）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 是否只获取营销返利商品，1是，0否
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }


    }
}
