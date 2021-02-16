using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Core.ApplicationService.Dtos.Restaurant;

namespace Restaurant.Core.ApplicationService.Dtos.Comment
{
    public class CommentOutputDto
    {
        public int Id { get; set; }
        public string comment { get; set; }
        public int Rate { get; set; }
        public Entities.Models.User User { get; set; }
        public int UserId { get; set; }
        public RestaurantInputDtos Resturaunt { get; set; }
        public int RestaurantId { get; set; }
    }
}
