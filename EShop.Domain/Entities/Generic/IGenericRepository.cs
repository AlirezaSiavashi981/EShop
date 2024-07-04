namespace EShop.Domain.Entities;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken ct);
    Task<T> FindAsync(int id, CancellationToken ct);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<int> SaveChagesAsync();
}
