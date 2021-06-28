using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 实时线报数据输入参数
    /// </summary>
    public class WireReportQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回）
        /// </summary>
        [JsonPropertyName("min_size")]
        public int MinSize { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }


    }
}
