using LMS.DAL.Data;

namespace LMS.DAL;

public interface IBookRepository : IGenericRepository<Book>
{
    Task<pagedResult<Book>> GetBooksPaged(int first, int rows, int sort, string Search);

}
