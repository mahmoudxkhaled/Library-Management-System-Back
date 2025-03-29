using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Dtos.Book
{
    public  class ReadBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public int AuthorId { get; set; }
        public string AuthorFullName { get; set; } = null!;
        public string? AuthorImage { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int PublicationYear { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }
        public string? ImageUrl { get; set; }
    }
}
