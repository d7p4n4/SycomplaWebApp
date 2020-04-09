﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class User
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string FBToken { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OAuthToken { get; set; }
        public string Language { get; set; }
    }
}
