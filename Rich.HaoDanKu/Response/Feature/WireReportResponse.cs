using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 实时线报数据返回参数
    /// </summary>
    public class WireReportResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<WireReportData > Data { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [JsonPropertyName("label")]
        public List<Label> Labels { get; set; }
    }

    public class WireReportData
    {
        /// <summary>
        /// 线报原始文案
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 线报发布时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 线报主图
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 类目标签
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 数据来源 1.淘宝；2.京东；
        /// </summary>
        [JsonPropertyName("source")]
        public int Source { get; set; }

    }

    public class Label
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonPropertyName("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonPropertyName("type_name")]
        public string TypeName { get; set; }
    }

}
