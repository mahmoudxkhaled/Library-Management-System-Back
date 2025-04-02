using LMS.BL.Dtos.Author;
using LMS.BL.Managers.Interfaces;
using LMS.BL.Shared.Models;
using LMS.DAL;
using LMS.DAL.Data;
using LMS.DAL.Data.Models;
using LMS.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Managers.Services
{
    public class AuthorService:IAuthorService
    {
        private IUnitOfWork unitOfWork;
        private IHelperService helperService;
        public AuthorService(IUnitOfWork _unitOfWork, IHelperService _helperService)
        {
            unitOfWork = _unitOfWork;   
            helperService = _helperService;
        }
        public async Task<IEnumerable<ReadAuthorDto>> GetAllAuthors()
        {
            IEnumerable<Author> authors=await unitOfWork.AuthorRepository.GetAllAuthors();
            return authors.Select(a=>new ReadAuthorDto { Id=a.Id,FullName=a.FullName});
        }
        public async Task<bool> checkAuthorHasBook(int id)
        {
            return await unitOfWork.AuthorRepository.checkAuthorHasBook(id);
        }
        public async Task<pagedResult<GetAuthorDto>> GetAllAuthors(int first, int rows, AuthorParams authorParams)
        {
            var authors = await unitOfWork.AuthorRepository.GetAllAuthors(first,rows,authorParams.sortOrder,authorParams.sortField,authorParams.Search,authorParams.isActive);
            return new pagedResult<GetAuthorDto> { TotalCount = authors.TotalCount, Result = authors.Result.Select(a => new GetAuthorDto { Id = a.Id, FullName = a.FullName, Description = a.Description,ImageURL=a.ImageUrl, DateOfBirth = a.DateOfBirth, IsActive = a.IsActive }).ToList() };
        }
        public async Task<int> DeleteAuthorById(int id, string userId)
        {
            var author = await unitOfWork.AuthorRepository.GetByIdAsync(id);
            if(author != null)
            {
                 await unitOfWork.AuthorRepository.DeleteAsync(author, userId);
                return 1;
            }
            return 0;
        }
        public async Task<ReadAuthorDto?> GetAuthorById(int id)
        {
            var author = await unitOfWork.AuthorRepository.GetByIdAsync(id);
            if (author == null)
                return null;
            return new ReadAuthorDto { Id=author.Id,FullName=author.FullName};
        }
        public async Task<ApiResult> ActivateOrDeactivateAuthor(int id)
        {
            try
            {

                var author = await unitOfWork.AuthorRepository.GetByIdAsync(id);
                if (author is null)
                    return new ApiResult { IsSuccess = false, Message = "author not found" };

                author.ActivationTime = DateTime.Now;
                author.IsActive = !author.IsActive;


                unitOfWork.AuthorRepository.Update(author);
                var result = await unitOfWork.SaveChangesAsync();
                return new ApiResult { IsSuccess = true, Message = $"author {(author.IsActive ? "activated" : "deactivated")} successfully", };

            }
            catch (Exception e)
            {
                return new ApiResult { IsSuccess = false, Message = e.Message };
            }
        }
        public async Task<ApiResult> CreateAuthor(CreateAuthorDto author, HttpContext httpContext,string UserId)
        {
            try
            {
                var newauthor = new Author() { FullName = author.fullName, Description = author.description, DateOfBirth = author.dateOfBirth, InsertedTime = DateTime.Now, IsActive = true,InsertedUserId=UserId,ActivationTime=DateTime.Now,ActivationUserId=UserId };
                if(author.imageUrl!=null)
                {
                    newauthor.ImageUrl = await helperService.SaveFileAsync(author.imageUrl,"Authors",httpContext);
                }
                await unitOfWork.AuthorRepository.AddAsync(newauthor);
                var effected = await unitOfWork.SaveChangesAsync();
                if(effected>0)
                     return new ApiResult { IsSuccess = true, Message = $"author Created successfully" };
                return new ApiResult { IsSuccess = false, Message = $"error in Create author" };
            }
            catch (Exception e)
            {
                return new ApiResult { IsSuccess = false, Message = e.Message };
            }
        }
        public async Task<ApiResult> UpdateAuthor(UpdateAuthorDto updateAuthorDto, HttpContext httpContext, string UserId)
        {
            try
            {
                var author = await unitOfWork.AuthorRepository.GetByIdAsync(updateAuthorDto.id);
                if (author is null)
                    return new ApiResult { IsSuccess = false, Message = $"author by {updateAuthorDto.id} not found" };
                author.Id = updateAuthorDto.id;
                author.FullName = updateAuthorDto.fullName;
                author.Description = updateAuthorDto.description;
                author.ImageUrl = updateAuthorDto.imageUrl is not null ? await helperService.SaveFileAsync(updateAuthorDto.imageUrl, "Authors", httpContext) : author.ImageUrl;
                author.DateOfBirth = updateAuthorDto.dateOfBirth;
                author.UpdateUserId = UserId;
                author.UpdateTime = DateTime.Now;
                if (updateAuthorDto.imageUrl != null)
                {
                    author.ImageUrl = await helperService.SaveFileAsync(updateAuthorDto.imageUrl, "Authors", httpContext);
                }
                unitOfWork.AuthorRepository.Update(author);
                var effected = await unitOfWork.SaveChangesAsync();
                if (effected > 0)
                    return new ApiResult { IsSuccess = true, Message = $"author Updated successfully" };
                return new ApiResult { IsSuccess = false, Message = $"error in Update author" };
            }
            catch (Exception e)
            {
                return new ApiResult { IsSuccess = false, Message = e.Message };
            }
        }

    }
}
