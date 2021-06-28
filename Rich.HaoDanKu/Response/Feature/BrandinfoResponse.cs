using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 品牌信息API返回参数
    /// </summary>
    public class BrandinfoResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<BrandinfoData > Data { get; set; }
    }

    public class BrandinfoData
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
