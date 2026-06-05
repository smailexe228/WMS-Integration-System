using Microsoft.AspNetCore.Mvc;
using SupplyService.Models;

namespace SupplyService.Controllers;

[ApiController]
[Route("api/supplies")]
public class SupplyController : ControllerBase
{
    private static readonly List<Supply> Supplies = [];

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Supplies);
    }

    [HttpPost]
    public IActionResult Create(Supply supply)
    {
        Supplies.Add(supply);

        return Ok(supply);
    }
}