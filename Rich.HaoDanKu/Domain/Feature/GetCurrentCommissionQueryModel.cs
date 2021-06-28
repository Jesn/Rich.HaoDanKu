using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 实时佣金榜API输入参数
    /// </summary>
    public class GetCurrentCommissionQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商品类目： 0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        /// </summary>
        [JsonPropertyName("cat_id")]
        public int CatId { get; set; }
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 状态，每页返回条数（请在10，20，50，100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }


    }
}
