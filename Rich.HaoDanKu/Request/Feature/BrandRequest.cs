using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 品牌列表API请求参数
    /// </summary>
    public class BrandRequest : IHaoDanKuGetRequest<BrandResponse>
    {
        private HaoDanKuObject queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/brand";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
