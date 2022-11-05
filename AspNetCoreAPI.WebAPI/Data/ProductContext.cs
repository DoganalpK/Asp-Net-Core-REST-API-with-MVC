using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetCoreAPI.WebAPI.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new(){Id=1,Name="Electronic"},
                new(){Id=2,Name="Clothes"}
            });

            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                 new(){Id = 1,Name="Computer",CreatedDate = DateTime.Now.AddDays(-5),Price=15000,Stock=150,CategoryId=1},
                 new(){Id = 2,Name="Phone",CreatedDate = DateTime.Now.AddDays(-20),Price=10000,Stock=100,CategoryId=1},
                 new(){Id = 3,Name="Keyboard",CreatedDate = DateTime.Now.AddDays(-50),Price=1000,Stock=500,CategoryId=1},
            });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
