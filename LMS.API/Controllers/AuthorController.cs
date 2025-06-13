using LMS.BL.Dtos.Author;
using LMS.BL.Managers.Interfaces;
using LMS.BL.Shared.Models;
using LMS.DAL.Data;
using Microsoft.AspNetCore.Authorization;
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
            _authorService = authorService;
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
        [HttpPost("{first}/{rows}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<ApiResult>> GettAllAuthorsPaged(int first, int rows, AuthorParams authorParams)
        {
            try
            {
                pagedResult<GetAuthorDto> authors = await _authorService.GetAllAuthors(first, rows, authorParams);
                if (authors.Result != null)
                {
                    for (int i = 0; i < authors.Result.Count; i++)
                    {
                        if (authors.Result[i].ImageURL != null)
                        {
                            authors.Result[i].ImageURL = $"{Request.Scheme}://{Request.Host}/{authors.Result[i].ImageURL}";
                        }
                    };
                }
                return Ok(new ApiResult { IsSuccess = true, Data = authors });
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<ApiResult>> DeleteAuthorById(int id)
        {
            try
            {
                var author = await _authorService.GetAuthorById(id);
                if (author == null)
                {
                    return NotFound(new ApiResult { IsSuccess = false, Data = $"not found author by {id}" });
                }

                var hasBooks = await _authorService.checkAuthorHasBook(id);
                if (hasBooks)
                {
                    return BadRequest(new ApiResult { IsSuccess = false, Message = $"This author cannot be deleted because it has books associated with it" });
                }

                var UserId = User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (UserId == null)
                {
                    return Unauthorized(new ApiResult { IsSuccess = false });
                }

                var deleted = await _authorService.DeleteAuthorById(id, UserId);
                return Ok(new ApiResult { IsSuccess = true });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResult { IsSuccess = false, Message = ex.Message });
            }
        }

        [HttpPut("ActivateOrDeactivateAuthor/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ActivateOrDeactivateAuthor(int id)
        {
            var result = await _authorService.ActivateOrDeactivateAuthor(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAuthor(CreateAuthorDto createAuthorDto)
        {
            var UserId = User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (UserId == null)
            {
                return Unauthorized(new ApiResult { IsSuccess = false });
            }

            var result = await _authorService.CreateAuthor(createAuthorDto, HttpContext, UserId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorDto updateAuthorDto)
        {
            var UserId = User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (UserId == null)
            {
                return Unauthorized(new ApiResult { IsSuccess = false });
            }

            var result = await _authorService.UpdateAuthor(updateAuthorDto, HttpContext, UserId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}

