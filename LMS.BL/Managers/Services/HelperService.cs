using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace LMS.BL;

public class HelperService : IHelperService
{
    #region Fields & Properties

    private readonly IHostEnvironment _webHostEnvironment;

    public HelperService(IHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    #endregion

    #region Functions

    public async Task<string> SaveFileAsync(IFormFile file, string folderName, HttpContext httpContext)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("File cannot be empty");

        var uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Uploads", folderName);
        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);

        var timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
        var uniqueFileName = $"{Guid.NewGuid()}_{timestamp}{Path.GetExtension(file.FileName)}";
        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }

        var baseUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}";
        var relativePath = filePath.Replace(_webHostEnvironment.ContentRootPath, string.Empty).Replace('\\', '/');
        return $"{baseUrl}{relativePath}";
    }

    #endregion
}
