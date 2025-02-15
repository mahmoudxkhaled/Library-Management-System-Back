using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public class AddCategoryDto
{
    public string Name { get; set; } = null!;
    public IFormFile? ImageUrl { get; set; }

}
