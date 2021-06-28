using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 达人说API输入参数
    /// </summary>
    public class TalentInfoQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 大家都在逛类目，文章类别（0.全部，1.好物,2.潮流,3.美食,4.生活）
        /// </summary>
        [JsonPropertyName("talentcat")]
        public int Talentcat { get; set; }


    }
}
