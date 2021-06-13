using System.Collections.Generic;
using System.Reflection;
using AutoMapper.Extensions.ExpressionMapping;
using HomeFinance.Services.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HomeFinance.Api.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddAutoMapperSingleton(this IServiceCollection services)
        {
            services.AddAutoMapper(
                cfg => cfg.AddExpressionMapping(),
                new List<Assembly> { Assembly.GetAssembly(typeof(IReportManager)), Assembly.GetExecutingAssembly() },
                ServiceLifetime.Singleton);
        }
    }
}
