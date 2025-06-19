using Microsoft.AspNetCore.Http;

namespace LMS.BL.Dtos.Author
{
    public class CreateAuthorDto
    {
        public string fullName { get; set; } = null!;
        public string? description { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public IFormFile? imageUrl { get; set; }
    }
}
