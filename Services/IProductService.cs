using EcommerceMVC.Models;

namespace EcommerceMVC.Services;

public interface IProductService
{
    public Task<List<Product>?> GetAllProductsAsync();
    public Task<Product?> GetProductByIdAsync(int id);
}