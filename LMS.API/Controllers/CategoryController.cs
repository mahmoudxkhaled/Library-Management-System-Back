using LMS.BL;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetAllCategories")]
    public async Task<IActionResult> GetAllCategories()
    {
        var result = await _categoryService.GetAllCategoriesAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetCategoryById/{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var result = await _categoryService.GetCategoryByIdAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddCategory")]
    public async Task<IActionResult> AddCategory([FromBody] AddCategoryDto request)
    {
        var result = await _categoryService.AddCategoryAsync(request, HttpContext);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPut("UpdateCategory")]
    public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto request)
    {
        var result = await _categoryService.UpdateCategoryAsync(request, HttpContext);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("DeleteCategory/{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var result = await _categoryService.DeleteCategoryAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPut("ActivateOrDeactivateCategory/{id}")]
    public async Task<IActionResult> ActivateOrDeactivateCategory(int id)
    {
        var result = await _categoryService.ActivateOrDeactivateCategoryAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
