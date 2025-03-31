using LMS.BL.Dtos.Author;
using LMS.BL.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Managers.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<ReadAuthorDto>> GetAllAuthors();
    }
}
