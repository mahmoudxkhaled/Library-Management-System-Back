using LMS.DAL;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace LMS.BL;

public class ReportService : IReportService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<User> _userManager;

    public ReportService(IUnitOfWork unitOfWork, UserManager<User> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<byte[]> GenerateTransactionReportAsync(TransactionReportDto request)
    {
        // Set the license context for EPPlus 8+
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var transactions = await _unitOfWork.TransactionRepository.GetAllAsync();
        var filteredTransactions = transactions
            .Where(t => (!request.StartDate.HasValue || t.IssueDate >= request.StartDate.Value) &&
                       (!request.EndDate.HasValue || t.IssueDate <= request.EndDate.Value))
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

    public async Task<byte[]> GenerateUserReportAsync(UserReportRequest request)
    {
        // Set the license context for EPPlus 8+
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var users = await _unitOfWork.UserRepository.GetWhereAsync
             (u => (!request.StartDate.HasValue || u.InsertedTime >= request.StartDate.Value) && (!request.EndDate.HasValue || u.InsertedTime <= request.EndDate.Value));
        users = users
            .OrderBy(u => u.Role == "Admin" ? 0 : u.Role == "Librarian" ? 1 : 2)
            .ThenBy(u => u.FirstName + " " + u.LastName)
            .ToList();

        using var package = new ExcelPackage();
        var worksheet = package.Workbook.Worksheets.Add("Users");

        // Add headers
        worksheet.Cells[1, 1].Value = "User ID";
        worksheet.Cells[1, 2].Value = "Full Name";
        worksheet.Cells[1, 3].Value = "Email";
        worksheet.Cells[1, 4].Value = "Role";
        worksheet.Cells[1, 5].Value = "Books Borrowed";
        worksheet.Cells[1, 6].Value = "Joined Date";

        // Style the header row
        using (var range = worksheet.Cells[1, 1, 1, 6])
        {
            range.Style.Font.Bold = true;
            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
        }

        // Add user data
        int row = 2;
        foreach (var user in users)
        {
            var booksBorrowed = (await _unitOfWork.TransactionRepository.GetAllAsync())
                .Count(t => t.UserId == user.Id && t.Status != TransactionStatus.Returned.ToString());

            worksheet.Cells[row, 1].Value = user.Id;
            worksheet.Cells[row, 2].Value = user.FirstName + " " + user.LastName;
            worksheet.Cells[row, 3].Value = user.Email;
            worksheet.Cells[row, 4].Value = user.Role;
            worksheet.Cells[row, 5].Value = booksBorrowed;
            worksheet.Cells[row, 6].Value = user.InsertedTime;

            // Format date column
            worksheet.Cells[row, 6].Style.Numberformat.Format = "yyyy-mm-dd";

            row++;
        }

        // Auto-fit columns
        worksheet.Cells.AutoFitColumns();

        return package.GetAsByteArray();
    }
}