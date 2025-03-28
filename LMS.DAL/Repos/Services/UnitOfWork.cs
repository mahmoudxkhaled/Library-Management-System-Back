namespace LMS.DAL;

public class UnitOfWork : IUnitOfWork
{
    #region Fields & Propereties

    private readonly LMSDbContext _context;

    public IBookRepository BookRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    public IFeedbackRepository FeedbackRepository { get; }
    public ITransactionRepository TransactionRepository { get; }
    public ITrendingBooksRepository TrendingBooksRepository { get; }
    public IUserRepository UserRepository { get; }
    #endregion
 


    #region Constructors

    public UnitOfWork(
          LMSDbContext context
        , IBookRepository bookRepository
        , ICategoryRepository categoryRepository
        , IFeedbackRepository feedbackRepository
        , ITransactionRepository transactionRepository
        , ITrendingBooksRepository trendingBooksRepository
        , IUserRepository userRepository

                )
    {
        _context = context;
        BookRepository = bookRepository;
        CategoryRepository = categoryRepository;
        FeedbackRepository = feedbackRepository;
        TransactionRepository = transactionRepository;
        TrendingBooksRepository = trendingBooksRepository;
        UserRepository = userRepository;

    }
    #endregion

    #region Functions

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    #endregion

}
