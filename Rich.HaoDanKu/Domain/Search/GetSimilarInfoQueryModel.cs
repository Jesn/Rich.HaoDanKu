using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 猜你喜欢API输入参数
    /// </summary>
    public class GetSimilarInfoQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 获取猜你喜欢的类型商品的宝贝ID，可以优先获取相同二级类目下的商品
        /// </summary>
        [JsonPropertyName("itemid")]
        public string ItemId { get; set; }


    }
}
