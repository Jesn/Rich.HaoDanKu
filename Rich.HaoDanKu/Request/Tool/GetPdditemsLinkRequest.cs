using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 拼多多商品转链请求参数
    /// </summary>
    public class GetPdditemsLinkRequest: IHaoDanKuPostRequest<GetPdditemsLinkResponse>
    {
        private HaoDanKuObject _bodyModel;

        public HaoDanKuObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/get_pdditems_link";
        }

        public void SetBodyModel(HaoDanKuObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
