using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
    public class Comment : IHasIdentity
    {
        public int Id { get; set; }
        public string comment { get; set; }
        public Restaurant Resturaunt { get; set; }
        public int RestaurantId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
    }
}
