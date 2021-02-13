using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
   public class User :IHasIdentity
    {
        public int Id { get; set; }
    }
}
