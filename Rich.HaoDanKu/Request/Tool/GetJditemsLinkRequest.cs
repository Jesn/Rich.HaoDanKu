using Rich.HaoDanKu.Response;

namespace Rich.HaoDanKu.Request
{
    /// <summary>
    /// 京东商品转链请求参数
    /// </summary>
    public class GetJditemsLinkRequest: IHaoDanKuPostRequest<GetJditemsLinkResponse>
    {
        private HaoDanKuObject _bodyModel;

        public HaoDanKuObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "http://v2.api.haodanku.com/get_jditems_link";
        }

        public void SetBodyModel(HaoDanKuObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
