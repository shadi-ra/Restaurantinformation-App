using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
   public class User :IHasIdentity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public List<UserLogin> UserLogins { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
