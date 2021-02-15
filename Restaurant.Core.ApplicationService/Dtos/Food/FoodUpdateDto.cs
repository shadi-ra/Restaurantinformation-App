using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restaurant.Core.ApplicationService.Dtos.Food
{
    public class FoodUpdateDto
    {
        [Required(ErrorMessage ="لطفا ای دی را وارد کنید")]
        public int Id { get; set; }

        [Display(Name = "نام شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }

        [Display(Name = "نام غذا")]
        [Required(ErrorMessage = "لطفا قیمت را وارد کنید")]
        public int Fee { get; set; }
        public string RawMaterial { get; set; }

        [Display(Name = "ای دی منو")]
        [Required(ErrorMessage = "لطفا ای دی منو را وارد کنید")]
        public int MenueId { get; set; }
    }
}
