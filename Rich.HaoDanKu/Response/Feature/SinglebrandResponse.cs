using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 单个品牌详情API返回参数
    /// </summary>
    public class SinglebrandResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<SinglebrandData > Data { get; set; }
    }

    public class SinglebrandData
    {
        /// <summary>
        /// 品牌自增ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 淘宝品牌名称
        /// </summary>
        [JsonPropertyName("tb_brand_name")]
        public string TbBrandName { get; set; }

        /// <summary>
        /// 蜂擎品牌名称
        /// </summary>
        [JsonPropertyName("fq_brand_name")]
        public string FqBrandName { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 内页logo
        /// </summary>
        [JsonPropertyName("inside_logo")]
        public string InsideLogo { get; set; }

        /// <summary>
        /// 品牌类目
        /// </summary>
        [JsonPropertyName("brandcat")]
        public int Brandcat { get; set; }

        /// <summary>
        /// 品牌简介
        /// </summary>
        [JsonPropertyName("introduce")]
        public string Introduce { get; set; }

    }

}
