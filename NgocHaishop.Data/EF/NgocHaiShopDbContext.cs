
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NgocHaishop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgocHaishop.Data.EF
{
   public class NgocHaiShopDbContext : DbContext
    {
        public NgocHaiShopDbContext( DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
