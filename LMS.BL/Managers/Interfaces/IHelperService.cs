using Microsoft.AspNetCore.Http;

namespace LMS.BL;

public interface IHelperService
{
    Task<string> SaveFileAsync(IFormFile file, string folderName, HttpContext httpContext);

}
