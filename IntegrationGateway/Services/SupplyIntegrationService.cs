using AutoMapper;
using IntegrationGateway.Adapters;
using IntegrationGateway.DTOs;

namespace IntegrationGateway.Services;

public class SupplyIntegrationService
{
    private readonly InventoryAdapter _inventory;
    private readonly IMapper _mapper;

    public SupplyIntegrationService(
        InventoryAdapter inventory,
        IMapper mapper)
    {
        _inventory = inventory;
        _mapper = mapper;
    }

    public async Task ProcessSupplyAsync(
        SupplyDto supply)
    {
        var stock =
            _mapper.Map<StockDto>(supply);

        await _inventory.AddStockAsync(stock);
    }
}