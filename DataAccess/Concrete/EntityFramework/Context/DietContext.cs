using Entities.Concrete;
using Entities.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class DietContext:DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=.;Initial Catalog=KaloriTakip;Integrated Security=True"); 
                
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                new MealConfig().Configure(modelBuilder.Entity<Meal>());
                new MealDetailConfig().Configure(modelBuilder.Entity<MealDetail>());
                new MealTypeConfig().Configure(modelBuilder.Entity<MealType>());
                new ProductConfig().Configure(modelBuilder.Entity<Product>());
                new ProductTypeConfig().Configure(modelBuilder.Entity<ProductType>());
                new UserConfig().Configure(modelBuilder.Entity<User>());
                //modelBuilder.ApplyConfiguration
            }
            public DbSet<Meal> Meal { get; set; }
            public DbSet<MealDetail> MealDetail { get; set; }
            public DbSet<MealType> MealType { get; set; }
            public DbSet<Product> Product { get; set; }
            public DbSet<ProductType> ProductType { get; set; }
            public DbSet<User> User { get; set; }
        }


    
}
