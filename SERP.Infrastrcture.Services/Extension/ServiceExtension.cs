using Microsoft.Extensions.DependencyInjection;
using SERP.Core.Services.Authenticate;
using SERP.Core.Services.GenericService;
using SERP.Core.Services.OnlineTest;
using SERP.Core.Services.Report;
using SERP.Infrastrcture.Services.Authenticate;
using SERP.Infrastrcture.Services.GenericServiceImplementation;
using SERP.Infrastrcture.Services.OnlineTest;
using SERP.Infrastrcture.Services.Report;

namespace SERP.Infrastrcture.Services.Extension
{
    public static class ServiceExtension
    {
        public static void AddService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            serviceCollection.AddScoped<IBasicReportService, BasicReportService>();
            serviceCollection.AddScoped<IAuthenticateService, AuthenticateService>();
            serviceCollection.AddScoped<IOnlineTestService, OnlineTestService>();
        }
    }
}
