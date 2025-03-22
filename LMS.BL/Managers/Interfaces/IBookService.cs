using LMS.BL.Dtos.Book;
using LMS.BL.Shared.Models;
using LMS.DAL.Data;
using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public interface IBookService
{
    Task<ApiResult<List<GetBookDto>>> GetAllBooksAsync();
    Task<ApiResult> GetBookByIdAsync(string id);
    Task<ApiResult> AddBookAsync(AddBookDto request, HttpContext httpContext);
    Task<ApiResult> UpdateBookAsync(UpdateBookDto request, HttpContext httpContext);
    Task<ApiResult> DeleteBookAsync(string id);
    Task<ApiResult> ActivateOrDeactivateBookAsync(string id);
    Task<ApiResult<pagedResult<ReadBookDto>>> GetBooksPaged(int first, int rows, int sort, string Search);
}
