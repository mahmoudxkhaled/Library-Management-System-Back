namespace LMS.DAL;

public class Book : ISharedColumns
{
    public int Id { get; set; } 
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public string Description { get; set; }
    public int PublicationYear { get; set; }
    public int AvailableCopies { get; set; }
    public int TotalCopies { get; set; }

    public int CategoryId { get; set; }
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
