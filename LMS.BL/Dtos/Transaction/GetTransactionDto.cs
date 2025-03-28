namespace LMS.BL;
public class GetTransactionDto
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = null!;
    public int BookId { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string Status { get; set; } = null!;
}
