﻿
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
