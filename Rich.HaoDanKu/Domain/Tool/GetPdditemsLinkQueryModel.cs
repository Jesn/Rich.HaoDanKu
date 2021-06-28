using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 拼多多商品转链输入参数
    /// </summary>
    public class GetPdditemsLinkQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 拼多多商品ID（*必要）
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }
        /// <summary>
        /// 拼多多推广位ID（*必要）
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 商品goodsSign（*必要）
        /// </summary>
        [JsonPropertyName("goods_sign")]
        public string GoodsSign { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonPropertyName("zs_duo_id")]
        public int ZsDuoId { get; set; }
        /// <summary>
        /// 授权access_token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }


    }
}
