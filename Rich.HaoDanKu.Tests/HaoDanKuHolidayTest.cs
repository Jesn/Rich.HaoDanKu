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
    public class HaoDanKuHolidayTest : HaoDankuTestBase
    {

        private readonly IHaoDanKuClient _client;
        private IOptions<HaoDanKuOptions> _options;

        public HaoDanKuHolidayTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHaoDanKu();

            IServiceProvider provider = services.BuildServiceProvider();

            _client = provider.GetService<IHaoDanKuClient>();
            _options = provider.GetService<IOptions<HaoDanKuOptions>>();
        }

        /// <summary>
        /// 节日版块API-38女王节（活动已结束）
        /// </summary>
        [Fact]
        public async Task GetActivityDataTest()
        {
            var model = new GetActivityDataQueryModel()
            {

            };
            var request = new GetActivityDataRequest();
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, options);
            Assert.True(response.StatusCode == 200 && response.Data != null);
        }
    }
}