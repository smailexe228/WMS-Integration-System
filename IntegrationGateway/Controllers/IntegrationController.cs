using IntegrationGateway.DTOs;
using IntegrationGateway.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationGateway.Controllers;

[ApiController]
[Route("api/integration")]
public class IntegrationController : ControllerBase
{
    private readonly SupplyIntegrationService _service;

    public IntegrationController(
        SupplyIntegrationService service)
    {
        _service = service;
    }

    [HttpPost("supply")]
    public async Task<IActionResult> Supply(
        SupplyDto dto)
    {
        await _service.ProcessSupplyAsync(dto);

        return Ok("Stock updated");
    }
}