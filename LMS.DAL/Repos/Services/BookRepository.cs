using LMS.DAL.Data;
using Microsoft.EntityFrameworkCore;

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
    public async Task<pagedResult<Book>> GetBooksPaged(int first, int rows, int sort=1, string? Search=null)
    {
        pagedResult<Book> pagedResult = new pagedResult<Book>();    
       var query= _context.Book.AsQueryable();
        if(Search != null)
        {
            query.Where(b => b.Title.Contains(Search) || b.Description.Contains(Search));    
        }
        pagedResult.TotalCount = query.Count();  
        if (sort == 1) query = query.OrderBy(b => b.Title); else query = query.OrderByDescending(b => b.Title);
        pagedResult.Result=await _context.Book.Skip(first).Take(rows).ToListAsync();
        return pagedResult; 
    }
    #endregion
}
