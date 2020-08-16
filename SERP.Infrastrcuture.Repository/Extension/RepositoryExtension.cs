using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SERP.Core.Repository.GenericRepository;
using SERP.Infrastrcuture.Repository.GenericRepositoryImplementation;
using SERP.Core.Repository.Report;
using SERP.Infrastrcuture.Repository.Report;
using SERP.Core.Repository.Authenticate;
using SERP.Infrastrcuture.Repository.Authenticate;
using SERP.Core.Repository.OnlineTest;
using SERP.Infrastrcuture.Repository.OnlineTest;

namespace SERP.Infrastrcuture.Repository.Extension
{
    public static class RepositoryExtension
    {
        
        public static void AddRepository(this IServiceCollection serviceCollection,IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IGenericRepository<,>),typeof(GenericRepository<,>));
            serviceCollection.AddScoped<IBasicReportRepoSitory, BasicReportRepository>();
            serviceCollection.AddScoped<IAuthenticateRepository, AuthenticateRepository>();
            serviceCollection.AddScoped<IOnlineTestRepository, OnlineTestRepository>();
        }
    }
}
