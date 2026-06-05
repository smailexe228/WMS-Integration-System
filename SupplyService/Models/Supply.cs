namespace SupplyService.Models;

public class Supply
{
    public Guid ProductId { get; set; } = string.Empty;

    public int Quantity { get; set; } = string.Empty;
}