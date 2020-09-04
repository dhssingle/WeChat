

using System;
using Microsoft.Extensions.Http.Logging;
using WeChat.MiniProgram;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MiniProgramServiceCollectionExtensions
    {
        public static IServiceCollection AddMiniProgram(this IServiceCollection services)
        {
            services.AddHttpClient<MiniProgramClient>(c =>
            {
                c.BaseAddress = new Uri("https://api.weixin.qq.com/");
            })
            //.AddHttpMessageHandler<LoggingHttpMessageHandler>()
            ;
            return services;
        }
    }
}