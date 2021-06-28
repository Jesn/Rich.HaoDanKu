using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 超级分类API返回参数
    /// </summary>
    public class SuperClassifyResponse: HaoDanKuResponse
    {
        [JsonPropertyName("general_classify")]
        public List<GeneralClassify> GeneralClassify { get; set; }
    }


    public class GeneralClassify
    {
        /// <summary>
        /// 所属类目：1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体
        /// </summary>
        [JsonPropertyName("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// 二级类目总称
        /// </summary>
        [JsonPropertyName("main_name")]
        public string MainName { get; set; }

        /// <summary>
        /// 超级分类数据
        /// </summary>
        [JsonPropertyName("data")]
        public List<SuperClassifyData> Data { get; set; }

    }


    public class SuperClassifyData
    {
        [JsonPropertyName("next_name")]
        public string NextName { get; set; }

        [JsonPropertyName("info")]
        public List<SuperClassifyInfo> SuperClassifyInfo { get; set; }
    }

    public class SuperClassifyInfo
    {
        /// <summary>
        /// 二级具体类目名
        /// </summary>
        [JsonPropertyName("son_name")]
        public string SonName { get; set; }

        /// <summary>
        /// 分类图
        /// </summary>
        [JsonPropertyName("imgurl")]
        public string Imgurl { get; set; }

    }

}
