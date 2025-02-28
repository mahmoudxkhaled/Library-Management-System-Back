namespace LMS.BL;

public class GetCategoryDto
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int BooksCount { get; set; }

    public string Description { get; set; } = null!;
    public string? ImageUrl { get; set; }

}
