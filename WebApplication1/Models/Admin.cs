﻿using System;
using System.Collections.Generic;

namespace DEMO.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
