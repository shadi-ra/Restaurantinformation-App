using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
    public class UserLogin : IHasIdentity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string ExpireDate { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
