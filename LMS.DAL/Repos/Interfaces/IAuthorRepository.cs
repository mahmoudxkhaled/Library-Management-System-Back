using LMS.DAL.Data;
using LMS.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Repos.Interfaces
{
    public interface IAuthorRepository:IGenericRepository<Author>
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<pagedResult<Author>> GetAllAuthors(int first, int rows,int sortOrder=1,string? sortField = null,string? search = null,bool? isActive=null);
        Task<bool> checkAuthorHasBook(int id);

    }
}
