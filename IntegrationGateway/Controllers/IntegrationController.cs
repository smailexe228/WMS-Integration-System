using Microsoft.AspNetCore.Mvc;
using IntegrationGateway.Services;

namespace IntegrationGateway.Controllers;

[ApiController]
[Route("api/integration")]
public class IntegrationController : ControllerBase
{
    private readonly InventoryClient _client;

    public IntegrationController(
        InventoryClient client)
    {
        _client = client;
    }

    [HttpPost("supplies")]
    public async Task<IActionResult> Create(
        object request)
    {
        await _client.AddStockAsync(request);

        return Ok();
    }
}