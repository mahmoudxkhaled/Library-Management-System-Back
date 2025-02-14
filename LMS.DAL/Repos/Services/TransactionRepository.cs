namespace LMS.DAL;

public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
{
    #region Fileds & Properities

    private readonly LMSDbContext _context;

    #endregion

    #region Construcors

    public TransactionRepository(LMSDbContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Functions

    #endregion
}
