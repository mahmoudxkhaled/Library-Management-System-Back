using LMS.BL;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("GetAllBooks")]
    public async Task<IActionResult> GetAllBooks()
    {
        var result = await _bookService.GetAllBooksAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetBookById/{id}")]
    public async Task<IActionResult> GetBookById(string id)
    {
        var result = await _bookService.GetBookByIdAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddBook")]
    public async Task<IActionResult> AddBook(AddBookDto request)
    {
        var result = await _bookService.AddBookAsync(request, HttpContext);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPut("UpdateBook/{id}")]
    public async Task<IActionResult> UpdateBook(UpdateBookDto request)
    {
        var result = await _bookService.UpdateBookAsync(request, HttpContext);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("DeleteBook/{id}")]
    public async Task<IActionResult> DeleteBook(string id)
    {
        var result = await _bookService.DeleteBookAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
