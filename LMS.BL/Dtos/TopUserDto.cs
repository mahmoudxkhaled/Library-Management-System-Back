using System;

namespace LMS.BL.Dtos
{
    public class TopUserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int BooksBorrowedCount { get; set; }
    }
} 