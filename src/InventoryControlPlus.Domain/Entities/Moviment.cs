using InventoryControlPlus.Domain.Enum;

public class Moviment
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime MovementDate { get; set; }
    public MovementTypeEnum Type { get; set; }
}