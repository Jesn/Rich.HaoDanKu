using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 失效商品列表API输入参数
    /// </summary>
    public class GetDownItemsQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 小时点数，如0点是0、13点是13（最小值是0，最大值是23）
        /// </summary>
        [JsonPropertyName("start")]
        public int Start { get; set; }
        /// <summary>
        /// 小时点数，如0点是0、13点是13（最小值是0，最大值是23）
        /// </summary>
        [JsonPropertyName("end")]
        public int End { get; set; }


    }
}
