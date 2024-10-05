namespace YllaPVP.Repositories.Contracts;

public interface IBaseRepository<T>
{
    Task<T?> GetByGuidAsync(Guid guid);
    T? GetByGuid(int id);
    Task<IEnumerable<T>> GetAll();
    void Create(T entity);
    bool Update(T entity);
    void Delete(T entity);
    void DeleteByGuid(Guid guid);
    Task<int> SaveChangesAsync();
}