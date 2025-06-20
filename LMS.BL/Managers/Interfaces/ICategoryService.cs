using LMS.BL.Shared.Models;
using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public interface ICategoryService
{
    Task<ApiResult<List<GetCategoryDto>>> GetAllCategoriesAsync();
    Task<ApiResult> GetCategoryByIdAsync(int id);
    Task<ApiResult> AddCategoryAsync(AddCategoryDto request, HttpContext httpContext);
    Task<ApiResult> UpdateCategoryAsync(UpdateCategoryDto request, HttpContext httpContext);
    Task<ApiResult> DeleteCategoryAsync(int id);
    Task<ApiResult> ActivateOrDeactivateCategoryAsync(int id);
    Task<byte[]> ExportToExcel();
}
