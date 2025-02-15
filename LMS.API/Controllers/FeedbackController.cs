using LMS.BL;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FeedbackController : ControllerBase
{
    private readonly IFeedbackService _feedbackService;

    public FeedbackController(IFeedbackService feedbackService)
    {
        _feedbackService = feedbackService;
    }

    [HttpGet("GetAllFeedbacks")]
    public async Task<IActionResult> GetAllFeedbacks()
    {
        var result = await _feedbackService.GetAllFeedbacksAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddFeedback")]
    public async Task<IActionResult> AddFeedback(AddFeedbackDto request)
    {
        var result = await _feedbackService.AddFeedbackAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
