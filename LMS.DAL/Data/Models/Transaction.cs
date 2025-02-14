namespace LMS.DAL;

public class Transaction : ISharedColumns
{
    public string Id { get; set; } = null!;

    public string UserID { get; set; } = null!;
    public User? User { get; set; }

    public string BookID { get; set; } = null!;
    public Book? Book { get; set; }

    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; } // calculated based on number of borrow days
    public DateTime? ReturnDate { get; set; } // user actually returns the book
    public string Status { get; set; } = null!;// Issued, Returned, Overdue
                                               // "Issued" → When the book is borrowed but not returned.
                                               // "Returned" → When the book is successfully returned.
                                               // "Overdue" → When the return date has passed, but the book is not yet returned.

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
