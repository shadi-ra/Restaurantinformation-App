using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.ApplicationService.ApplicationServices;
using Restaurant.Core.ApplicationService.ApplicationServices.City;
using Restaurant.Core.ApplicationService.ApplicationServices.Comment;
using Restaurant.Core.ApplicationService.ApplicationServices.Food;
using Restaurant.Core.ApplicationService.ApplicationServices.Menu;
using Restaurant.Core.ApplicationService.ApplicationServices.User;
using Restaurant.Core.ApplicationService.ApplicationServices.UserLogin;
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
            service.AddTransient<ICityService, CityService>();
            service.AddTransient<IRestaurantService, RestaurantService>();
            service.AddTransient<IFoodService, FoodService>();
            service.AddTransient<IMenuService, MenuService>();
            service.AddTransient<IUserService, UserService>();
            service.AddTransient<ICommentService, CommentService>();        
            service.AddTransient<IUserLoginService, UserLoginService>();

        }

        public static void AddRepositories(IServiceCollection service)
        {
          
        }
    }
}
