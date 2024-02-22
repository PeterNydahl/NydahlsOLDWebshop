using Microsoft.EntityFrameworkCore;
using NydahlsWebshop1000.Data;
using NydahlsWebshop1000.Models;

namespace NydahlsWebshop1000.Repository;
public class ProductRepository : DbContext
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddProduct(Product addedProduct)
    {
        _context.Products.Add(addedProduct);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Product>> GetProducts() => await _context.Products.ToListAsync();

    public async Task<Product?> GetProduct(int id) =>
        await _context.Products.SingleOrDefaultAsync(p => p.Id == id);
}
