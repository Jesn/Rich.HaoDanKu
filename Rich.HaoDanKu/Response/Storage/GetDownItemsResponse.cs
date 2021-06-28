using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 失效商品列表API返回参数
    /// </summary>
    public class GetDownItemsResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetDownItemsData > Data { get; set; }
    }

    public class GetDownItemsData
    {
        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public string Itemid { get; set; }

        /// <summary>
        /// 优惠券ID
        /// </summary>
        [JsonPropertyName("activityid")]
        public string Activityid { get; set; }

        /// <summary>
        /// 下架原因（1失效，2过期，3价格改变（券条件不符），4低佣，5自主下架,6用户删除，7拉黑下架，8举报下架，9刷榜下架，10.更高优惠券替换下架，11.自主换券下架）
        /// </summary>
        [JsonPropertyName("down_type")]
        public string DownType { get; set; }

        /// <summary>
        /// 下架时间（时间戳）
        /// </summary>
        [JsonPropertyName("down_time")]
        public string DownTime { get; set; }

    }

}
