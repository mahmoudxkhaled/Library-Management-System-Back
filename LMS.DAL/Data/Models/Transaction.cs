using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DAL
{
    public class Transaction : ISharedColumns
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string UserId { get; set; } = string.Empty;

        public User? User { get; set; }

        [Required]
        public int BookId { get; set; }

        public Book? Book { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; } // Calculated based on the number of borrow days.

        public DateTime? ReturnDate { get; set; } // Actual return date.

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Issued";
        // "Issued" → Book is borrowed but not yet returned.
        // "Returned" → Book has been successfully returned.
        // "Overdue" → Book is past due and not yet returned.

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
