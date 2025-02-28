namespace LMS.DAL;

public class Category : ISharedColumns
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public ICollection<Book> Books { get; set; } = new HashSet<Book>();


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
