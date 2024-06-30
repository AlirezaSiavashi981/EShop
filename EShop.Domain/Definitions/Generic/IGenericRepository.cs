namespace EShop.Domain.Definitions.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAllAsync(CancellationToken ct);
        T FindAsync(int id, CancellationToken ct);
        void Add(T entity, CancellationToken ct);
        void Update(T entity, CancellationToken ct);
        void Delete(T entity, CancellationToken ct);
    }
}
