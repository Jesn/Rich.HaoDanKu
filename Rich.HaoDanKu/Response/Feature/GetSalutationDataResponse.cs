using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 早晚安问候语API返回参数
    /// </summary>
    public class GetSalutationDataResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetSalutationDataData > Data { get; set; }
    }

    public class GetSalutationDataData
    {
        /// <summary>
        /// 问候语图片地址
        /// </summary>
        [JsonPropertyName("imgsrc")]
        public string Imgsrc { get; set; }

        /// <summary>
        /// 问候语内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonPropertyName("likenum")]
        public int Likenum { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("categoryid")]
        public int Categoryid { get; set; }

    }

}
