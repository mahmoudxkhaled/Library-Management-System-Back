namespace LMS.BL.Shared.Models;

public class ApiResult
{
    public string? Message { get; set; }
    public bool IsSuccess { get; set; }
    public int Code { get; set; }
    public object? Data { get; set; }
    public List<ApiError>? ErrorList { get; set; }

}
