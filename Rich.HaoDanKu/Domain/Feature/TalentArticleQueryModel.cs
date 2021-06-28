using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 文章详情API输入参数
    /// </summary>
    public class TalentArticleQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 达人文章ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


    }
}
