using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 抖音数据API返回参数
    /// </summary>
    public class DouyinItemsResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<DouyinItemsData > Data { get; set; }
    }

    public class DouyinItemsData
    {
        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public long ItemId { get; set; }

        /// <summary>
        /// 视频地址
        /// </summary>
        [JsonPropertyName("video_url")]
        public int VideoUrl { get; set; }

        /// <summary>
        /// 抖音主播粉丝数
        /// </summary>
        [JsonPropertyName("douyin_emcee_fans")]
        public int DouyinEmceeFans { get; set; }

        /// <summary>
        /// 视频喜欢点赞数
        /// </summary>
        [JsonPropertyName("video_like_count")]
        public int VideoLikeCount { get; set; }

        /// <summary>
        /// 视频评论数
        /// </summary>
        [JsonPropertyName("video_comment_count")]
        public int VideoCommentCount { get; set; }

        /// <summary>
        /// 视频转发数
        /// </summary>
        [JsonPropertyName("video_forward_count")]
        public int VideoForwardCount { get; set; }

        /// <summary>
        /// 视频第一帧图片地址（视频缩略图）
        /// </summary>
        [JsonPropertyName("first_frame")]
        public string FirstFrame { get; set; }

        /// <summary>
        /// 视频第一动态图
        /// </summary>
        [JsonPropertyName("dynamic_image")]
        public string DynamicImage { get; set; }

        /// <summary>
        /// 视频分享量
        /// </summary>
        [JsonPropertyName("video_share_count")]
        public int VideoShareCount { get; set; }

    }

}
