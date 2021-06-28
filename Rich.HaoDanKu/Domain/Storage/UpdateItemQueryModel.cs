using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 商品更新API输入参数
    /// </summary>
    public class UpdateItemQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 更新排序（1好单指数，2月销量，3近两小时销量，4当天销量，5在线人数，6活动开始时间）
        /// </summary>
        [JsonPropertyName("sort")]
        public int Sort { get; set; }
        /// <summary>
        /// 每页返回条数（请在1,2,10,20,50,100,120,200,500,1000中选择一个数值返回）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }


    }
}
