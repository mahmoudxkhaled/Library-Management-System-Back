using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? ImageUrl { get; set; }   
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();

    }
}
