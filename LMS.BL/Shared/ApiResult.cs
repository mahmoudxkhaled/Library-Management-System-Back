namespace LMS.BL;

public class ApiResult
{
    public string? Message { get; set; }
    public bool IsSuccess { get; set; }
    public int Code { get; set; }
    public object? Data { get; set; }
}
