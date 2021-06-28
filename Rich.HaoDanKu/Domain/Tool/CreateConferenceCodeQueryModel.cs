using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 会场转链API输入参数
    /// </summary>
    public class CreateConferenceCodeQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 会场ID（*必要）
        /// </summary>
        [JsonPropertyName("activity_id")]
        public int ActivityId { get; set; }
        /// <summary>
        /// 推广位ID（*必要 需是授权淘宝号下的推广位，如果请求的时候携带了渠道id请求，则该pid需是渠道管理下面的渠道专属推广位）
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 渠道ID
        /// </summary>
        [JsonPropertyName("relation_id")]
        public string RelationId { get; set; }
        /// <summary>
        /// 授权后的淘宝名称（*必要，多授权淘宝号时用于区分哪个淘宝账户的*）
        /// </summary>
        [JsonPropertyName("tb_name")]
        public string TbName { get; set; }
        /// <summary>
        /// 会场短标题（*用于返回淘口令，需超过8个字符*）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>
        /// 会场链接地址（*选填，该参数与会场ID二选一，该参数无需tb_name*）
        /// </summary>
        [JsonPropertyName("activity_url")]
        public string ActivityUrl { get; set; }


    }
}
