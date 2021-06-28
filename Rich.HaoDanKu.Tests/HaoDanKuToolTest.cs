using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Rich.HaoDanKu.Domain;
using Rich.HaoDanKu.Extensions;
using Rich.HaoDanKu.Request;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Rich.HaoDanKu.Tests
{
    public class HaoDanKuToolTest
    {

        private readonly IHaoDanKuClient _client;
        private IOptions<HaoDanKuOptions> _options;

        public HaoDanKuToolTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHaoDanKu();

            IServiceProvider provider = services.BuildServiceProvider();

            _client = provider.GetService<IHaoDanKuClient>();
            _options = provider.GetService<IOptions<HaoDanKuOptions>>();
        }

        /// <summary>
        /// 京东商品转链
        /// </summary>
        [Fact]
        public async Task GetJditemsLinkTest()
        {
            var model = new GetJditemsLinkQueryModel()
            {

            };
            var request = new GetJditemsLinkRequest();
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 拼多多商品转链
        /// </summary>
        [Fact]
        public async Task GetPdditemsLinkTest()
        {
            var model = new GetPdditemsLinkQueryModel()
            {

            };
            var request = new GetPdditemsLinkRequest();
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 超值买返转链API
        /// </summary>
        [Fact]
        public async Task GetBuyresultUrlTest()
        {
            var model = new GetBuyresultUrlQueryModel()
            {

            };
            var request = new GetBuyresultUrlRequest();
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 会场转链API
        /// </summary>
        [Fact]
        public async Task CreateConferenceCodeTest()
        {
            var model = new CreateConferenceCodeQueryModel()
            {

            };
            var request = new CreateConferenceCodeRequest();
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 店铺转链API
        /// </summary>
        [Fact]
        public async Task ShopConvertCodeTest()
        {
            var model = new ShopConvertCodeQueryModel()
            {

            };
            var request = new ShopConvertCodeRequest();
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
    }
}