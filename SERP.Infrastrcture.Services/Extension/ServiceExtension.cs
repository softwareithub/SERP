using Microsoft.Extensions.DependencyInjection;
using SERP.Core.Services.GenericService;
using SERP.Infrastrcture.Services.GenericServiceImplementation;

namespace SERP.Infrastrcture.Services.Extension
{
    public static class ServiceExtension
    {
        public static void AddService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
        }
    }
}
