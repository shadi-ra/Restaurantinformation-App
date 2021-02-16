using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Restaurant.Core.Entities.Models;

namespace Restaurant.Core.ApplicationService.Dtos.Comment
{
    public class CommentInsertInputDto
    {
        [Required(ErrorMessage = "لطفا متن کامنت را وارد کنید")]
        public string comment { get; set; }

        [Required(ErrorMessage = "لطفا ای دی رستوران را وارد کنید")]
        public int RestaurantId { get; set; }

        [Required(ErrorMessage = "لطفا ای دی یوزر را وارد کنید")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "لطفاامتیاز دهید")]
        public int Rate { get; set; }
    }
}
