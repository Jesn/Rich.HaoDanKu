using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 单个品牌详情API输入参数
    /// </summary>
    public class SinglebrandQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
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
        /// 自定义排序【1.最新，2.销量（高到低），3.销量（低到高），4.价格(低到高)，5.价格（高到低），6.佣金比例（高到低）】
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }


    }
}
