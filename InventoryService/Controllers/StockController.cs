using Microsoft.AspNetCore.Mvc;
using InventoryService.Models;

namespace InventoryService.Controllers;

[ApiController]
[Route("api/stocks")]
public class StockController : ControllerBase
{
    private static readonly List<Stock> Stocks = [];

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Stocks);
    }

    [HttpPost("add")]
    public IActionResult Add(Stock stock)
    {
        Stocks.Add(stock);

        return Ok(stock);
    }
}