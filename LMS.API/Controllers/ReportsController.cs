using LMS.BL;
using LMS.BL.Dtos.User;
using LMS.BL.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportsController : ControllerBase
{
    private readonly IReportService _reportService;

    public ReportsController(IReportService reportService)
    {
        _reportService = reportService;
    }

    [HttpGet("DownloadTransactionReport")]
    [Authorize(Roles = "Admin,Librarian")]
    public async Task<IActionResult> DownloadTransactionReport([FromQuery] TransactionReportDto request)
    {
        try
        {
            var reportBytes = await _reportService.GenerateTransactionReportAsync(request);
            
            string fileName;
            if (request.StartDate.HasValue && request.EndDate.HasValue)
            {
                fileName = $"TransactionReport_{request.StartDate:yyyy-MM-dd}_to_{request.EndDate:yyyy-MM-dd}.xlsx";
            }
            else
            {
                fileName = "TransactionReport_All.xlsx";
            }

            return File(reportBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpGet("DownloadUserReport")]
    [Authorize(Roles = "Admin,Librarian")]
    public async Task<IActionResult> DownloadUserReport([FromQuery] UserReportRequest request)
    {
        try
        {
            var reportBytes = await _reportService.GenerateUserReportAsync(request);
            
            string fileName;
            if (request.StartDate.HasValue && request.EndDate.HasValue)
            {
                fileName = $"UserReport_{request.StartDate:yyyy-MM-dd}_to_{request.EndDate:yyyy-MM-dd}.xlsx";
            }
            else
            {
                fileName = "UserReport_All.xlsx";
            }

            return File(reportBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
} 