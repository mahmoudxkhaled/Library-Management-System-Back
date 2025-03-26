namespace LMS.BL;

public class GetFeedbackDto
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = null!;
    public int BookId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
}
