using System.Collections.Generic;
using System.Threading.Tasks;
using LMS.BL.Dtos;
using LMS.BL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("top-borrowing-users")]
        public async Task<ActionResult<IEnumerable<TopUserDto>>> GetTopBorrowingUsers([FromQuery] int? count = 5)
        {
            var topUsers = await _dashboardService.GetTopBorrowingUsersAsync(count ?? 5);
            return Ok(topUsers);
        }

        [HttpGet("top-borrowed-books")]
        public async Task<ActionResult<IEnumerable<TopBookDto>>> GetTopBorrowedBooks([FromQuery] int? count = 5)
        {
            var topBooks = await _dashboardService.GetTopBorrowedBooksAsync(count);
            return Ok(topBooks);
        }

        [HttpGet("top-borrowed-categories")]
        public async Task<ActionResult<IEnumerable<TopCategoryDto>>> GetTopBorrowedCategories([FromQuery] int? count = 5)
        {
            var topCategories = await _dashboardService.GetTopBorrowedCategoriesAsync(count);
            return Ok(topCategories);
        }

        [HttpGet("top-borrowed-authors")]
        public async Task<ActionResult<IEnumerable<TopAuthorDto>>> GetTopBorrowedAuthors([FromQuery] int? count = 5)
        {
            var topAuthors = await _dashboardService.GetTopBorrowedAuthorsAsync(count);
            return Ok(topAuthors);
        }
    }
} 