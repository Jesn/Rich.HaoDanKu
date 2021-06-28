using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 达人说API返回参数
    /// </summary>
    public class TalentInfoResponse: HaoDanKuResponse
    {
        /// <summary>
        /// 置顶文章数组
        /// </summary>
        [JsonPropertyName("topdata")]
        public List<TalentInfoData> Topdata { get; set; }

        /// <summary>
        /// 最新文章数组
        /// </summary>
        [JsonPropertyName("newdata")]
        public List<TalentInfoData> Newdata { get; set; }

        /// <summary>
        /// 阅读量降序排列的文章信息
        /// </summary>
        [JsonPropertyName("clickdata")]
        public List<TalentInfoData> Clickdata { get; set; }

        [JsonPropertyName("talent_Category")]
        public Dictionary<int, string> TalentCategory { get; set; }
    }


    public class TalentInfoData
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文章短标题
        /// </summary>
        [JsonPropertyName("shorttitle")]
        public string ShortTitle { get; set; }

        /// <summary>
        /// 文章商品主图
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 置顶图片
        /// </summary>
        [JsonPropertyName("app_image")]
        public string AppImage { get; set; }

        /// <summary>
        /// 文章标签
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 文章包含商品的id
        /// </summary>
        [JsonPropertyName("tk_item_id")]
        public string TkItemId { get; set; }

        /// <summary>
        /// 文章banner
        /// </summary>
        [JsonPropertyName("article_banner")]
        public string ArticleBanner { get; set; }

        /// <summary>
        /// 文章置顶1是，0否
        /// </summary>
        [JsonPropertyName("highquality")]
        public int Highquality { get; set; }

        /// <summary>
        /// 浏览量
        /// </summary>
        [JsonPropertyName("readtimes")]
        public int Readtimes { get; set; }

        /// <summary>
        /// 达人名号ID
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string TalentId { get; set; }

        /// <summary>
        /// 达人名号
        /// </summary>
        [JsonPropertyName("talent_name")]
        public string TalentName { get; set; }

        /// <summary>
        /// 达人头像
        /// </summary>
        [JsonPropertyName("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 正文简介
        /// </summary>
        [JsonPropertyName("article")]
        public string Article { get; set; }

        /// <summary>
        /// 文章类别（1.好物,2.潮流,3.美食,4.生活）
        /// </summary>
        [JsonPropertyName("talentcat")]
        public int TalentCat { get; set; }

        /// <summary>
        /// 文章包含商品的数量
        /// </summary>
        [JsonPropertyName("itemnum")]
        public string Itemnum { get; set; }
    }

    

}
