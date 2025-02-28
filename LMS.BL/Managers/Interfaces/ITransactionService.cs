using LMS.BL.Shared.Models;

namespace LMS.BL;

public interface ITransactionService
{
    Task<ApiResult> GetAllTransactionsAsync();
    Task<ApiResult> GetTransactionByIdAsync(string id);
    Task<ApiResult> AddTransactionAsync(AddTransactionDto request);
    Task<ApiResult> UpdateTransactionAsync(UpdateTransactionDto request);
    Task<ApiResult> DeleteTransactionAsync(string id);
}
