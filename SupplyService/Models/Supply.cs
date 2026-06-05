namespace SupplyService.Models;

public class Supply
{
    public Guid ProductId { get; set; } = Guid.Empty;

    public int Quantity { get; set; } = 0;
}