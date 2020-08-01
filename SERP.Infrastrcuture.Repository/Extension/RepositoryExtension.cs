using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using SERP.Core.Repository.GenericRepository;
using SERP.Infrastrcuture.Repository.GenericRepositoryImplementation;

namespace SERP.Infrastrcuture.Repository.Extension
{
    public static class RepositoryExtension
    {
        
        public static void AddRepository(this IServiceCollection serviceCollection,IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IGenericRepository<,>),typeof(GenericRepository<,>));
        }
    }
}
