using Microsoft.EntityFrameworkCore;
using Product.API.Entities;
using System.Reflection;

namespace Product.API.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>options):base (options) { }    
        public DbSet<Product.API.Entities.Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Product.API.Entities.Product>().HasData(new Entities.Product
            {
                Id=1,
                Title="",
                Price=13500,
                Description=,
                ImageUrl=,
                CategoryId=1,
                
            });
            modelBuilder.Entity<Product.API.Entities.Product>().HasData(
                new Entities.Product)
        }
    }

}
