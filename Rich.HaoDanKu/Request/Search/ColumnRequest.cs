using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 商品筛选API请求参数
    /// </summary>
    public class ColumnRequest : IHaoDanKuGetRequest<ColumnResponse>
    {
        private HaoDanKuObject _queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/column";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
