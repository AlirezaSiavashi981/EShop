namespace EShop.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }


    public virtual Customer Buyer { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}
