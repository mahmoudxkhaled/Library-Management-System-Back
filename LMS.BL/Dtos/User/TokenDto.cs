namespace LMS.BL;

public class TokenDto
{
    public string UserId { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? UserImageUrl { get; set; }
    public string Token { get; set; } = null!;
    public long ExpiresIn { get; set; }
}