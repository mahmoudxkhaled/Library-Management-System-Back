using LMS.BL.Dtos;

namespace LMS.BL.Services
{
    public interface IDashboardService
    {
        Task<DashboardDto> GetDashboardAsync(int count = 5);
    }
} 