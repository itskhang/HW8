﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW8.Models
{
    public class AnimalContext : DbContext
    {
        public DbSet <Animal> Animals { get; set; }
    }
}