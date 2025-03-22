using Azure.Core;
using LMS.BL.Dtos.Book;
using LMS.BL.Shared.Models;
using LMS.DAL;
using LMS.DAL.Data;
using Microsoft.AspNetCore.Http;
namespace LMS.BL;

public class BookService : IBookService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHelperService _helperService;
    private readonly ICurrentUserService _currentUserService;

    public BookService(
        IUnitOfWork unitOfWork,
        IHelperService helperService,
        ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _helperService = helperService;
        _currentUserService = currentUserService;

    }

    public async Task<ApiResult<List<GetBookDto>>> GetAllBooksAsync()
    {
        try
        {
            var books = await _unitOfWork.BookRepository.GetAllAsync();
            var bookList = books.Select(b => new GetBookDto
            {
                Id = b.Id,
                Title = b.Title,
                Description = b.Description,
                Author = b.Author,
                PublicationYear = b.PublicationYear,
                AvailableCopies = b.AvailableCopies,
                TotalCopies = b.TotalCopies,
                CategoryId = b.CategoryId,
                ImageUrl = b.ImageUrl,
            }).ToList();

            return new ApiResult<List<GetBookDto>> { IsSuccess = true, Data = bookList };
        }
        catch (Exception ex)
        {
            return new ApiResult<List<GetBookDto>> { IsSuccess = false, Message = ex.Message };
        }
    }
    public async Task<ApiResult<pagedResult<ReadBookDto>>> GetBooksPaged(int first, int rows, int sort, string Search)
    {
        try
        {
            pagedResult<ReadBookDto> pagedResultDto= new pagedResult<ReadBookDto>();
            var pagedResult = await _unitOfWork.BookRepository.GetBooksPaged(first,rows,sort,Search);
            pagedResultDto.Result = pagedResult.Result.Select( b=>new ReadBookDto() {Id=b.Id,Title=b.Title,ImageUrl=b.ImageUrl,Author=b.Author,AvailableCopies=b.AvailableCopies,CategoryId=b.CategoryId,PublicationYear=b.PublicationYear,TotalCopies=b.TotalCopies }).ToList();
            pagedResultDto.TotalCount = pagedResult.TotalCount;
            return new ApiResult<pagedResult<ReadBookDto>> { IsSuccess=true,Data=pagedResultDto };
        }
        catch(Exception ex)
        {
            return new ApiResult<pagedResult<ReadBookDto>> { IsSuccess = false, Message = ex.Message };
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
                    Description = book.Description,
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
                Title = request.Title,
                Description = request.Description,
                Author = request.Author,
                PublicationYear = request.PublicationYear,
                AvailableCopies = request.AvailableCopies,
                TotalCopies = request.TotalCopies,
                CategoryId = request.CategoryId,
                InsertedUserId = _currentUserService.UserId,
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
            book.Description = request.Description ?? book.Description;
            book.Author = request.Author ?? book.Author;
            book.PublicationYear = request.PublicationYear;
            book.AvailableCopies = request.AvailableCopies;
            book.TotalCopies = request.TotalCopies;
            book.CategoryId = request.CategoryId;
            book.ImageUrl = request.ImageUrl is not null ? await _helperService.SaveFileAsync(request.ImageUrl, "Books", httpContext) : book.ImageUrl;
            book.UpdateUserId = _currentUserService.UserId;
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

            await _unitOfWork.BookRepository.DeleteAsync(book, _currentUserService.UserId!);
            return new ApiResult { IsSuccess = true, Message = "Book marked as deleted" };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> ActivateOrDeactivateBookAsync(string id)
    {
        try
        {

            var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
            if (book is null)
                return new ApiResult { IsSuccess = false, Message = "Book not found" };

            book.ActivationTime = DateTime.Now;
            book.IsActive = !book.IsActive;


            _unitOfWork.BookRepository.Update(book);
            var result = await _unitOfWork.SaveChangesAsync();
            return new ApiResult { IsSuccess = true, Message = $"Book {(book.IsActive ? "activated" : "deactivated")} successfully", };

        }
        catch (Exception e)
        {
            return new ApiResult { IsSuccess = false, Message = e.Message };
        }
    }
}
