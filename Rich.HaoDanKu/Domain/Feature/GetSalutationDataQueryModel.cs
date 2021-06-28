using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 早晚安问候语API输入参数
    /// </summary>
    public class GetSalutationDataQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 分类：1.早安问候；2.用餐问候；3.晚安问候；4.群内公告；5.节日问候；6.爆笑段子；7.其他
        /// </summary>
        [JsonPropertyName("category")]
        public int Category { get; set; }
        /// <summary>
        /// 状态，每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }


    }
}
