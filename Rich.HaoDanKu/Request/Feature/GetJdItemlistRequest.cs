using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 京东商品列表请求参数
    /// </summary>
    public class GetJdItemlistRequest : IHaoDanKuGetRequest<GetJdItemlistResponse>
    {
        private HaoDanKuObject _queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/get_jd_itemlist";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
