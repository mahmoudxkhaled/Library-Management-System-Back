namespace LMS.DAL;

public class Book : ISharedColumns
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public int PublicationYear { get; set; }
    public int AvailableCopies { get; set; }
    public int TotalCopies { get; set; }

    public string CategoryId { get; set; } = null!;
    public Category? Category { get; set; }

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
