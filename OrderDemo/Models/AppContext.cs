using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
using System.Data.Entity;

namespace OrderDemo.Models
{
    public class MyAppContext : DbContext
    {
        public MyAppContext() : base("MyConnection")
        {

        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}