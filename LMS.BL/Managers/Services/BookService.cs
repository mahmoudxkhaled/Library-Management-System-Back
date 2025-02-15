using LMS.BL.Shared.Models;
using LMS.DAL;
using Microsoft.AspNetCore.Http;

namespace LMS.BL
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHelperService _helperService;

        public BookService(IUnitOfWork unitOfWork, IHelperService helperService)
        {
            _unitOfWork = unitOfWork;
            _helperService = helperService;
        }

        public async Task<ApiResult> GetAllBooksAsync()
        {
            try
            {
                var books = await _unitOfWork.BookRepository.GetAllAsync();
                var bookList = books.Select(b => new GetBookDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    PublicationYear = b.PublicationYear,
                    AvailableCopies = b.AvailableCopies,
                    TotalCopies = b.TotalCopies,
                    CategoryId = b.CategoryId,
                    ImageUrl = b.ImageUrl,
                }).ToList();

                return new ApiResult { IsSuccess = true, Data = bookList };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> GetBookByIdAsync(string id)
        {
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
                if (book == null)
                    return new ApiResult { IsSuccess = false, Message = "Book not found" };

                return new ApiResult
                {
                    IsSuccess = true,
                    Data = new GetBookDto
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                        PublicationYear = book.PublicationYear,
                        AvailableCopies = book.AvailableCopies,
                        TotalCopies = book.TotalCopies,
                        CategoryId = book.CategoryId,
                        ImageUrl = book.ImageUrl,
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> AddBookAsync(AddBookDto request, HttpContext httpContext)
        {
            try
            {
                var book = new Book
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = request.Title,
                    Author = request.Author,
                    PublicationYear = request.PublicationYear,
                    AvailableCopies = request.AvailableCopies,
                    TotalCopies = request.TotalCopies,
                    CategoryId = request.CategoryId,
                    InsertedTime = DateTime.Now
                };
                if (request.ImageUrl is not null)
                {
                    book.ImageUrl = await _helperService.SaveFileAsync(request.ImageUrl, "Books", httpContext);
                }

                await _unitOfWork.BookRepository.AddAsync(book);
                await _unitOfWork.SaveChangesAsync();
                return new ApiResult { IsSuccess = true, Message = "Book created successfully", Data = book };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> UpdateBookAsync(UpdateBookDto request, HttpContext httpContext)
        {
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(request.Id);
                if (book == null)
                    return new ApiResult { IsSuccess = false, Message = "Book not found" };

                book.Title = request.Title ?? book.Title;
                book.Author = request.Author ?? book.Author;
                book.PublicationYear = request.PublicationYear;
                book.AvailableCopies = request.AvailableCopies;
                book.TotalCopies = request.TotalCopies;
                book.CategoryId = request.CategoryId ?? book.CategoryId;
                book.ImageUrl = request.ImageUrl is not null ? await _helperService.SaveFileAsync(request.ImageUrl, "Books", httpContext) : book.ImageUrl;
                book.UpdateTime = DateTime.Now;

                _unitOfWork.BookRepository.Update(book);
                await _unitOfWork.SaveChangesAsync();
                return new ApiResult { IsSuccess = true, Message = "Book updated successfully", Data = book };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult> DeleteBookAsync(string bookId)
        {
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(bookId);
                if (book == null)
                    return new ApiResult { IsSuccess = false, Message = "Book not found" };

                //await _unitOfWork.BookRepository.DeleteAsync(book, userId);
                return new ApiResult { IsSuccess = true, Message = "Book marked as deleted" };
            }
            catch (Exception ex)
            {
                return new ApiResult { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
