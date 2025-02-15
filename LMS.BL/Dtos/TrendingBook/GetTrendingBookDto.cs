namespace LMS.BL;

public class GetTrendingBookDto
{
    public string Id { get; set; } = null!;
    public string BookId { get; set; } = null!;
    public int BorrowCount { get; set; }
}
