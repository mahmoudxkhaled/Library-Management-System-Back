using LMS.BL.Shared.Models;

namespace LMS.BL
{
    public interface ITrendingBooksService
    {
        Task<ApiResult> GetAllTrendingBooksAsync();
        Task<ApiResult> IncrementTrendingBookAsync(string bookId);


    }
}
