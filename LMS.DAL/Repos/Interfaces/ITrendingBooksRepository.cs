namespace LMS.DAL;

public interface ITrendingBooksRepository : IGenericRepository<TrendingBook>
{
    Task<TrendingBook?> GetByBookIdAsync(int bookId);
}
