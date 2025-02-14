using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LMS.DAL;

public class LMSDbContext : IdentityDbContext<User>
{
    #region Constructors

    public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
    {

    }
    #endregion

    #region Entities

    public DbSet<Book> Book => Set<Book>();
    public DbSet<Category> Category => Set<Category>();
    public DbSet<Feedback> Feedback => Set<Feedback>();
    public DbSet<Transaction> Transaction => Set<Transaction>();
    public DbSet<TrendingBook> TrendingBooks => Set<TrendingBook>();
    public DbSet<User> User => Set<User>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    #endregion

    private static LambdaExpression CreateIsDeletedFilter(Type entityType)
    {
        var parameter = Expression.Parameter(entityType, "e");
        var property = Expression.Property(parameter, nameof(ISharedColumns.IsDeleted));
        var comparison = Expression.MakeBinary(ExpressionType.Equal, property, Expression.Constant(false));
        return Expression.Lambda(comparison, parameter);
    }
}
