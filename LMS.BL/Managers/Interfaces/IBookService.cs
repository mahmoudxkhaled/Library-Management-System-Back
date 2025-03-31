using LMS.BL.Dtos.Book;
using LMS.BL.Shared.Models;
using LMS.DAL.Data;
using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public interface IBookService
{
    Task<ApiResult<List<GetBookDto>>> GetAllBooksAsync();
    Task<ApiResult> GetBookByIdAsync(int id);
    Task<ApiResult<BookDetailsDto>> getBookDetailsById(int id);
    Task<ApiResult> AddBookAsync(AddBookDto request, HttpContext httpContext);
    Task<ApiResult> UpdateBookAsync(UpdateBookDto request, HttpContext httpContext);
    Task<ApiResult> DeleteBookAsync(int id);
    Task<ApiResult> ActivateOrDeactivateBookAsync(int id);
    Task<ApiResult<List<GetBookDto>>> GetBooksByCategoryExceptBookAsync(int bookId);
    Task<ApiResult<pagedResult<ReadBookDto>>> GetBooksPaged(int first, int rows, int sortOrder, string? sortField, string? Search, int categoryId, int authorId);
}
