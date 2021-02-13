using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities
{
   public interface IHasIdentity
    {
        public int Id { get; set; }
    }
}
