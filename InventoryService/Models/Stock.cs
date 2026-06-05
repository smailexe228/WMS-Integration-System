namespace InventoryService.Models;

public class Stock
{
    public Guid ProductId { get; set; } = Guid.Empty;

    public int Quantity { get; set; } = 0;
}