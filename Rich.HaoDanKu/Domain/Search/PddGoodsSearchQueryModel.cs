using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 拼多多超级搜索输入参数
    /// </summary>
    public class PddGoodsSearchQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 搜索关键词，支持拼多多商品链接、拼多多分享短链接、商品ID、商品标题（由于存在特殊符号搜索的关键词必须进行两次urlencode编码）
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }
        /// <summary>
        /// 分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 搜索ID（搜索全网商品使用，选填）
        /// </summary>
        [JsonPropertyName("list_id")]
        public int ListId { get; set; }


    }
}
