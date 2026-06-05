namespace IntegrationGateway.Services;

public class InventoryClient
{
    private readonly HttpClient _httpClient;

    public InventoryClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task AddStockAsync(object request)
    {
        await _httpClient.PostAsJsonAsync(
            "/api/stocks/add",
            request);
    }
}