﻿using blogsoftware.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace blogsoftware.Context
{
    public class AppContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
    }
}