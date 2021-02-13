using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Infratructure.EF.Repasitories;

namespace RestaurantWebApi.Extentions
{
    public static class DependencyExtensions
    {
        public static void AddDependency(this IServiceCollection service)
        {
            AddRepositories(service);
            AddService(service);
        }

        public static void AddService(IServiceCollection service)
        {
      

        }

        public static void AddRepositories(IServiceCollection service)
        {
          
        }
    }
}
