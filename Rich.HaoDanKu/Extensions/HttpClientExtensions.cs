using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rich.HaoDanKu.Extensions
{
    public static class HttpClientExtensions
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static async Task<(string body, int statusCode)> GetAsync<T>(this HttpClient client, IHaoDanKuGetRequest<T> request, HaoDanKuOptions options)
            where T : HaoDanKuResponse
        {
            var url = request.GetRequestUrl();

            if (!string.IsNullOrEmpty(options.AppKey))
            {
                url += $"?apikey={options.AppKey}";
            }

            if (request.GetNeedQueryModel())
            {
                var queryModel = request.GetQueryModel();
                if (queryModel != null)
                {
                    if (url.Contains("?"))
                    {
                        var txtParams = ConvertToDictionary(queryModel);
                        if (txtParams.Count>0)
                        {
                            url += "&" + Utility.BuildQuery(txtParams);
                        }
                    }
                    else
                    {
                        var txtParams = ConvertToDictionary(queryModel);
                        if (txtParams.Count>0)
                        {
                            url += "?" + Utility.BuildQuery(txtParams);
                        }
                    }
                }
            }

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            using (var resp = await client.GetAsync(url))
            using (var respContent = resp.Content)
            {
                var body = await respContent.ReadAsStringAsync();
                var statusCode = (int)resp.StatusCode;

                //body = Unicode2String(body);

                return (body, statusCode);
            }
        }
        public static string Unicode2String(string source)
        {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(
                         source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }

        public static async Task<(string body, int statusCode)> PostAsync<T>(this HttpClient client, IHaoDanKuPostRequest<T> request, HaoDanKuOptions options) where T : HaoDanKuResponse
        {
            var url = request.GetRequestUrl();
            var bodyModel = request.GetBodyModel();

            if (bodyModel == null)
            {
                throw new HaoDanKuException("request.BodyModel is null!");
            }

            var content = JsonSerializer.Serialize(bodyModel, bodyModel.GetType(), jsonSerializerOptions);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/json"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                var body = await respContent.ReadAsStringAsync();
                var statusCode = (int)resp.StatusCode;

                return (body, statusCode);
            }
        }

        private static IDictionary<string, object> ConvertToDictionary(HaoDanKuObject obj)
        {
            var str = JsonSerializer.Serialize(obj, obj.GetType(), jsonSerializerOptions);
            return JsonSerializer.Deserialize<IDictionary<string, object>>(str, jsonSerializerOptions);
        }

    }
}
