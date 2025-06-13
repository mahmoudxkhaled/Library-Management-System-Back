using System.Collections.Generic;
using System.Threading.Tasks;
using LMS.BL.Dtos;

namespace LMS.BL.Services
{
    public interface IDashboardService
    {
        Task<IEnumerable<TopUserDto>> GetTopBorrowingUsersAsync(int count = 5);
        Task<IEnumerable<TopBookDto>> GetTopBorrowedBooksAsync(int? count = 5);
        Task<IEnumerable<TopCategoryDto>> GetTopBorrowedCategoriesAsync(int? count = 5);
        Task<IEnumerable<TopAuthorDto>> GetTopBorrowedAuthorsAsync(int? count = 5);
    }
} 