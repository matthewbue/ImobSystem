using ImobSystem.Infra.Interface;
using ImobSystem.Infra.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Infra.DependecyInject
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastruture(this IServiceCollection services)
        {
          

           
            

            return services;
        }

    }
}
