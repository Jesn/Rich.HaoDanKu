using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 淘宝商品转链返回参数
    /// </summary>
    public class RatesurlResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<RatesurlData > Data { get; set; }
    }

    public class RatesurlData
    {
        /// <summary>
        /// 高佣优惠券链接
        /// </summary>
        [JsonPropertyName("coupon_click_url")]
        public string CouponClickUrl { get; set; }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [JsonPropertyName("max_commission_rate")]
        public string MaxCommissionRate { get; set; }

        /// <summary>
        /// 当入参special_id、relation_id、external_id时，该字段展示预估最低佣金率(%)
        /// </summary>
        [JsonPropertyName("min_commission_rate")]
        public string MinCommissionRate { get; set; }

        /// <summary>
        /// 优惠券金额，若没有优惠券则返回0
        /// </summary>
        [JsonPropertyName("couponmoney")]
        public string CouponMoney { get; set; }

        /// <summary>
        /// 优惠券开始时间，若没有则返回空
        /// </summary>
        [JsonPropertyName("couponstarttime")]
        public string CouponStartTime { get; set; }

        /// <summary>
        /// 优惠券结束时间，若没有则返回空
        /// </summary>
        [JsonPropertyName("couponendtime")]
        public string CouponendTime { get; set; }

        /// <summary>
        /// 优惠券使用条件，若没有则返回空
        /// </summary>
        [JsonPropertyName("couponexplain")]
        public string Couponexplain { get; set; }

        /// <summary>
        /// 优惠券总量，若没有则返回空
        /// </summary>
        [JsonPropertyName("couponnum")]
        public string CouponNum { get; set; }

        /// <summary>
        /// 优惠券剩余量，若没有则返回空
        /// </summary>
        [JsonPropertyName("couponsurplus")]
        public string Couponsurplus { get; set; }

        /// <summary>
        /// 优惠券领取量，若没有则返回空
        /// </summary>
        [JsonPropertyName("couponreceive")]
        public string Couponreceive { get; set; }

        /// <summary>
        /// 单品链接，没有券的情况可以直接进入淘宝购买页
        /// </summary>
        [JsonPropertyName("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 淘口令，若没有则返回空
        /// </summary>
        [JsonPropertyName("taoword")]
        public string Taoword { get; set; }

        /// <summary>
        /// 淘口令，若没有则返回空
        /// </summary>
        [JsonPropertyName("new_model")]
        public string NewModel { get; set; }

        /// <summary>
        /// 商品标题title参数，若没有则返回空
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 预售有礼-推广链接
        /// </summary>
        [JsonPropertyName("ysyl_click_url")]
        public string YsylClickUrl { get; set; }

        /// <summary>
        /// 预售有礼-预估淘礼金（元）
        /// </summary>
        [JsonPropertyName("ysyl_tlj_face")]
        public string YsylTljFace { get; set; }

        /// <summary>
        /// 预售有礼-淘礼金发放时间
        /// </summary>
        [JsonPropertyName("ysyl_tlj_send_time")]
        public string YsylTljSendTime { get; set; }

        /// <summary>
        /// 预售有礼-淘礼金使用开始时间
        /// </summary>
        [JsonPropertyName("ysyl_tlj_use_start_time")]
        public string YsylTljUseStartTime { get; set; }

        /// <summary>
        /// 预售有礼-淘礼金使用结束时间
        /// </summary>
        [JsonPropertyName("ysyl_tlj_use_end_time")]
        public string YsylTljUseEndTime { get; set; }

        /// <summary>
        /// 特殊玩法转链结果
        /// </summary>
        [JsonPropertyName("special")]
        public Dictionary<string,string> Special { get; set; }

    }

}
