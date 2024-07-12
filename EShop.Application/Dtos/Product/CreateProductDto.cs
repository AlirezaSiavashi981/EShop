namespace EShop.Application.Dtos.Product;

/// <summary>
/// ایحاد محسول
/// </summary>
public class CreateProductDto
{
    public required string Name { get; set; }
    public short InventoryCount { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
}
