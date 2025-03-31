using LMS.BL.Shared.Models;
using LMS.DAL;
namespace LMS.BL;
public class FeedbackService : IFeedbackService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;

    public FeedbackService(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
    }

    public async Task<ApiResult> GetAllFeedbacksAsync()
    {
        try
        {
            var feedbacks = await _unitOfWork.FeedbackRepository.GetAllAsync();
            var feedbackList = feedbacks.Select(f => new GetFeedbackDto
            {
                Id = f.Id,
                UserId = f.UserId,
                BookId = f.BookId,
                Rating = f.Rating,
                Comment = f.Comment
            }).ToList();

            return new ApiResult { IsSuccess = true, Data = feedbackList };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }
    public async Task<ApiResult> GetAllFeedbacksByBookIdAsync(int bookId)
    {
        try
        {
            var feedbacks = await _unitOfWork.FeedbackRepository.GetAllFeedbacksByBookIdAsync(bookId);
            var feedbackList = feedbacks.Select(f => new GetFeedbackDto
            {
                Id = f.Id,
                UserId = f.UserId,
                UserFirstName = f.User?.FirstName ?? "Unknown",
                UserLastName = f.User?.LastName ?? "User",
                BookId = f.BookId,
                Rating = f.Rating,
                Comment = f.Comment
            }).ToList();

            return feedbackList.Any()
                ? new ApiResult { IsSuccess = true, Data = feedbackList }
                : new ApiResult { IsSuccess = true, Message = "No feedbacks found for this book" };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }
    public async Task<ApiResult> AddFeedbackAsync(AddFeedbackDto request)
    {
        try
        {
            var feedback = new Feedback
            {
                UserId = request.UserId,
                BookId = request.BookId,
                Rating = request.Rating,
                Comment = request.Comment,
                InsertedUserId = _currentUserService.UserId,
                InsertedTime = DateTime.Now
            };

            await _unitOfWork.FeedbackRepository.AddAsync(feedback);
            await _unitOfWork.SaveChangesAsync();
            return new ApiResult { IsSuccess = true, Message = "Feedback created successfully", Data = feedback };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }
}
