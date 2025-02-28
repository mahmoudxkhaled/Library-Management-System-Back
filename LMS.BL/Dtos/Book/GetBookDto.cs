namespace LMS.BL;

public class GetBookDto
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public int PublicationYear { get; set; }
    public int AvailableCopies { get; set; }
    public int TotalCopies { get; set; }
    public string CategoryId { get; set; } = null!;
}
