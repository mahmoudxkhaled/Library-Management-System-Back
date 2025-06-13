using System;

namespace LMS.BL.Dtos
{
    public class TopBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int BorrowCount { get; set; }
        public string ImageUrl { get; set; }
    }
} 