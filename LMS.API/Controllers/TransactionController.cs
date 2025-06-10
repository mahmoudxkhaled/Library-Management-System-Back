using LMS.BL;
using LMS.BL.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LMS.DAL;

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

    [HttpGet("GetTransactionsByUserId/{userId}")]
    [Authorize(Roles = "Admin,Librarian")]
    public async Task<IActionResult> GetTransactionsByUserId(int userId)
    {
        var result = await _transactionService.GetTransactionsByUserIdAsync(userId);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("MyBorrowHistory")]
    [Authorize]
    public async Task<ActionResult<ApiResult>> GetCurrentUserTransactions()
    {
        var result = await _transactionService.GetCurrentUserTransactionsAsync();
        return Ok(result);
    }

    [HttpPost("BorrowBook")]
    [Authorize]
    public async Task<ActionResult<ApiResult>> BorrowBook(BorrowBookDto request)
    {
        var result = await _transactionService.BorrowBookAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("DownloadActivitiesReport")]
    [Authorize(Roles = "Admin,Librarian")]
    public async Task<IActionResult> DownloadReport(TransactionReportDto request)
    {
        try
        {
            var reportBytes = await _transactionService.GenerateTransactionReportAsync(request);
            var fileName = $"TransactionReport_{request.StartDate:yyyyMMdd}_{request.EndDate:yyyyMMdd}.xlsx";

            return File(
                reportBytes,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileName
            );
        }
        catch (Exception ex)
        {
            return BadRequest(new ApiResult { IsSuccess = false, Message = ex.Message });
        }
    }

    [HttpPost("SendOverdueNotifications")]
    [Authorize(Roles = "Admin,Librarian")]
    public async Task<IActionResult> SendOverdueNotifications()
    {
        int sent = await _transactionService.SendOverdueNotificationsAsync();
        return Ok(new { Message = $"Overdue notifications sent: {sent}" });
    }
}
