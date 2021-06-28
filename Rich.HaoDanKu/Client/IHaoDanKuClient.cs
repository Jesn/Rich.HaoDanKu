using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public interface IHaoDanKuClient
    {
        Task<T> ExecuteAsync<T>(IHaoDanKuGetRequest<T> request, HaoDanKuOptions options) where T : HaoDanKuResponse;

        Task<T> ExecuteAsync<T>(IHaoDanKuPostRequest<T> request, HaoDanKuOptions options) where T : HaoDanKuResponse;
    }
}
