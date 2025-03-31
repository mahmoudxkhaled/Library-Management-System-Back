using LMS.BL;
using LMS.BL.Dtos.Book;
using LMS.BL.Shared.Models;
using LMS.DAL.Data;
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
        ApiResult<List<GetBookDto>> result = await _bookService.GetAllBooksAsync();
        if (result.Data != null)
        {
            for (int i = 0; i < result.Data.Count; i++)
            {
                if (result.Data[i].ImageUrl != null)
                {
                    result.Data[i].ImageUrl = $"{Request.Scheme}://{Request.Host}/{result.Data[i].ImageUrl}";
                }
            };
        }
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("{first}/{rows}/{sortOrder}/{Search?}")]
    public async Task<ActionResult> GetBooksPaged(int first, int rows, int sortOrder, string? Search = null)
    {
        ApiResult<pagedResult<ReadBookDto>> Books = await _bookService.GetBooksPaged(first, rows, sortOrder, Search);
        if (Books.Data != null)
        {
            for (int i = 0; i < Books.Data.Result.Count; i++)

            {
                if (Books.Data.Result[i].ImageUrl != null)
                {
                    Books.Data.Result[i].ImageUrl = $"{Request.Scheme}://{Request.Host}/{Books.Data.Result[i].ImageUrl}";
                }
            };
        }
        return Ok(Books);
    }

    [HttpGet("GetBookById/{id}")]
    public async Task<IActionResult> GetBookById(int id)
    {
        var result = await _bookService.GetBookByIdAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddBook")]
    public async Task<IActionResult> AddBook([FromForm] AddBookDto request)
    {
        var result = await _bookService.AddBookAsync(request, HttpContext);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPut("UpdateBook")]
    public async Task<IActionResult> UpdateBook([FromForm] UpdateBookDto request)
    {
        var result = await _bookService.UpdateBookAsync(request, HttpContext);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("DeleteBook/{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var result = await _bookService.DeleteBookAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPut("ActivateOrDeactivateBook/{id}")]
    public async Task<IActionResult> ActivateOrDeactivateBook(int id)
    {
        var result = await _bookService.ActivateOrDeactivateBookAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

}
