using LMS.DAL.Repos.Interfaces;

namespace LMS.DAL;

public interface IUnitOfWork
{
    IBookRepository BookRepository { get; }
    IUserRepository UserRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IFeedbackRepository FeedbackRepository { get; }
    ITransactionRepository TransactionRepository { get; }
    IAuthorRepository AuthorRepository { get; }
    Task<int> SaveChangesAsync();

}
