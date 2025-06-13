using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.BL.Dtos;
using LMS.DAL;
using Microsoft.EntityFrameworkCore;

namespace LMS.BL.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly ITransactionRepository _transactionRepository;

        public DashboardService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<IEnumerable<TopUserDto>> GetTopBorrowingUsersAsync(int count = 5)
        {
            var topUsers = await _transactionRepository.GetAll()
                .Where(t => t.Status != TransactionStatus.Pending.ToString())
                .GroupBy(t => new { t.UserId, t.User.FirstName, t.User.LastName })
                .Select(g => new TopUserDto
                {
                    Id = g.Key.UserId,
                    FullName = $"{g.Key.FirstName} {g.Key.LastName}",
                    BooksBorrowedCount = g.Count()
                })
                .OrderByDescending(u => u.BooksBorrowedCount)
                .Take(count)
                .ToListAsync();

            return topUsers;
        }

        public async Task<IEnumerable<TopBookDto>> GetTopBorrowedBooksAsync(int? count = 5)
        {
            var actualCount = count ?? 5;
            var topBooks = await _transactionRepository.GetAll()
                .Where(t => t.Status != TransactionStatus.Pending.ToString())
                .GroupBy(t => new { t.BookId, t.Book.Title, t.Book.Author.FullName, t.Book.ImageUrl })
                .Select(g => new TopBookDto
                {
                    Id = g.Key.BookId,
                    Title = g.Key.Title,
                    AuthorName = g.Key.FullName,
                    ImageUrl = g.Key.ImageUrl,
                    BorrowCount = g.Count()
                })
                .OrderByDescending(b => b.BorrowCount)
                .Take(actualCount)
                .ToListAsync();

            return topBooks;
        }

        public async Task<IEnumerable<TopCategoryDto>> GetTopBorrowedCategoriesAsync(int? count = 5)
        {
            var actualCount = count ?? 5;
            var topCategories = await _transactionRepository.GetAll()
                .Where(t => t.Status != TransactionStatus.Pending.ToString())
                .GroupBy(t => new { t.Book.CategoryId, t.Book.Category.Name, t.Book.Category.ImageUrl })
                .Select(g => new TopCategoryDto
                {
                    Id = g.Key.CategoryId,
                    Name = g.Key.Name,
                    ImageUrl = g.Key.ImageUrl,
                    BorrowCount = g.Count()
                })
                .OrderByDescending(c => c.BorrowCount)
                .Take(actualCount)
                .ToListAsync();

            return topCategories;
        }

        public async Task<IEnumerable<TopAuthorDto>> GetTopBorrowedAuthorsAsync(int? count = 5)
        {
            var actualCount = count ?? 5;
            var topAuthors = await _transactionRepository.GetAll()
                .Where(t => t.Status != TransactionStatus.Pending.ToString())
                .GroupBy(t => new { t.Book.AuthorId, t.Book.Author.FullName, t.Book.Author.ImageUrl })
                .Select(g => new TopAuthorDto
                {
                    Id = g.Key.AuthorId,
                    FullName = g.Key.FullName,
                    ImageUrl = g.Key.ImageUrl,
                    BorrowCount = g.Count()
                })
                .OrderByDescending(a => a.BorrowCount)
                .Take(actualCount)
                .ToListAsync();

            return topAuthors;
        }
    }
}