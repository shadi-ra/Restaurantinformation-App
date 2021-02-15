using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
   public class Restaurant:IHasIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Food> Foods { get; set; }
    }
}
