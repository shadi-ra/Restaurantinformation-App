using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restaurant.Core.ApplicationService.Dtos.City
{
    public class CityUpdateInputDto
    {
        [Display(Name = "Please Enter The Id")]
        [Required(ErrorMessage = "Please Enter The {0}")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
