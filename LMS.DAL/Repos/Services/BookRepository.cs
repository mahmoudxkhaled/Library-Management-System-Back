namespace LMS.DAL;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    #region Fileds & Properities

    private readonly LMSDbContext _context;

    #endregion

    #region Construcors

    public BookRepository(LMSDbContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Functions

    #endregion
}
