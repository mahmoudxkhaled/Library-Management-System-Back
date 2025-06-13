using System.ComponentModel.DataAnnotations;

namespace LMS.BL.Dtos.Transaction;

public class IssueBookDto
{
    [Required]
    public string TransactionId { get; set; } = null!;
    [Required]
    public DateTime IssueDate { get; set; }
}
