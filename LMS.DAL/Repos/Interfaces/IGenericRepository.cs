namespace LMS.DAL;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> GetWhereAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetWhereIncludeAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params string[] includes);
    Task<T?> GetByIdAsync(object id);
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    Task DeleteAsync(T entity, string userId);

}
