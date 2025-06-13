using LMS.BL.Managers.Interfaces;
using LMS.DAL;
using Microsoft.Extensions.Configuration;

namespace LMS.BL.Services
{
    public class OverdueNotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public OverdueNotificationService(
            IUnitOfWork unitOfWork,
            IEmailService emailService,
            IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _emailService = emailService;
            _configuration = configuration;
        }

        public async Task ProcessOverdueNotifications()
        {
            var overdueTransactions = (await _unitOfWork.TransactionRepository.GetAllAsync())
                .Where(t => t.Status == "Overdue" && (t.LastOverdueNotified == null || t.LastOverdueNotified.Value.Date < DateTime.Now.Date))
                .ToList();

            foreach (var transaction in overdueTransactions)
            {
                if (transaction.User?.Email != null)
                {
                    var subject = "Library Book Overdue Notice";
                    var body = $"Dear {transaction.User.FirstName},\n\nYour borrowed book '{transaction.Book?.Title}' is overdue. Please return it as soon as possible.";

                    await _emailService.SendEmailAsync(transaction.User.Email, subject, body);
                    transaction.LastOverdueNotified = DateTime.Now;
                }
            }
            await _unitOfWork.SaveChangesAsync();
        }
    }
}