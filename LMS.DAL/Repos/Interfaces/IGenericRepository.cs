using System.Linq.Expressions;

namespace LMS.DAL;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetWhereIncludeAsync(Expression<Func<T, bool>> predicate, params string[] includes);
    Task<T?> GetByIdAsync(object id);
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    Task DeleteAsync(T entity, string userId);

    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

}
