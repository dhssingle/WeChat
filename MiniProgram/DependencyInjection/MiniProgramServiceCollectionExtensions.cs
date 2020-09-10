

using System;
using Microsoft.Extensions.Http.Logging;
using WeChat.MiniProgram;
using WeChat.MiniProgram.AnalysisApi;
using WeChat.MiniProgram.AuthApi;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MiniProgramServiceCollectionExtensions
    {
        public static IServiceCollection AddMiniProgram(this IServiceCollection services)
        {
            services.AddHttpClient<MiniProgramClient>(c =>
            {
                c.BaseAddress = new Uri("https://api.weixin.qq.com/");
            });
            services.AddTransient<IAuth, Auth>();
            services.AddTransient<IAnalysis, Analysis>();
            return services;
        }
    }
}