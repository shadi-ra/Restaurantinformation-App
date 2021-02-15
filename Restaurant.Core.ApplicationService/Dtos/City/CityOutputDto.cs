using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Core.ApplicationService.Dtos.Restaurant;

namespace Restaurant.Core.ApplicationService.Dtos.City
{
   public class CityOutputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RestaurantInputDtos> Restaurants { get; set; }
    }
}
