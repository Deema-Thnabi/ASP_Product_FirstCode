using EF_create_product.Data;
using EF_create_product.Models;

namespace EF_create_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            // var products = new List<Product>(){}
            dbContext.AddRange(new List<Product>()
         {
        new Product()
        {
            Name = "Laptop",
            Description = "High performance laptop.",
            Price = 999.99m
        },
        new Product()
        {
            Name = "Smartphone",
            Description = "Latest model smartphone.",
            Price = 799.99m
        },
        new Product()
        {
            Name = "Tablet",
            Description = "Portable tablet with long battery life.",
            Price = 499.99m
        },
        new Product()
        {
            Name = "Headphones",
            Description = "Noise-cancelling over-ear headphones.",
            Price = 199.99m
        },
        new Product()
        {
            Name = "Smartwatch",
            Description = "Fitness tracking smartwatch.",
            Price = 149.99m
        }
    });

            dbContext.SaveChanges();
        }
    }
}
