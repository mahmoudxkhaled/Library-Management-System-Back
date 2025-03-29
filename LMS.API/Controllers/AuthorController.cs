using LMS.BL.Dtos.Author;
using LMS.BL.Managers.Interfaces;
using LMS.BL.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService= authorService;
        }
        [HttpGet]
        public async Task<ActionResult<ApiResult>> GetAllAuthors() 
        {
            try
            {
                var authors = await _authorService.GetAllAuthors();
                return Ok(new ApiResult { IsSuccess = true, Data = authors });
            }
            catch (Exception ex) 
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
         
        }
    }
}
