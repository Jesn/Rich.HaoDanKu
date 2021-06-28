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
    public class HaoDanKuStorageTest
    {

        private readonly IHaoDanKuClient _client;
        private IOptions<HaoDanKuOptions> _options;

        public HaoDanKuStorageTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHaoDanKu();

            IServiceProvider provider = services.BuildServiceProvider();

            _client = provider.GetService<IHaoDanKuClient>();
            _options = provider.GetService<IOptions<HaoDanKuOptions>>();
        }

        /// <summary>
        /// 商品列表页API
        /// </summary>
        [Fact]
        public async Task ItemlistTest()
        {
            var model = new ItemlistQueryModel()
            {

            };
            var request = new ItemlistRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 商品更新API
        /// </summary>
        [Fact]
        public async Task UpdateItemTest()
        {
            var model = new UpdateItemQueryModel()
            {

            };
            var request = new UpdateItemRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 定时拉取API
        /// </summary>
        [Fact]
        public async Task TimingItemsTest()
        {
            var model = new TimingItemsQueryModel()
            {

            };
            var request = new TimingItemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 失效商品列表API
        /// </summary>
        [Fact]
        public async Task GetDownItemsTest()
        {
            var model = new GetDownItemsQueryModel()
            {

            };
            var request = new GetDownItemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 完整黑名单库API
        /// </summary>
        [Fact]
        public async Task BlacklistTest()
        {
            var model = new BlacklistQueryModel()
            {

            };
            var request = new BlacklistRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
    }
}