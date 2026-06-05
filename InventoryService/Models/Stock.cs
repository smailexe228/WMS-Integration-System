namespace InventoryService.Models;

public class Stock
{
    public Guid ProductId { get; set; }

    public int Quantity { get; set; }
}