using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Rich.HaoDanKu.Parser
{
    public class HaoDanKuResponseJsonParser<T>
          where T : HaoDanKuResponse
    {
        private static  JsonSerializerOptions jsonSerializerOptions = new()
        {
            ReadCommentHandling = JsonCommentHandling.Skip,
            IgnoreNullValues = true,
            //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            // 序列化时中文会被编码，详见博问 .NET Core 3.0 中使用 System.Text.Json 序列化中文时的编码问题 。https://www.cnblogs.com/dudu/p/11562019.html
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            AllowTrailingCommas = true,
            WriteIndented = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString,
            
        };

        public T Parse(string body, int statusCode)
        {
            T result = null;

            try
            {
                if (body.StartsWith("{") && body.EndsWith("}"))
                {
                    result = JsonSerializer.Deserialize<T>(body, jsonSerializerOptions);
                }
            }
            catch (Exception ex)
            {

            }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            result.Body = body;
            result.StatusCode = statusCode;

            return result;
        }
    }
}
