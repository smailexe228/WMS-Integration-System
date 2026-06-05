using AutoMapper;

namespace IntegrationGateway.DTOs;

public class SupplyToStockProfile : Profile
{
    public SupplyToStockProfile()
    {
        CreateMap<SupplyDto, StockDto>();
    }
}