namespace LMS.DAL;

public class TrendingBook
{
    public string Id { get; set; } = null!;

    public string BookId { get; set; } = null!;
    public Book? Book { get; set; }

    public int BorrowCount { get; set; }
}
