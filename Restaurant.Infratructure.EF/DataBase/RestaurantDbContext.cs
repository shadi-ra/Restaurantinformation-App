using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Entities.Models;

namespace Restaurant.Infratructure.EF.DataBase
{
   public class RestaurantDbContext :DbContext
    {
        public RestaurantDbContext()
        {

        }
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options):base(options)
        {

        }
        public DbSet<Core.Entities.Models.Restaurant> Restaurants { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Core.Entities.Models.Restaurant>(x => x.ToTable("Restaurant"));
            builder.Entity<User>(x => x.ToTable("User"));
            builder.Entity<UserLogin>(x => x.ToTable("UserLogin"));
            builder.Entity<City>(x => x.ToTable("City"));
            builder.Entity<Food>(x => x.ToTable("Food"));
            builder.Entity<Comment>(x => x.ToTable("Comment"));
            builder.Entity<Menu>(x => x.ToTable("Menu"));
        }
    }
}
