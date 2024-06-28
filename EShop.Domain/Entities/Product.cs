namespace EShop.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public short InventoryCount { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public bool IsDisabled { get; set; }


    public virtual Order Order { get; set; }
}
