namespace LMS.DAL;

public interface IFeedbackRepository : IGenericRepository<Feedback>
{
    Task<IEnumerable<Feedback>> GetAllFeedbacksByBookIdAsync(string bookId);
}
