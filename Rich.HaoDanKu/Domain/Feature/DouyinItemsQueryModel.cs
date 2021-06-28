using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 抖音数据API输入参数
    /// </summary>
    public class DouyinItemsQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }


    }
}
