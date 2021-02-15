using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.Restaurant;

namespace Restaurant.Core.ApplicationService.Dtos.Food
{
   public class FoodOutPutDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        public string RawMaterial { get; set; }
        public int MenueId { get; set; }
        public List<RestaurantInputDtos> Restaurants { get; set; }
    }
}
