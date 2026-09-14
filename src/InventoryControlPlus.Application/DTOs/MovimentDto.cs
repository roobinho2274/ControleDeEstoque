using InventoryControlPlus.Domain.Enum;

public class MovimentDto
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public DateTime MovementDate { get; set; }
    public MovementTypeEnum Type { get; set; }
}

public class CreateMovimentDto
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime MovementDate { get; set; }
    public MovementTypeEnum Type { get; set; }
}