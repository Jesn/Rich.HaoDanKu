using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 超值买返转链API请求参数
    /// </summary>
    public class GetBuyresultUrlRequest: IHaoDanKuPostRequest<GetBuyresultUrlResponse>
    {
        private HaoDanKuObject _bodyModel;

        public HaoDanKuObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/get_buyresult_url";
        }

        public void SetBodyModel(HaoDanKuObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
