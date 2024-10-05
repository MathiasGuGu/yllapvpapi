using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using YllaPVP.Data;
using YllaPVP.Repositories.Contracts;

namespace YllaPVP.Repositories;

public abstract class BaseRepository<T>(DataContext context) : IBaseRepository<T>
    where T : class
{
    protected DataContext Context { get; init; } = context;

    public async Task<T?> GetByGuidAsync(Guid guid)
    {
        return await Context.Set<T>().FindAsync(guid);
    }

    public T? GetByGuid(int id)
    {
        return Context.Set<T>().Find(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        IQueryable<T> T = Context.Set<T>().AsNoTracking();
        return await T.ToListAsync();
    }

    public void Create(T entity)
    {
        Context.Set<T>().Add(entity);
    }

    public bool Update(T entity)
    {
        return Context.Set<T>().Update(entity).State == EntityState.Modified;
    }

    public void Delete(T entity)
    {
        Context.Set<T>().Remove(entity);
    }

    public void DeleteByGuid(Guid guid)
    {
        var entity = GetByGuidAsync(guid).Result ?? throw new KeyNotFoundException($"Entity not found: {guid}");
        Delete(entity);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await Context.SaveChangesAsync();
    }
}