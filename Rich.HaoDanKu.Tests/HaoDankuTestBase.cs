using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Rich.HaoDanKu.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu.Tests
{
    public class HaoDankuTestBase
    {
        public readonly IHaoDanKuClient _client;

        public HaoDanKuOptions options { get; set; } = new HaoDanKuOptions();

        public static IConfiguration Configuration { get; set; }

        public HaoDankuTestBase()
        {
            IServiceCollection services = new ServiceCollection();
            IServiceProvider provider = services.BuildServiceProvider();

            services.AddHaoDanKu();

            Configuration = new ConfigurationBuilder()
                 .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
                .Build();

            Configuration.GetSection("HaoDanKuOptions").Bind(options);

        }

    }
}
