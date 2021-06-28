﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddHaoDanKu(this IServiceCollection services)
        {
            services.AddHttpClient(HaoDanKuClient.clientName);
            services.AddSingleton<IHaoDanKuClient, HaoDanKuClient>();
        }
    }
}
