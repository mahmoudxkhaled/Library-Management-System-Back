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

    #endregion
}
