using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public abstract class HaoDanKuResponse: HaoDanKuObject
    {
        /// <summary>
        /// 状态码：
        /// 200成功
        /// 0失败
        /// </summary>
        [JsonPropertyName("code")]
        public virtual int StatusCode { get; set; }

        /// <summary>
        /// 提示语
        /// </summary>
        [JsonPropertyName("msg")]
        public virtual string Msg { get; set; }

        /// <summary>
        /// 相应原始内容
        /// </summary>
        [JsonIgnore]
        public virtual string Body { get; set; }

        /// <summary>
        /// 相应结果是否成功
        /// </summary>
        [JsonIgnore]
        public virtual bool IsSuccess => StatusCode == 200;
    }
}
