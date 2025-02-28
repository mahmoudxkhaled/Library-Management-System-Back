using Microsoft.EntityFrameworkCore;

namespace LMS.DAL;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    #region Fileds & Properities

    private readonly LMSDbContext _context;

    #endregion

    #region Construcors

    public CategoryRepository(LMSDbContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Functions

    public async Task<IEnumerable<Category>> GetAllCategoriesWithBooks()
    {
        return await _context.Category
                                .Include(x => x.Books)
                                .ToListAsync();

    }
    #endregion


}
