using LMS.BL.Shared.Models;
using LMS.DAL;
using Microsoft.AspNetCore.Http;

namespace LMS.BL
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHelperService _helperService;

        public CategoryService(IUnitOfWork unitOfWork, IHelperService helperService)
        {
            _unitOfWork = unitOfWork;
            _helperService = helperService;

        }

        public async Task<ApiResult> GetAllCategoriesAsync()
        {
            try
            {
                var categories = await _unitOfWork.CategoryRepository.GetAllAsync();
                var categoryList = categories.Select(c => new GetCategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                }).ToList();

                return new ApiResult { IsSuccess = true, Data = categoryList };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> GetCategoryByIdAsync(string id)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
                if (category == null)
                    return new ApiResult { IsSuccess = false, Message = "Category not found" };

                return new ApiResult
                {
                    IsSuccess = true,
                    Data = new GetCategoryDto
                    {
                        Id = category.Id,
                        Name = category.Name,
                        ImageUrl = category.ImageUrl
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> AddCategoryAsync(AddCategoryDto request, HttpContext httpContext)
        {
            try
            {
                var category = new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = request.Name,
                    InsertedTime = DateTime.Now
                };
                if (request.ImageUrl is not null)
                {
                    category.ImageUrl = await _helperService.SaveFileAsync(request.ImageUrl, "Categories", httpContext);
                }

                await _unitOfWork.CategoryRepository.AddAsync(category);
                await _unitOfWork.SaveChangesAsync();
                return new ApiResult { IsSuccess = true, Message = "Category created successfully", Data = category };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> UpdateCategoryAsync(UpdateCategoryDto request, HttpContext httpContext)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(request.Id);
                if (category == null)
                    return new ApiResult { IsSuccess = false, Message = "Category not found" };

                category.Name = request.Name ?? category.Name;
                category.ImageUrl = request.ImageUrl is not null ? await _helperService.SaveFileAsync(request.ImageUrl, "Books", httpContext) : category.ImageUrl;

                category.UpdateTime = DateTime.Now;

                _unitOfWork.CategoryRepository.Update(category);
                await _unitOfWork.SaveChangesAsync();
                return new ApiResult { IsSuccess = true, Message = "Category updated successfully", Data = category };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> DeleteCategoryAsync(string id)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
                if (category == null)
                    return new ApiResult { IsSuccess = false, Message = "Category not found" };

                //await _unitOfWork.CategoryRepository.DeleteAsync(category, userId);
                return new ApiResult { IsSuccess = true, Message = "Category marked as deleted" };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
