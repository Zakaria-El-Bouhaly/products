using Project.Models;

namespace Project.Data
{
    public class DataSource
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "MacBook Pro", Price = 2000 , CategoryId = 2},
            new Product { Id = 3, Name = "Samsung Galaxy S24", Price = 900 , CategoryId = 2},
            new Product { Id = 4, Name = "Nvidia RTX 4090", Price = 1500 , CategoryId = 2},
            new Product { Id = 5, Name = "Nike Air Max", Price = 120 , CategoryId = 3},
            new Product { Id = 6, Name = "Adidas Superstar", Price = 100 , CategoryId = 3},
            new Product { Id = 7, Name = "Ray-Ban Aviator", Price = 150 , CategoryId = 4},

        };

        public static List<Category> Categories = new List<Category>
        {
            new Category { Id = 1, Name = "Books" },
            new Category { Id = 2, Name = "Electronics" },
            new Category { Id = 3, Name = "Clothing" },
            new Category { Id = 4, Name = "Accessories" }
        };
    }
}
