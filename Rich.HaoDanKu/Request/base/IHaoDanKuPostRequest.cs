using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public interface IHaoDanKuPostRequest<T> where T : HaoDanKuResponse
    {
        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取JSON参数模型
        /// </summary>
        /// <returns></returns>
        HaoDanKuObject GetBodyModel();

        /// <summary>
        /// 设置JSON参数模型
        /// </summary>
        /// <param name="model"></param>
        void SetBodyModel(HaoDanKuObject model);

    }
}
