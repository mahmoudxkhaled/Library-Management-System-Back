using LMS.BL.Shared.Models;
using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public interface IBookService
{
    Task<ApiResult> GetAllBooksAsync();
    Task<ApiResult> GetBookByIdAsync(string id);
    Task<ApiResult> AddBookAsync(AddBookDto request, HttpContext httpContext);
    Task<ApiResult> UpdateBookAsync(UpdateBookDto request, HttpContext httpContext);
    Task<ApiResult> DeleteBookAsync(string id);
    Task<ApiResult> ActivateOrDeactivateBookAsync(string id);
}
