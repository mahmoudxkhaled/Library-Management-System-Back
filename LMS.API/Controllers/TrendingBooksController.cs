using LMS.BL;
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

    [HttpGet("GetAllTrendingBooks")]
    public async Task<IActionResult> GetAllTrendingBooks()
    {
        var result = await _trendingBooksService.GetAllTrendingBooksAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("IncrementTrendingBook/{bookId}")]
    public async Task<IActionResult> IncrementTrendingBook(int bookId)
    {
        var result = await _trendingBooksService.IncrementTrendingBookAsync(bookId);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
