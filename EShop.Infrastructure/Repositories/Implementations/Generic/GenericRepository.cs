using EShop.Domain.Entities;
using EShop.Infrastructure.DbContextApp;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Repositories.Implementations.Generic;

public class GenericRepository<T>(EShopDbContext context) : IGenericRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public void Add(T entity)
    {
       _dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public Task<T> FindAsync(int id, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken ct)
    {
        var entities = await _dbSet.ToListAsync(ct);
        return entities;
    }

    public async Task<int> SaveChagesAsync()
    {
        return await context.SaveChangesAsync();
    }

    public async void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
