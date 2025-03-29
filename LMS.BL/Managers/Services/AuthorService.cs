using LMS.BL.Dtos.Author;
using LMS.BL.Managers.Interfaces;
using LMS.DAL.Data.Models;
using LMS.DAL.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Managers.Services
{
    public class AuthorService:IAuthorService
    {
        private IAuthorRepository AuthorRepository;   
        public AuthorService(IAuthorRepository authorRepository)
        {
            AuthorRepository = authorRepository;
        }
        public async Task<IEnumerable<ReadAuthorDto>> GetAllAuthors()
        {
            IEnumerable<Author> authors=await AuthorRepository.GetAllAuthors();
            return authors.Select(a=>new ReadAuthorDto { Id=a.Id,FullName=a.FullName});
        }
    }
}
