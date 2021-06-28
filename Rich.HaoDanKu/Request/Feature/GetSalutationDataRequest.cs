using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 早晚安问候语API请求参数
    /// </summary>
    public class GetSalutationDataRequest : IHaoDanKuGetRequest<GetSalutationDataResponse>
    {
        private HaoDanKuObject _queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/get_salutation_data";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
