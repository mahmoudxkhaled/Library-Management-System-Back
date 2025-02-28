using Microsoft.EntityFrameworkCore;

namespace LMS.DAL;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    #region Fields & Properties

    private readonly LMSDbContext _context;

    #endregion

    #region Constructors

    public GenericRepository(LMSDbContext context)
    {
        _context = context;
    }

    #endregion

    #region Functions

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>()
                             .AsNoTracking()
                             .ToListAsync();
    }
    public async Task<T?> GetByIdAsync(object id)
    {
        return await _context.Set<T>()
                             .FindAsync(id);
    }
    public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);
    public void Update(T entity) => _context.Set<T>().Update(entity);
    public async Task AddRangeAsync(IEnumerable<T> entities) => await _context.Set<T>().AddRangeAsync(entities);

    public async Task DeleteAsync(T entity, string userId)
    {
        var type = typeof(T);
        var isDeletedProp = type.GetProperty("IsDeleted");
        var deletedTimeProp = type.GetProperty("DeletedTime");
        var deletedUserIdProp = type.GetProperty("DeletedUserId");

        if (isDeletedProp != null)
            isDeletedProp.SetValue(entity, true);

        if (deletedTimeProp != null)
            deletedTimeProp.SetValue(entity, DateTime.Now);

        if (userId == null) { userId = "UnKnown"; };
        if (deletedUserIdProp != null)
            deletedUserIdProp.SetValue(entity, userId);

        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
    #endregion
}