using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 今日推荐品牌API请求参数
    /// </summary>
    public class BrandTodayRecommendRequest : IHaoDanKuGetRequest<BrandTodayRecommendResponse>
    {
        private HaoDanKuObject queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/brand_todayrecommend";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
