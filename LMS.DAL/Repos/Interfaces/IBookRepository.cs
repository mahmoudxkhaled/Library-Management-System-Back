using LMS.DAL.Data;

namespace LMS.DAL;

public interface IBookRepository : IGenericRepository<Book>
{
    Task<pagedResult<Book>> GetBooksPaged(int first, int rows, int sortOrder = 1, string? sortField = null, string? Search = null,int categoryI=0, int authorId = 0);
    Task<Book?> getBookDetailsById(int id);
    Task<IEnumerable<Book>> getAllBooksWithAuthor();
    Task<Book?> GetBookWithAuthorByIdAsync(int id);
}
