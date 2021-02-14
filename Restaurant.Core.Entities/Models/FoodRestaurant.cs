using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
  public class FoodRestaurant
    {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public Food Food { get; set; }
        public int FoodId { get; set; }
        public int RestaurantId { get; set; }
    }
}
