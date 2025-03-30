using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public class UpdateCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public IFormFile? ImageUrl { get; set; }

}
