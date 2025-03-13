using LMS.BL.Dtos.User;
using LMS.BL.Shared.Models;
using System.Threading.Tasks;

namespace LMS.BL
{
    public interface IUserService
    {
        Task<ApiResult> GetAllUsersAsync();
        Task<ApiResult> RegisterUserAsync(UserRegisterDto registerCredientials);
        Task<ApiResult> LoginAsync(UserLoginDto loginCredientials);
        Task<ApiResult> GetAllRolesAsync();
        Task<ApiResult> AddRoleToUserAsync(UserRoleDto updateUserRoleDto);
        Task<ApiResult> RemoveRoleFromUserAsync(UserRoleDto updateUserRoleDto);
        Task<ApiResult> ActivateDeactivateUserAsync(ToggleUserActivationDto updateUserStatusDto);
        Task<ApiResult> AddUserAsync(AddUserDto userDto);
    }
}
