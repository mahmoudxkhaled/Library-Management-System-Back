using LMS.BL.Shared.Models;

namespace LMS.BL
{
    public interface IUserService
    {
        Task<ApiResult> GetAllUsersAsync();
        Task<ApiResult> RegisterUserAsync(UserRegisterDto registerCredientials);
        Task<ApiResult> LoginAsync(UserLoginDto loginCredientials);
    }
}
