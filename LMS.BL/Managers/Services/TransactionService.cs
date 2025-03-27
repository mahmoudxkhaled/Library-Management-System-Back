using LMS.BL.Shared.Models;
using LMS.DAL;
namespace LMS.BL;

public class TransactionService : ITransactionService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITrendingBooksService _trendingBooksService;
    private readonly ICurrentUserService _currentUserService;


    public TransactionService(
        IUnitOfWork unitOfWork,
        ITrendingBooksService trendingBooksService,
        ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _trendingBooksService = trendingBooksService;
        _currentUserService = currentUserService;
    }

    public async Task<ApiResult> GetAllTransactionsAsync()
    {
        try
        {
            var transactions = await _unitOfWork.TransactionRepository.GetAllAsync();
            var transactionList = transactions.Select(t => new GetTransactionDto
            {
                Id = t.Id,
                UserId = t.UserId,
                BookId = t.BookId,
                IssueDate = t.IssueDate,
                DueDate = t.DueDate,
                ReturnDate = t.ReturnDate,
                Status = t.Status
            }).ToList();

            return new ApiResult { IsSuccess = true, Data = transactionList };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> GetTransactionByIdAsync(string id)
    {
        try
        {
            var transaction = await _unitOfWork.TransactionRepository.GetByIdAsync(id);
            if (transaction == null)
                return new ApiResult { IsSuccess = false, Message = "Transaction not found" };

            return new ApiResult
            {
                IsSuccess = true,
                Data = new GetTransactionDto
                {
                    Id = transaction.Id,
                    UserId = transaction.UserId,
                    BookId = transaction.BookId,
                    IssueDate = transaction.IssueDate,
                    DueDate = transaction.DueDate,
                    ReturnDate = transaction.ReturnDate,
                    Status = transaction.Status
                }
            };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> AddTransactionAsync(AddTransactionDto request)
    {
        try
        {
            var transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                BookId = request.BookId,
                IssueDate = request.IssueDate,
                DueDate = request.DueDate,
                Status = TransactionStatus.Issued.ToString(),
                InsertedUserId = _currentUserService.UserId,
                InsertedTime = DateTime.Now
            };
            await _trendingBooksService.IncrementTrendingBookAsync(request.BookId);

            await _unitOfWork.TransactionRepository.AddAsync(transaction);
            await _unitOfWork.SaveChangesAsync();
            return new ApiResult { IsSuccess = true, Message = "Transaction created successfully", Data = transaction };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> UpdateTransactionAsync(UpdateTransactionDto request)
    {
        try
        {
            var transaction = await _unitOfWork.TransactionRepository.GetByIdAsync(request.Id);
            if (transaction == null)
                return new ApiResult { IsSuccess = false, Message = "Transaction not found" };

            transaction.ReturnDate = request.ReturnDate ?? transaction.ReturnDate;
            transaction.Status = request.Status ?? transaction.Status;
            transaction.UpdateUserId = _currentUserService.UserId;
            transaction.UpdateTime = DateTime.Now;

            _unitOfWork.TransactionRepository.Update(transaction);
            await _unitOfWork.SaveChangesAsync();
            return new ApiResult { IsSuccess = true, Message = "Transaction updated successfully", Data = transaction };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> DeleteTransactionAsync(string id)
    {
        try
        {
            var transaction = await _unitOfWork.TransactionRepository.GetByIdAsync(id);
            if (transaction == null)
                return new ApiResult { IsSuccess = false, Message = "Transaction not found" };

            await _unitOfWork.TransactionRepository.DeleteAsync(transaction, _currentUserService.UserId!);
            return new ApiResult { IsSuccess = true, Message = "Transaction marked as deleted" };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }
}
