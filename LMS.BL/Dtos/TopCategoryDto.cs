using System;

namespace LMS.BL.Dtos
{
    public class TopCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BorrowCount { get; set; }
        public string ImageUrl { get; set; }
    }
} 