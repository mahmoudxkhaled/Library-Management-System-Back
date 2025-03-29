using LMS.DAL.Data.Models;
using LMS.DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Repos.Services
{
    public class AuthorRepository: GenericRepository<Author>, IAuthorRepository
    {
        #region Fileds & Properities

        private readonly LMSDbContext _context;

        #endregion

        #region Construcors

        public AuthorRepository(LMSDbContext context) : base(context)
        {
            _context = context;
        }

        #endregion

        #region Functions
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
           return await _context.Authors.Select(a => new Author {Id= a.Id,FullName=a.FullName}).ToListAsync();
        }





        #endregion

    }
}
