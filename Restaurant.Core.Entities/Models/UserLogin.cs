﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core.Entities.Models
{
    public class UserLogin : IHasIdentity
    {
        public int Id { get; set; }
    }
}
