using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rich.HaoDanKu.Response
{
    /// <summary>
    /// 精选专题API返回参数
    /// </summary>
    public class GetSubjectResponse: HaoDanKuResponse
    {
        [JsonPropertyName("data")]
        public List<GetSubjectData > Data { get; set; }
    }

    public class GetSubjectData
    {
        /// <summary>
        /// 专题id，用于在下一个接口获取专题的商品
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 专题的标题
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 专题banner（正方形图）,图片拼接地址如：http://img-haodanku-com.cdn.fudaiapp.com/FlfXRXa3NK68Qy8Kvj_QscpMp3xw-600
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 专题banner（长方形有弧度图）,图片拼接地址如：http://img-haodanku-com.cdn.fudaiapp.com/FosY6Szk5scmidEkK6tzIqMRM4kR-600
        /// </summary>
        [JsonPropertyName("app_image")]
        public string AppImage { get; set; }

        /// <summary>
        /// 专题banner（长方形无弧度图）,图片拼接地址如：http://img-haodanku-com.cdn.fudaiapp.com/FhqJGdrTkCzI56350Ews0zEkMwBT-600
        /// </summary>
        [JsonPropertyName("cms_image")]
        public string CmsImage { get; set; }

        /// <summary>
        /// 专题的介绍文案题
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 专题活动开始时间戳
        /// </summary>
        [JsonPropertyName("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 专题活动结束时间戳
        /// </summary>
        [JsonPropertyName("activity_end_time")]
        public string ActivityEndTime { get; set; }

    }

}
