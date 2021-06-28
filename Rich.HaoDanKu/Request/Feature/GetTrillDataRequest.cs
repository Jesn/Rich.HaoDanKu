using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 抖货商品API请求参数
    /// </summary>
    public class GetTrillDataRequest : IHaoDanKuGetRequest<GetTrillDataResponse>
    {
        private HaoDanKuObject _queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/get_trill_data";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
