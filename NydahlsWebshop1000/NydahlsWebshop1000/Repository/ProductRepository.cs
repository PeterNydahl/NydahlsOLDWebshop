using Microsoft.EntityFrameworkCore;
using NydahlsWebshop1000.Data;
using NydahlsWebshop1000.Models;
using System.Runtime.CompilerServices;

namespace NydahlsWebshop1000.Repository;
public class ProductRepository : DbContext
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task UpdateQuantity(int productId)
    {
        Product? product = await _context.Products.SingleOrDefaultAsync(p => p.Id == productId);

        if (product != null && product.Quantity > 0)
        {
            product.Quantity--;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task AddProduct(Product addedProduct)
    {
        _context.Products.Add(addedProduct);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Product>> GetProducts() => await _context.Products.ToListAsync();

    public async Task<Product?> GetProduct(int id) =>
        await _context.Products.SingleOrDefaultAsync(p => p.Id == id);

    public async Task SeedingDatabase()
    {
        if (!_context.Products.Any())
        {
            Product nyProdukt1 = new Product
            {
                Title = "Hippo-bird",
                Description = "A mix between a hippo and a bird.",
                ImgUrl = "/images/HippoBird.jpg",
                ImgUrlSoldOut = "/images/HippoBirdSoldOut.jpg",
                Price = 5000,
                Quantity = 5
            };

            Product nyProdukt2 = new Product
            {
                Title = "Hippo-dog",
                Description = "A mix between a hippo and a dog.",
                ImgUrl = "/images/HippoDog.jpg",
                ImgUrlSoldOut = "/images/HippoDogSoldOut.jpg",
                Price = 3500,
                Quantity = 0
            };

            Product nyProdukt3 = new Product
            {
                Title = "Hippo-snake",
                Description = "A mix between a hippo and a snake.",
                ImgUrl = "/images/HippoSnake.jpg",
                ImgUrlSoldOut = "/images/HippoSnakeSoldOut.jpg",
                Price = 2500,
                Quantity = 5
            };
            Product nyProdukt4 = new Product
            {
                Title = "Hippo-Tiger",
                Description = "A mix between a hippo and a tiger.",
                ImgUrl = "/images/HippoTiger.jpg",
                ImgUrlSoldOut = "/images/HippoTigerSoldOut.jpg",
                Price = 9000,
                Quantity = 5
            };
            Product nyProdukt5 = new Product
            {
                Title = "Hippo-Turtle",
                Description = "A mix between a hippo and a Turtle.",
                ImgUrl = "/images/HippoTurtle.jpg",
                ImgUrlSoldOut = "/images/HippoTurtleSoldOut.jpg",
                Price = 500,
                Quantity = 5
            };

            await AddProduct(nyProdukt1);
            await AddProduct(nyProdukt2);
            await AddProduct(nyProdukt3);
            await AddProduct(nyProdukt4);
            await AddProduct(nyProdukt5);
        }
    }
}
