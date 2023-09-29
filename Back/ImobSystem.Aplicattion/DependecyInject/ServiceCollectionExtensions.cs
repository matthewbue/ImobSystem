using ImobSystem.Aplicattion.Service;
using ImobSystem.Infra.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Aplicattion.DependecyInject
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
           
            
           
            return services;
        }
    }
}
