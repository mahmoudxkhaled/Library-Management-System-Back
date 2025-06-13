using LMS.BL.Shared.Models;

namespace LMS.BL;

public interface ITransactionService
{
    Task<ApiResult> GetAllTransactionsAsync();
    Task<ApiResult> GetTransactionByIdAsync(string id);
    Task<ApiResult> GetTransactionsByUserIdAsync(int userId);
    Task<ApiResult> GetCurrentUserTransactionsAsync();
    Task<ApiResult> AddTransactionAsync(AddTransactionDto request);
    Task<ApiResult> UpdateTransactionAsync(UpdateTransactionDto request);
    Task<ApiResult> DeleteTransactionAsync(string id);
    Task<ApiResult> BorrowBookAsync(BorrowBookDto request);
    Task<byte[]> GenerateTransactionReportAsync(TransactionReportDto request);
    Task<int> SendOverdueNotificationsAsync();
    Task<ApiResult> ChangeTransactionStatusAsync(ChangeTransactionStatusDto request);
}
