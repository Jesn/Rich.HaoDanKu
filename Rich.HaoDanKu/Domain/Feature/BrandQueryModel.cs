using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 品牌列表API输入参数
    /// </summary>
    public class BrandQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 返回个数，默认返回20条数据
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 根据上一次请求作为下一次请求的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 品牌分类：默认选择全部分类，1是母婴童品，2百变女装，3是食品酒水，4是居家日用，5是美妆洗护，6是品质男装，7是舒适内衣，8是箱包配饰，9是男女鞋靴，10是宠物用品，11是数码家电，12是车品文体
        /// </summary>
        [JsonPropertyName("brandcat")]
        public int Brandcat { get; set; }


    }
}
