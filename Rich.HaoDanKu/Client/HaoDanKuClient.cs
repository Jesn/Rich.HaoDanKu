using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Rich.HaoDanKu.Extensions;
using Rich.HaoDanKu.Parser;

namespace Rich.HaoDanKu
{
    public class HaoDanKuClient : IHaoDanKuClient
    {
        public const string clientName = "haodanku.client";

        private readonly IHttpClientFactory _httpClientFactory;


        public HaoDanKuClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<T> ExecuteAsync<T>(IHaoDanKuGetRequest<T> request, HaoDanKuOptions options)
            where T : HaoDanKuResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            if (string.IsNullOrEmpty(options.AppKey))
            {
                throw new HaoDanKuException($"options.{nameof(options.AppKey)} is empty");
            }
            var client = _httpClientFactory.CreateClient(clientName);

            var (body, statusCode) = await client.GetAsync(request, options);

            var parser = new HaoDanKuResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);
            return response;
        }

        public async Task<T> ExecuteAsync<T>(IHaoDanKuPostRequest<T> request, HaoDanKuOptions options) where T : HaoDanKuResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            if (string.IsNullOrEmpty(options.AppKey))
            {
                throw new HaoDanKuException($"options.{nameof(options.AppKey)} is empty");
            }
            var client = _httpClientFactory.CreateClient(clientName);

            var ( body, statusCode) = await client.PostAsync(request, options);

            var parser = new HaoDanKuResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            return response;
        }

    }
}
