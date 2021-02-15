using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.ApplicationService.ApplicationServices;
using Restaurant.Core.ApplicationService.ApplicationServices.City;
using Restaurant.Core.ApplicationService.ApplicationServices.Comment;
using Restaurant.Core.ApplicationService.ApplicationServices.Food;
using Restaurant.Core.ApplicationService.ApplicationServices.FoodRestaurant;
using Restaurant.Core.ApplicationService.ApplicationServices.Menu;
using Restaurant.Core.ApplicationService.ApplicationServices.User;
using Restaurant.Core.ApplicationService.ApplicationServices.UserLogin;
using Restaurant.Core.ApplicationService.IRepository;
using Restaurant.Core.Entities.Models;
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
            service.AddTransient<IFoodRestaurantService, FoodRestaurantService>();
        }

        public static void AddRepositories(IServiceCollection service)
        {
            service.AddTransient<IRepository<City>, EfRepository<City>>();
            service.AddTransient<IRepository<Restaurant.Core.Entities.Models.Restaurant>, EfRepository<Restaurant.Core.Entities.Models.Restaurant>> ();
            service.AddTransient<IRepository<Food>, EfRepository<Food>>();
            service.AddTransient<IRepository<Comment>, EfRepository<Comment>>();
            service.AddTransient<IRepository<Menu>, EfRepository<Menu>>();
            service.AddTransient<IRepository<FoodRestaurant>, EfRepository<FoodRestaurant>>();
            service.AddTransient<IRepository<User>, EfRepository<User>>();
            service.AddTransient<IRepository<UserLogin>, EfRepository<UserLogin>>();
           
        }
    }
}
