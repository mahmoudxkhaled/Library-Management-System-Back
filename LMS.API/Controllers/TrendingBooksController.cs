using LMS.BL;
using LMS.BL.Dtos.Book;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrendingBooksController : ControllerBase
{
    private readonly ITrendingBooksService _trendingBooksService;

    public TrendingBooksController(ITrendingBooksService trendingBooksService)
    {
        _trendingBooksService = trendingBooksService;
    }

    [HttpPost("GetAllTrendingBooks/{first}/{rows}")]
    public async Task<ActionResult> GetAllTrendingBooks(int first, int rows, BookParams bookParams)

    {
        var result = await _trendingBooksService.GetAllTrendingBooksAsync(first, rows, bookParams.sortOrder, bookParams.sortField, bookParams.Search, bookParams.categoryId, bookParams.authorId);
        if (result.Data != null)
        {
            for (int i = 0; i < result.Data.Result.Count; i++)
            {
                if (result.Data.Result[i].ImageUrl != null)
                {
                    result.Data.Result[i].ImageUrl = $"{Request.Scheme}://{Request.Host}/{result.Data.Result[i].ImageUrl}";
                }
            };
        }
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("SetTrendingBook/{bookId}")]
    public async Task<IActionResult> SetTrendingBook(int bookId)
    {
        var result = await _trendingBooksService.SetTrendingBookAsync(bookId);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
