namespace LMS.BL;

public class GetFeedbackDto
{
    public Guid Id { get; set; }
    public int UserId { get; set; } 
    public int BookId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
}
