﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SupermarketContext : DbContext
    {
        public  SupermarketContext(DbContextOptions options) : base(options)
            {
            }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        

    }
}
