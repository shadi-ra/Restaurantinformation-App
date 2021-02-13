using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
    public class Food:IHasIdentity
    {
        public int Id { get; set; }
    }
}
