namespace LMS.DAL;

public interface IUnitOfWork
{
    IBookRepository BookRepository { get; }
    IUserRepository UserRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IFeedbackRepository FeedbackRepository { get; }
    ITransactionRepository TransactionRepository { get; }
    ITrendingBooksRepository TrendingBooksRepository { get; }
    Task<int> SaveChangesAsync();

}
