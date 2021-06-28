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
    public class HaoDanKuSearchTest
    {

        private readonly IHaoDanKuClient _client;
        private IOptions<HaoDanKuOptions> _options;

        public HaoDanKuSearchTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHaoDanKu();

            IServiceProvider provider = services.BuildServiceProvider();

            _client = provider.GetService<IHaoDanKuClient>();
            _options = provider.GetService<IOptions<HaoDanKuOptions>>();
        }


        /// <summary>
        /// 拼多多实时热榜
        /// </summary>
        [Fact]
        public async Task PddHotRankTest()
        {
            var model = new PddHotRankQueryModel()
            {
                MinId=1,
                Cid=0
            };
            var request = new PddHotRankRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 京东实时热榜
        /// </summary>
        [Fact]
        public async Task JdHotRankTest()
        {
            var model = new JdHotRankQueryModel()
            {
                MinId=1,
                Cid=0
            };
            var request = new JdHotRankRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 拼多多超级搜索
        /// </summary>
        [Fact]
        public async Task PddGoodsSearchTest()
        {
            var model = new PddGoodsSearchQueryModel()
            {
                MinId=1,
                Keyword="儿童"
            };
            var request = new PddGoodsSearchRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 淘宝超级搜索
        /// </summary>
        [Fact]
        public async Task SupersearchTest()
        {
            var model = new SupersearchQueryModel()
            {
                Keyword="儿童"
            };
            var request = new SupersearchRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 单品详情API
        /// </summary>
        [Fact]
        public async Task ItemDetailTest()
        {
            var model = new ItemDetailQueryModel()
            {
                ItemId= "595790136426"
            };
            var request = new ItemDetailRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 商品筛选API
        /// </summary>
        [Fact]
        public async Task ColumnTest()
        {
            var model = new ColumnQueryModel()
            {
                MinId=1
            };
            var request = new ColumnRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 超级分类API
        /// </summary>
        [Fact]
        public async Task SuperClassifyTest()
        {
            var model = new SuperClassifyQueryModel()
            {
                
            };
            var request = new SuperClassifyRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.GeneralClassify != null);
        }
        /// <summary>
        /// 猜你喜欢API
        /// </summary>
        [Fact]
        public async Task GetSimilarInfoTest()
        {
            var model = new GetSimilarInfoQueryModel()
            {
                ItemId = "641458151467"
            };
            var request = new GetSimilarInfoRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 热搜关键词记录API
        /// </summary>
        [Fact]
        public async Task HotKeyTest()
        {
            var model = new HotKeyQueryModel()
            {

            };
            var request = new HotKeyRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 京东超级搜索
        /// </summary>
        [Fact]
        public async Task JdGoodsSearchTest()
        {
            var model = new JdGoodsSearchQueryModel()
            {
                Keyword="儿童"
            };
            var request = new JdGoodsSearchRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }

    }
}