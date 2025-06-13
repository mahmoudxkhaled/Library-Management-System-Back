using LMS.BL.Shared.Models;
using LMS.DAL.Data;

namespace LMS.BL;

public interface ITrendingBooksService
{

    Task<ApiResult<pagedResult<GetBookDto>>> GetAllTrendingBooksAsync(int first, int rows, int sortOrder, string? sortField, string? Search, int? categoryId, int? authorId);

    Task<ApiResult> SetTrendingBookAsync(int bookId);
}
