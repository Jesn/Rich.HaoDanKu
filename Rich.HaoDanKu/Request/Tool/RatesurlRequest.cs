using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 淘宝商品转链请求参数
    /// </summary>
    public class RatesurlRequest: IHaoDanKuPostRequest<RatesurlResponse>
    {
        private HaoDanKuObject _bodyModel;

        public HaoDanKuObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/ratesurl";
        }

        public void SetBodyModel(HaoDanKuObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
