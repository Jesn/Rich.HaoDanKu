using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 文章详情API请求参数
    /// </summary>
    public class TalentArticleRequest : IHaoDanKuGetRequest<TalentArticleResponse>
    {
        private HaoDanKuObject _queryModel;

        public HaoDanKuObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/talent_article";
        }

        public void SetQueryModel(HaoDanKuObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
