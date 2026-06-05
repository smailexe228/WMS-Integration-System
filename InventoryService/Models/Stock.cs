namespace InventoryService.Models;

public class Stock
{
    public Guid ProductId { get; set; } = string.Empty;

    public int Quantity { get; set; } = string.Empty;
}