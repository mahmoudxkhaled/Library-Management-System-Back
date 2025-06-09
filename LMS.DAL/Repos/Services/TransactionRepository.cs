using Microsoft.EntityFrameworkCore;

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

    public override async Task<IEnumerable<Transaction>> GetAllAsync()
    {
        return await _context.Transaction
            .Include(t => t.User)
            .Include(t => t.Book)
            .ToListAsync();
    }

    public override async Task<Transaction?> GetByIdAsync(object id)
    {
        var idGuid = new Guid((string)id);



        return await _context.Transaction
            .Include(t => t.User)
            .Include(t => t.Book)
            .FirstOrDefaultAsync(t => t.Id == idGuid);
    }




    #endregion
}
