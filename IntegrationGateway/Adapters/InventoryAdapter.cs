using IntegrationGateway.DTOs;

namespace IntegrationGateway.Adapters;

public class InventoryAdapter
{
    private readonly HttpClient _httpClient;

    public InventoryAdapter(
        HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task AddStockAsync(
        StockDto stock)
    {
        await _httpClient.PostAsJsonAsync(
            "/api/stocks/add",
            stock);
    }
}