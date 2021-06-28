using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public interface IHaoDanKuGetRequest<T> where T:HaoDanKuResponse
    {
        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns>接口地址</returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取URL参数模型
        /// </summary>
        /// <returns>URL参数模型</returns>
        HaoDanKuObject GetQueryModel();

        /// <summary>
        /// 设置URL参数模型
        /// </summary>
        /// <param name="queryModel">URL参数模型</param>
        void SetQueryModel(HaoDanKuObject queryModel);

        /// <summary>
        /// 获取是否需要URL参数
        /// </summary>
        /// <returns>是否需要URL参数</returns>
        bool GetNeedQueryModel()
        {
            return true;
        }
    }
}
