using LMS.BL.Shared.Models;

namespace LMS.BL
{
    public interface IFeedbackService
    {
        Task<ApiResult> GetAllFeedbacksAsync();
        Task<ApiResult> GetAllFeedbacksByBookIdAsync(string bookId);
        Task<ApiResult> AddFeedbackAsync(AddFeedbackDto request);
    }
}
