using EcommerceMVC.Data;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Services;

public class ProductService(ApplicationDbContext context): IProductService
{
    public async Task<List<Product>?> GetAllProductsAsync()
    {
        return await context.Products.ToListAsync();
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await context.Products.FirstOrDefaultAsync(p => p.Id == id);
    }
}