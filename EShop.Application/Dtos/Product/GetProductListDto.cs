namespace EShop.Application.Dtos.Product;

public class GetProductListDto
{
    public int ProductId { get; set; }
    public required string Name { get; set; }
    public short InventoryCount { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
}
