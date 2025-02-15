using Microsoft.AspNetCore.Identity;

namespace LMS.DAL
{
    public class User : IdentityUser, ISharedColumns
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImageUrl { get; set; }

        public string Role { get; set; } = null!; // Admin, Librarian, Member

        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
        public ICollection<Feedback> Feedbacks { get; set; } = new HashSet<Feedback>();

        #region Shared Columns

        public DateTime? InsertedTime { get; set; }
        public string? InsertedUserId { get; set; }

        public DateTime? UpdateTime { get; set; }
        public string? UpdateUserId { get; set; }

        public bool IsActive { get; set; } = true;
        public string? ActivationUserId { get; set; }
        public DateTime? ActivationTime { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public string? DeletedUserId { get; set; }

        #endregion
    }
}
