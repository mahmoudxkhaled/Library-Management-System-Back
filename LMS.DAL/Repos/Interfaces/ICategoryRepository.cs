namespace LMS.DAL;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<IEnumerable<Category>> GetAllCategoriesWithBooks();

}
