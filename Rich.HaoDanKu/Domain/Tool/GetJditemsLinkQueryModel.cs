using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Domain
{
    /// <summary>
    /// 京东商品转链输入参数
    /// </summary>
    public class GetJditemsLinkQueryModel : HaoDanKuObject
    {
        /// <summary>
        /// 京东商品链接（*必要）
        /// </summary>
        [JsonPropertyName("material_id")]
        public int MaterialId { get; set; }
        /// <summary>
        /// 目标推客的联盟ID（*必要）
        /// </summary>
        [JsonPropertyName("union_id")]
        public int UnionId { get; set; }
        /// <summary>
        /// 优惠券链接
        /// </summary>
        [JsonPropertyName("coupon_url")]
        public string CouponUrl { get; set; }


    }
}
