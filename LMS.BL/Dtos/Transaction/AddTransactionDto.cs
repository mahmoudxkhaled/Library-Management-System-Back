namespace LMS.BL;

public class AddTransactionDto
{
    public string UserId { get; set; } = null!;
    public string BookId { get; set; } = null!;
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string Status { get; set; } = null!;
}
