using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private static readonly List<Product> Products = [];

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Products);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        Products.Add(product);

        return Ok(product);
    }
}