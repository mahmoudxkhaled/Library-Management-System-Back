using LMS.BL.Dtos.User;
using LMS.BL.Shared.Models;

namespace LMS.BL;

public interface IReportService
{
    Task<byte[]> GenerateTransactionReportAsync(TransactionReportDto request);
    Task<byte[]> GenerateUserReportAsync(UserReportRequest request);
} 