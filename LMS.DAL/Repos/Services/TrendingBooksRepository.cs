
using Microsoft.EntityFrameworkCore;

namespace LMS.DAL;

public class TrendingBooksRepository : GenericRepository<TrendingBook>, ITrendingBooksRepository
{
    #region Fileds & Properities

    private readonly LMSDbContext _context;

    #endregion

    #region Construcors

    public TrendingBooksRepository(LMSDbContext context) : base(context)
    {
        _context = context;
    }



    #endregion

    #region Functions
    public Task<TrendingBook?> GetByBookIdAsync(int bookId)
    {
        return _context.TrendingBooks.FirstOrDefaultAsync(b => b.BookId == bookId);
    }


    #endregion
}
