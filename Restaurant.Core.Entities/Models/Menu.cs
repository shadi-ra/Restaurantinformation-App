﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
   public class Menu:IHasIdentity
    {
        public int Id { get; set; }
        public List<Food> Foods { get; set; }
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
