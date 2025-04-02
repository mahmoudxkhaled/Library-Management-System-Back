using LMS.DAL.Repos.Interfaces;
using LMS.DAL.Repos.Services;

namespace LMS.DAL;

public interface IUnitOfWork
{
    IBookRepository BookRepository { get; }
    IUserRepository UserRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IFeedbackRepository FeedbackRepository { get; }
    ITransactionRepository TransactionRepository { get; }
    ITrendingBooksRepository TrendingBooksRepository { get; }
    IAuthorRepository AuthorRepository { get;}
    Task<int> SaveChangesAsync();

}
