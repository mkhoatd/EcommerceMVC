using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerceMVC.Models;
using EcommerceMVC.Services;

namespace EcommerceMVC.Controllers;

public class HomeController(IProductService productService) : Controller
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
}
