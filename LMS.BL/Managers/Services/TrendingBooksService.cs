using LMS.BL.Shared.Models;
using LMS.DAL;
using LMS.DAL.Data;
namespace LMS.BL;

public class TrendingBooksService : ITrendingBooksService
{
    private readonly IUnitOfWork _unitOfWork;

    public TrendingBooksService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ApiResult<pagedResult<GetBookDto>>> GetAllTrendingBooksAsync(int first, int rows, int sortOrder, string? sortField, string? Search, int? categoryId, int? authorId)

    {
        try
        {
            // Fetch all trending books with their authors included

            pagedResult<GetBookDto> pagedResultDto = new pagedResult<GetBookDto>();
            var trendingbooks = await _unitOfWork.BookRepository.GetWhereIncludeAsync(b => b.IsTrending, "Author");
            var topBorrowIds = await _unitOfWork.TransactionRepository.GetTopBorrowedBooksAsync(20);

            var trendingBookIds = trendingbooks.Select(b => b.Id).ToList();
            topBorrowIds = topBorrowIds.Where(id => !trendingBookIds.Contains(id)).ToList();


            trendingbooks = trendingbooks.Take(20);
            var topBooksCount = 20 - trendingbooks.Count();
            if (topBooksCount > 0)
            {
                var topBorrowBooks = await _unitOfWork.BookRepository.GetWhereIncludeAsync(b => topBorrowIds.Contains(b.Id), "Author");
                trendingbooks = trendingbooks.Concat(topBorrowBooks.Take(topBooksCount)).ToList();
            }



            var bookList = trendingbooks.Select(b => new GetBookDto
            {
                Id = b.Id,
                Title = b.Title,
                Description = b.Description,
                AuthorName = b.Author.FullName,
                PublicationYear = b.PublicationYear,
                AvailableCopies = b.AvailableCopies,
                TotalCopies = b.TotalCopies,
                CategoryId = b.CategoryId,
                ImageUrl = b.ImageUrl,
                authorId = b.AuthorId
            }).ToList();
            var totalcount = bookList.Count;
            bookList = bookList.Skip(first).Take(rows).ToList();


            pagedResultDto.Result = bookList;
            pagedResultDto.TotalCount = totalcount;
            return new ApiResult<pagedResult<GetBookDto>> { IsSuccess = true, Data = pagedResultDto };

        }
        catch (Exception ex)
        {
            return new ApiResult<pagedResult<GetBookDto>> { IsSuccess = false, Message = ex.Message };
        }

    }

    public async Task<ApiResult> SetTrendingBookAsync(int bookId)


    {
        try
        {
            var trendingBook = await _unitOfWork.BookRepository.GetByIdAsync(bookId);
            if (trendingBook == null)
            {
                return new ApiResult { IsSuccess = false, Message = "Invalid book", Data = null };

            }
            else
            {
                trendingBook.IsTrending = true;
            }

            await _unitOfWork.SaveChangesAsync();
            return new ApiResult { IsSuccess = true, Message = "Trending book updated successfully", Data = trendingBook };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }


}
