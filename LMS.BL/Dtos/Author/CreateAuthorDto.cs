using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
