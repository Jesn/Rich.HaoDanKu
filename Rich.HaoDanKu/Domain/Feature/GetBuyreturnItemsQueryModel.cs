using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 超值买返商品API输入参数
    /// </summary>
    public class GetBuyreturnItemsQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 排序：1.返现比例（从高到低）；2.预估支出（从少到多）；3.热销（月销量从高到低）
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 每页返回条数（请在10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }


    }
}
