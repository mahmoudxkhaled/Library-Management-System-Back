using LMS.BL.Shared.Models;
using LMS.DAL;
namespace LMS.BL;

public class TrendingBooksService : ITrendingBooksService
{
    private readonly IUnitOfWork _unitOfWork;

    public TrendingBooksService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ApiResult> GetAllTrendingBooksAsync()
    {
        try
        {
            var trendingBooks = await _unitOfWork.TrendingBooksRepository.GetAllAsync();
            var trendingList = trendingBooks.Select(t => new GetTrendingBookDto
            {
                Id = t.Id,
                BookId = t.BookId,
                BorrowCount = t.BorrowCount
            }).OrderByDescending(i => i.BorrowCount).ToList();

            return new ApiResult { IsSuccess = true, Data = trendingList };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    public async Task<ApiResult> IncrementTrendingBookAsync(int bookId)
    {
        try
        {
            var trendingBook = await _unitOfWork.TrendingBooksRepository.GetByIdAsync(bookId);
            if (trendingBook == null)
            {
                trendingBook = new TrendingBook
                {
                    Id = Guid.NewGuid(),
                    BookId = bookId,
                    BorrowCount = 1
                };
                await _unitOfWork.TrendingBooksRepository.AddAsync(trendingBook);
            }
            else
            {
                trendingBook.BorrowCount++;
                _unitOfWork.TrendingBooksRepository.Update(trendingBook);
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
