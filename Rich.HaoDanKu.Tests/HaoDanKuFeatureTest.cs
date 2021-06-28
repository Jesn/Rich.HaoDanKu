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
    public class HaoDanKuFeatureTest
    {

        private readonly IHaoDanKuClient _client;
        private IOptions<HaoDanKuOptions> _options;

        public HaoDanKuFeatureTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHaoDanKu();

            IServiceProvider provider = services.BuildServiceProvider();

            _client = provider.GetService<IHaoDanKuClient>();
            _options = provider.GetService<IOptions<HaoDanKuOptions>>();
        }

        /// <summary>
        /// 签到红包商品
        /// </summary>
        [Fact]
        public async Task SignRedPackGoodsTest()
        {
            var model = new SignRedPackGoodsQueryModel()
            {
                Keyword="儿童"
            };
            var request = new SignRedPackGoodsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 京东商品列表
        /// </summary>
        [Fact]
        public async Task GetJdItemlistTest()
        {
            var model = new GetJdItemlistQueryModel()
            {
                
            };
            var request = new GetJdItemlistRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 拼多多商品列表
        /// </summary>
        [Fact]
        public async Task GetPddItemlistTest()
        {
            var model = new GetPddItemlistQueryModel()
            {

            };
            var request = new GetPddItemlistRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 超值买返商品API
        /// </summary>
        [Fact]
        public async Task GetBuyreturnItemsTest()
        {
            var model = new GetBuyreturnItemsQueryModel()
            {

            };
            var request = new GetBuyreturnItemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 实时佣金榜API
        /// </summary>
        [Fact]
        public async Task GetCurrentCommissionTest()
        {
            var model = new GetCurrentCommissionQueryModel()
            {

            };
            var request = new GetCurrentCommissionRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 定向计划商品API
        /// </summary>
        [Fact]
        public async Task GetOrienteeringitemsTest()
        {
            var model = new GetOrienteeringitemsQueryModel()
            {

            };
            var request = new GetOrienteeringitemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 高佣专场商品API
        /// </summary>
        [Fact]
        public async Task GetHighitemsTest()
        {
            var model = new GetHighitemsQueryModel()
            {

            };
            var request = new GetHighitemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 早晚安问候语API
        /// </summary>
        [Fact]
        public async Task GetSalutationDataTest()
        {
            var model = new GetSalutationDataQueryModel()
            {

            };
            var request = new GetSalutationDataRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 精选低价包邮专区API
        /// </summary>
        [Fact]
        public async Task LowPricePinkageDataTest()
        {
            var model = new LowPricePinkageDataQueryModel()
            {

            };
            var request = new LowPricePinkageDataRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 抖音数据API
        /// </summary>
        [Fact]
        public async Task DouyinItemsTest()
        {
            var model = new DouyinItemsQueryModel()
            {

            };
            var request = new DouyinItemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 偏远地区包邮商品API
        /// </summary>
        [Fact]
        public async Task GetFreeShippingDataTest()
        {
            var model = new GetFreeShippingDataQueryModel()
            {

            };
            var request = new GetFreeShippingDataRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 抖货商品API
        /// </summary>
        [Fact]
        public async Task GetTrillDataTest()
        {
            var model = new GetTrillDataQueryModel()
            {

            };
            var request = new GetTrillDataRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 各大榜单API
        /// </summary>
        [Fact]
        public async Task SalesListTest()
        {
            var model = new SalesListQueryModel()
            {

            };
            var request = new SalesListRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 今日值得买API
        /// </summary>
        [Fact]
        public async Task GetDeserveItemTest()
        {
            var model = new GetDeserveItemQueryModel()
            {

            };
            var request = new GetDeserveItemRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 精选专题API
        /// </summary>
        [Fact]
        public async Task GetSubjectTest()
        {
            var model = new GetSubjectQueryModel()
            {

            };
            var request = new GetSubjectRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 精编文案API
        /// </summary>
        [Fact]
        public async Task ExcellentEditorTest()
        {
            var model = new ExcellentEditorQueryModel()
            {

            };
            var request = new ExcellentEditorRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 我的收藏
        /// </summary>
        [Fact]
        public async Task GetCollectItemsTest()
        {
            var model = new GetCollectItemsQueryModel()
            {

            };
            var request = new GetCollectItemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 快抢商品API
        /// </summary>
        [Fact]
        public async Task FastbuyTest()
        {
            var model = new FastbuyQueryModel()
            {

            };
            var request = new FastbuyRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 品牌信息API
        /// </summary>
        [Fact]
        public async Task BrandinfoTest()
        {
            var model = new BrandinfoQueryModel()
            {

            };
            var request = new BrandinfoRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 单个品牌详情API
        /// </summary>
        [Fact]
        public async Task SinglebrandTest()
        {
            var model = new SinglebrandQueryModel()
            {

            };
            var request = new SinglebrandRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 主题品牌栏API
        /// </summary>
        [Fact]
        public async Task BrandSubjectitemsTest()
        {
            var model = new BrandSubjectitemsQueryModel()
            {

            };
            var request = new BrandSubjectitemsRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
        /// <summary>
        /// 朋友圈API
        /// </summary>
        [Fact]
        public async Task SelectedItemTest()
        {
            var model = new SelectedItemQueryModel()
            {

            };
            var request = new SelectedItemRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _options.Value);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }

    }
}