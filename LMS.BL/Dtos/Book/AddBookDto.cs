using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public class AddBookDto
{
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string CategoryId { get; set; } = null!;
    public int PublicationYear { get; set; }
    public int AvailableCopies { get; set; }
    public int TotalCopies { get; set; }
    public IFormFile? ImageUrl { get; set; }

}