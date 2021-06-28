using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public static class Utility
    {
        /// <summary>
        /// 组装XML格式请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>XML格式的请求数据</returns>
        public static string BuildContent(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var sb = new StringBuilder("<xml>");
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append("<" + iter.Key + ">" + "<![CDATA[" + iter.Value + "]]></" + iter.Key + ">");
                }
            }

            return sb.Append("</xml>").ToString();
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, object> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (iter.Value!=null && !string.IsNullOrEmpty(iter.Value.ToString()))
                {
                    sb.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value.ToString()) + "&");
                }
            }

            return sb.ToString()[0..^1];
        }

        public static string GetTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        }

        public static string GenerateNonceStr()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string RemovePreFix(this string str, params string[] preFixes)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            if (preFixes == null || preFixes.Length <= 0)
            {
                return str;
            }

            foreach (var preFix in preFixes)
            {
                if (str.StartsWith(preFix))
                {
                    return str[preFix.Length..];
                }
            }

            return str;
        }

        public static string BuildSignatureSourceData(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }

        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            IgnoreNullValues = true,
            //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            // 序列化时中文会被编码，详见博问 .NET Core 3.0 中使用 System.Text.Json 序列化中文时的编码问题 。https://www.cnblogs.com/dudu/p/11562019.html
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            AllowTrailingCommas = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
        };

        public static T Deserialize<T>(string body)
        {
            var result = JsonSerializer.Deserialize<T>(body, jsonSerializerOptions);
            return result;
        }

        public static string Serialize<T>(T obj)
        {
            var result = JsonSerializer.Serialize(obj, jsonSerializerOptions);
            return result;
        }


        public static string FirstWordToUpper(string str)
        {
            //正则的意思为：匹配多个以下划线开头的值,^是开头，+是之后的多个
            str = Regex.Replace(str, "^_+", "");
            str = str.Substring(0, 1).ToUpper() + str + str.Substring(1);
            return str;
        }

    }
}
