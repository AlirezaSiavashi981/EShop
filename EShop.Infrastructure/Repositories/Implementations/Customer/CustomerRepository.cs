using EShop.Domain.Entities;
using EShop.Infrastructure.DbContextApp;
namespace EShop.Infrastructure.Repositories.Implementations;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(EShopDbContext context) : base(context) { }
}
