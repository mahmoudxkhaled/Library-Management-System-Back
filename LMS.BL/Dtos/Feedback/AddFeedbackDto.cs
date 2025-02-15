namespace LMS.BL;

public class AddFeedbackDto
{
    public string UserId { get; set; } = null!;
    public string BookId { get; set; } = null!;
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
}
