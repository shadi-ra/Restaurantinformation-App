using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.ApplicationService.Dtos.Restaurant
{
   public class RestaurantInputDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public int CityId { get; set; }
        
    }
}
