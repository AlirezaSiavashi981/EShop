using EShop.Domain.Definitions.Generic;
using EShop.Infrastructure.DbContextApp;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Repositories.Implementations.Generic;

public class GenericRepository<T>(EShopDbContext context, DbSet<T> dbSet) : IGenericRepository<T> where T : class
{
    public void Add(T entity, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public T FindAsync(int id, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAllAsync(CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}
