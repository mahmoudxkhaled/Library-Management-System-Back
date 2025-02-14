namespace LMS.DAL;

public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
{
    #region Fileds & Properities

    private readonly LMSDbContext _context;

    #endregion

    #region Construcors

    public FeedbackRepository(LMSDbContext context) : base(context)
    {
        _context = context;
    }

    #endregion

    #region Functions

    #endregion
}
