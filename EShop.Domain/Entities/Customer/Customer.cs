namespace EShop.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public short? Age { get; set; }
    public required string NationalCode { get; set; }
    public required string PhonNumber { get; set; }
    public required string Address { get; set; }
    public required string PostalCode { get; set; }
    public string? Email { get; set; }
    public bool IsDisabled { get; set; }


    public virtual ICollection<Order> Orders { get; set; }
}
