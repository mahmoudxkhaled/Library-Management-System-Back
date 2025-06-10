using LMS.BL.Managers.Interfaces;
using LMS.BL.Shared.Models;
using LMS.DAL;
using OfficeOpenXml;
using OfficeOpenXml.Style;
namespace LMS.BL;

public class TransactionService : ITransactionService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITrendingBooksService _trendingBooksService;
    private readonly ICurrentUserService _currentUserService;
    private readonly IEmailService _emailService;


    public TransactionService(
        IUnitOfWork unitOfWork,
        ITrendingBooksService trendingBooksService,
        ICurrentUserService currentUserService,
        IEmailService emailService)
    {
        _unitOfWork = unitOfWork;
        _trendingBooksService = trendingBooksService;
        _currentUserService = currentUserService;
        _emailService = emailService;
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
                Status = t.Status,
                UserFullName = $"{t.User?.FirstName} {t.User?.LastName}",
                BookName = t.Book?.Title ?? "Unknown Book",

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
            {
                return new ApiResult { IsSuccess = false, Message = "Transaction not found" };
            }

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
                    Status = transaction.Status,
                    UserFullName = $"{transaction.User?.FirstName} {transaction.User?.LastName}",
                    BookName = transaction.Book?.Title ?? "Unknown Book",

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
                InsertedTime = DateTime.Now,
                ReturnDate = request.ReturnDate
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
            {
                return new ApiResult { IsSuccess = false, Message = "Transaction not found" };
            }

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
            {
                return new ApiResult { IsSuccess = false, Message = "Transaction not found" };
            }

            await _unitOfWork.TransactionRepository.DeleteAsync(transaction, _currentUserService.UserId!);
            return new ApiResult { IsSuccess = true, Message = "Transaction marked as deleted" };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> GetTransactionsByUserIdAsync(int userId)
    {
        try
        {
            var transactions = await _unitOfWork.TransactionRepository.GetAllAsync();
            var transactionList = transactions
                .Where(t => t.UserId == userId)
                .Select(t => new GetTransactionDto
                {
                    Id = t.Id,
                    UserId = t.UserId,
                    BookId = t.BookId,
                    UserFullName = $"{t.User?.FirstName} {t.User?.LastName}",
                    BookName = t.Book?.Title ?? "Unknown Book",
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

    public async Task<ApiResult> GetCurrentUserTransactionsAsync()
    {
        try
        {
            var userId = int.Parse(_currentUserService.UserId!);
            var transactions = await _unitOfWork.TransactionRepository.GetAllAsync();
            var userTransactions = transactions
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.IssueDate)
                .Select(t => new UserTransactionHistoryDto
                {
                    Id = t.Id,
                    BookId = t.BookId,
                    BookName = t.Book.Title,
                    BookImageUrl = t.Book.ImageUrl,
                    IssueDate = t.IssueDate,
                    DueDate = t.DueDate,
                    ReturnDate = t.ReturnDate,
                    Status = t.Status
                })
                .ToList();

            return new ApiResult
            {
                IsSuccess = true,
                Data = userTransactions
            };
        }
        catch (Exception ex)
        {
            return new ApiResult
            {
                IsSuccess = false,
                Message = ex.Message
            };
        }
    }

    public async Task<ApiResult> BorrowBookAsync(BorrowBookDto request)
    {
        try
        {
            // Get the current user's ID
            var userId = int.Parse(_currentUserService.UserId!);

            // Check if the book exists and is available
            var book = await _unitOfWork.BookRepository.GetByIdAsync(request.BookId);
            if (book == null)
            {
                return new ApiResult { IsSuccess = false, Message = "Book not found" };
            }

            if (book.AvailableCopies <= 0)
            {
                return new ApiResult { IsSuccess = false, Message = "Book is not available for borrowing" };
            }

            // Check if user already has an active transaction for this book
            var existingTransaction = await _unitOfWork.TransactionRepository.GetAllAsync();
            var hasActiveTransaction = existingTransaction
                .Any(t => t.UserId == userId &&
                         t.BookId == request.BookId &&
                         (t.Status == TransactionStatus.Issued.ToString() ||
                          t.Status == TransactionStatus.Overdue.ToString()));

            if (hasActiveTransaction)
            {
                return new ApiResult { IsSuccess = false, Message = "You already have an active transaction for this book" };
            }

            // Create new transaction
            var transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                BookId = request.BookId,
                IssueDate = DateTime.Now,
                DueDate = request.DueDate,
                Status = TransactionStatus.Issued.ToString(),
                InsertedUserId = _currentUserService.UserId,
                InsertedTime = DateTime.Now
            };

            // Update book availability
            book.AvailableCopies--;
            book.UpdateUserId = _currentUserService.UserId;
            book.UpdateTime = DateTime.Now;

            // Add transaction and update book
            await _unitOfWork.TransactionRepository.AddAsync(transaction);
            _unitOfWork.BookRepository.Update(book);
            await _unitOfWork.SaveChangesAsync();

            // Increment trending book count
            await _trendingBooksService.IncrementTrendingBookAsync(request.BookId);

            return new ApiResult
            {
                IsSuccess = true,
                Message = "Book borrowed successfully",
                Data = new UserTransactionHistoryDto
                {
                    Id = transaction.Id,
                    BookId = book.Id,
                    BookName = book.Title,
                    BookImageUrl = book.ImageUrl,
                    IssueDate = transaction.IssueDate,
                    DueDate = transaction.DueDate,
                    Status = transaction.Status
                }
            };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<byte[]> GenerateTransactionReportAsync(TransactionReportDto request)
    {
        // Set the license context for EPPlus 8+
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var transactions = await _unitOfWork.TransactionRepository.GetAllAsync();
        var filteredTransactions = transactions
            .Where(t => t.IssueDate >= request.StartDate && t.IssueDate <= request.EndDate)
            .OrderBy(t => t.Book?.Title)
            .ThenBy(t => $"{t.User?.FirstName} {t.User?.LastName}")
            .ToList();

        using var package = new ExcelPackage();
        var worksheet = package.Workbook.Worksheets.Add("Transactions");

        // Add headers
        worksheet.Cells[1, 1].Value = "Transaction ID";
        worksheet.Cells[1, 2].Value = "Book Title";
        worksheet.Cells[1, 3].Value = "User Name";
        worksheet.Cells[1, 4].Value = "Issue Date";
        worksheet.Cells[1, 5].Value = "Due Date";
        worksheet.Cells[1, 6].Value = "Return Date";
        worksheet.Cells[1, 7].Value = "Status";

        // Style the header row
        using (var range = worksheet.Cells[1, 1, 1, 7])
        {
            range.Style.Font.Bold = true;
            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
        }

        // Add transaction data
        int row = 2;
        foreach (var transaction in filteredTransactions)
        {
            var cell = worksheet.Cells[row, 1, row, 7];

            // Check if transaction is overdue
            bool isOverdue = transaction.Status == TransactionStatus.Overdue.ToString();

            if (isOverdue)
            {
                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightPink);
                cell.Style.Font.Color.SetColor(System.Drawing.Color.Red);
            }

            worksheet.Cells[row, 1].Value = transaction.Id;
            worksheet.Cells[row, 2].Value = transaction.Book?.Title;
            worksheet.Cells[row, 3].Value = $"{transaction.User?.FirstName} {transaction.User?.LastName}";
            worksheet.Cells[row, 4].Value = transaction.IssueDate;
            worksheet.Cells[row, 5].Value = transaction.DueDate;
            worksheet.Cells[row, 6].Value = transaction.ReturnDate;
            worksheet.Cells[row, 7].Value = transaction.Status;

            // Format date columns
            worksheet.Cells[row, 4].Style.Numberformat.Format = "yyyy-mm-dd";
            worksheet.Cells[row, 5].Style.Numberformat.Format = "yyyy-mm-dd";
            worksheet.Cells[row, 6].Style.Numberformat.Format = "yyyy-mm-dd";

            row++;
        }

        // Auto-fit columns
        worksheet.Cells.AutoFitColumns();

        return package.GetAsByteArray();
    }

    public async Task<int> SendOverdueNotificationsAsync()
    {
        int sent = 0;
        var overdueTransactions = await _unitOfWork.TransactionRepository.GetWhereIncludeAsync(
            t => t.Status == "Overdue" && (t.LastOverdueNotified == null || t.LastOverdueNotified.Value.Date < DateTime.Now.Date), "User", "Book");




        foreach (var transaction in overdueTransactions)
        {
            if (transaction.User?.Email != null)
            {
                var subject = "Library Book Overdue Notice";
                var body = $"Dear {transaction.User.FirstName},\n\nYour borrowed book '{transaction.Book?.Title}' is overdue. Please return it as soon as possible.";
                try
                {
                    await _emailService.SendEmailAsync(transaction.User.Email, subject, body);
                    transaction.LastOverdueNotified = DateTime.Now;
                    sent++;
                }
                catch { }
            }
        }
        await _unitOfWork.SaveChangesAsync();
        return sent;
    }
}
