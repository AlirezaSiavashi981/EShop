namespace EShop.Application.Dtos.Product;

public class EditProductDto
{
    public required string Name { get; set; }
    public short InventoryCount { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
}
