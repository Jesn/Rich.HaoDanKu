using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 抖货商品API输入参数
    /// </summary>
    public class GetTrillDataQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商品类目： 抖货商品类目：0热门，1百变穿搭，2时尚潮男，3舒适好物，4美妆达人，5魅力配饰，6步履不停，7包罗万象，8萌娃驾到，9宝妈神器，10居家好物，11吃货专区，12数码达人，13用电能手，15伴你前行，16学习娱乐，17萌宠世界，14其他（对应好单库商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物）
        /// </summary>
        [JsonPropertyName("cat_id")]
        public int CatId { get; set; }
        /// <summary>
        /// 自定义排序 1.好单指数；2.今日销量；3.两小时销量
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }


    }
}
