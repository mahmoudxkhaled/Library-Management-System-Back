namespace LMS.DAL;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    Task<bool> HasUserBorrowedBookAsync(int userId, int bookId);
}
