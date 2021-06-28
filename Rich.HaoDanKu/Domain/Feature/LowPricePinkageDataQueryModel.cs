using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 精选低价包邮专区API输入参数
    /// </summary>
    public class LowPricePinkageDataQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 作为请求地址中获取下一页的参数值，默认是1
        /// </summary>
        [JsonPropertyName("min_id")]
        public int MinId { get; set; }
        /// <summary>
        /// 自定义排序 1.综合；2.券后价从高到低；3.券后价从低到高；4.销量从高到低；5.销量价从低到高；（默认是1）
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
        /// <summary>
        /// 状态，每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        /// </summary>
        [JsonPropertyName("back")]
        public int Back { get; set; }
        /// <summary>
        /// 状态，1.精选专区；2. 9.9专区；3. 6.9专区；4. 3.9专区（默认1）
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }
        /// <summary>
        /// 筛选，1.天猫商品；2.淘宝商品（C店）
        /// </summary>
        [JsonPropertyName("screen_type")]
        public int ScreenType { get; set; }


    }
}
