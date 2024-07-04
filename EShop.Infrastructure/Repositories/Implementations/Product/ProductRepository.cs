using EShop.Domain.Entities;
using EShop.Infrastructure.DbContextApp;

namespace EShop.Infrastructure.Repositories.Implementations;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(EShopDbContext context) : base(context)
    {
    }
}
