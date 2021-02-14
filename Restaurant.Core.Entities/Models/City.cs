using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
   public class City :IHasIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}
