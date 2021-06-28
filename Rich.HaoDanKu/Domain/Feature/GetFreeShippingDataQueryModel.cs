using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 偏远地区包邮商品API输入参数
    /// </summary>
    public class GetFreeShippingDataQueryModel : HaoDanKuObject
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
        /// 自定义排序 1.综合；2.券后价从高到低；3.券后价从低到高；4.销量从高到低；5.销量价从低到高；（默认是1）
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 偏远地区包邮商品关键词搜索
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }


    }
}
