﻿using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public class NZPureJadeShopDbContext:DbContext
    {
        

        public NZPureJadeShopDbContext(DbContextOptions<NZPureJadeShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Jade> Jades { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
