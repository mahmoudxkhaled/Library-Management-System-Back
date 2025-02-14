using System.ComponentModel.DataAnnotations;

namespace LMS.DAL;

public class Feedback : ISharedColumns
{
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public User? User { get; set; }

    public string BookId { get; set; } = null!;
    public Book? Book { get; set; }


    [Range(1, 5)]
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;

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
