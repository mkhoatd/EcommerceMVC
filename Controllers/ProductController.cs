using EcommerceMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers;

public class ProductController(IProductService productService) : Controller
{
    public async Task<IActionResult> Index()
    {
        var products = await productService.GetAllProductsAsync();
        if (products == null)
        {
            return NotFound();
        }
        return View(products);
    }

    public async Task<IActionResult> Details(int id)
    {
        var product = await productService.GetProductByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }
}