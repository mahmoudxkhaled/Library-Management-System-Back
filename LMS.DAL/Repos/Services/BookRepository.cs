using LMS.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
    public async Task<pagedResult<Book>> GetBooksPaged(int first, int rows, int sortOrder=1,string? sortField = null, string? Search=null, int categoryId=0, int authorId=0)
    {
        pagedResult<Book> pagedResult = new pagedResult<Book>();    
       var query= _context.Book.Include(b=>b.Author).Include(b=>b.Category).AsQueryable();
        if(!Search.IsNullOrEmpty())
        {
            query = query.Where(b => b.Title.Contains(Search) || b.Description!=null && b.Description.Contains(Search));    
        }
        if (!sortField.IsNullOrEmpty()) 
        {
            switch (sortField) 
            {
                case "publicationYear":
                    {
                        if (sortOrder == 1)
                        {
                            query = query.OrderBy(B => B.PublicationYear);
                        }
                        else query = query.OrderByDescending(B => B.PublicationYear);
                        break;
                    }
            }
        }
        if(categoryId!=0)
        {
            query = query.Where(b=>b.CategoryId==categoryId);
        }
        if (authorId != 0)
        {
            query = query.Where(b => b.AuthorId == authorId);
        }
        pagedResult.TotalCount = query.Count();  
        if (sortOrder == 1 && sortField.IsNullOrEmpty()) query = query.OrderBy(b => b.Title); 
        else if (sortField.IsNullOrEmpty() && sortOrder == -1) query = query.OrderByDescending(b => b.Title);
        pagedResult.Result=await query.Skip(first).Take(rows).ToListAsync();
        return pagedResult; 
    }
    public async Task<Book?> getBookDetailsById(int id)
    {
        return await _context.Book.Include(b=>b.Author).Include(b=>b.Category).FirstOrDefaultAsync(b => b.Id == id);
    }
    public async Task<IEnumerable<Book>> getAllBooksWithAuthor()
    {
        return await _context.Book.Include(b => b.Author).AsNoTracking().ToListAsync();
    }

    public async Task<Book?> GetBookWithAuthorByIdAsync(int id)
    {
        return await _context.Book.Include(b => b.Author).FirstOrDefaultAsync(b=>b.Id==id);
    }
    #endregion
}
