namespace LMS.BL;

public class AddFeedbackDto
{
    public int UserId { get; set; }  
    public int BookId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
}
