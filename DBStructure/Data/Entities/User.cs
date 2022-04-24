﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBStructure.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
