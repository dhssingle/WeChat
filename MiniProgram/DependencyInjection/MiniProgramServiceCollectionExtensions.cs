using Microsoft.Extensions.Configuration;
using System;
using WeChat.MiniProgram;
using WeChat.MiniProgram.AnalysisApi;
using WeChat.MiniProgram.AuthApi;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MiniProgramServiceCollectionExtensions
    {
        public static IServiceCollection AddMiniProgram(this IServiceCollection services, Action<MiniProgramOptions> configureOptions)
        {
            GetServices(services);
            services.Configure(configureOptions);
            return services;
        }
        public static IServiceCollection AddMiniProgram(this IServiceCollection services, IConfiguration configuration)
        {
            GetServices(services);
            services.Configure<MiniProgramOptions>(configuration);
            return services;
        }

        private static void GetServices(IServiceCollection services)
        {
            services.AddHttpClient<MiniProgramClient>(c =>
            {
                c.BaseAddress = new Uri("https://api.weixin.qq.com/");
            });
            services.AddTransient<IAuth, Auth>();
            services.AddTransient<IAnalysis, Analysis>();
        }

    }
}