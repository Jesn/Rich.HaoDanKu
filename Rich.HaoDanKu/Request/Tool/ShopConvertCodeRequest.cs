using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 店铺转链API请求参数
    /// </summary>
    public class ShopConvertCodeRequest: IHaoDanKuPostRequest<ShopConvertCodeResponse>
    {
        private HaoDanKuObject _bodyModel;

        public HaoDanKuObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/shopConvert_code";
        }

        public void SetBodyModel(HaoDanKuObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
