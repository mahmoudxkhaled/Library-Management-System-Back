using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMS.BL;

public class UpdateUserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Role { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public IFormFile? ProfileImageUrl { get; set; }
}
