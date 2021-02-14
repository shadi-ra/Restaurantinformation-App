using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
    public class Food:IHasIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        public string RawMaterial { get; set; }
        public Menu Menue { get; set; }
        public int MenueId { get; set; }
    }
}
