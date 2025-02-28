using LMS.BL;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _transactionService;

    public TransactionController(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpGet("GetAllTransactions")]
    public async Task<IActionResult> GetAllTransactions()
    {
        var result = await _transactionService.GetAllTransactionsAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetTransactionById/{id}")]
    public async Task<IActionResult> GetTransactionById(string id)
    {
        var result = await _transactionService.GetTransactionByIdAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddTransaction")]
    public async Task<IActionResult> AddTransaction(AddTransactionDto request)
    {
        var result = await _transactionService.AddTransactionAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPut("UpdateTransaction")]
    public async Task<IActionResult> UpdateTransaction(UpdateTransactionDto request)
    {
        var result = await _transactionService.UpdateTransactionAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("DeleteTransaction/{id}")]
    public async Task<IActionResult> DeleteTransaction(string id)
    {
        var result = await _transactionService.DeleteTransactionAsync(id);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
