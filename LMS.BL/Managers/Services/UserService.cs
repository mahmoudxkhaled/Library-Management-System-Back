using LMS.BL.Shared.Models;
using LMS.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LMS.BL;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IEncryptionService _encryptionService;
    private readonly IConfiguration _configuration;
    private readonly UserManager<User> _manager;

    public UserService(
        IUnitOfWork unitOfWork,
        IEncryptionService encryptionService,
        IConfiguration configuration,
         UserManager<User> manager)
    {
        _unitOfWork = unitOfWork;
        _encryptionService = encryptionService;
        _configuration = configuration;
        _manager = manager;
    }

    public async Task<ApiResult> RegisterUserAsync(UserRegisterDto registerCredientials)
    {
        try
        {
            if (registerCredientials is null)
                return new ApiResult { Message = "Invalid Date Provided!!!", IsSuccess = false, };

            User user = new()
            {
                Id = Guid.NewGuid().ToString(),
                Email = registerCredientials.Email.Trim(),
                FirstName = registerCredientials.FirstName.Trim(),
                LastName = registerCredientials.LastName.Trim(),
                UserName = registerCredientials.Email,
                PhoneNumber = registerCredientials.PhoneNumber,
                Role = Roles.Member.ToString(),
                InsertedTime = DateTime.Now,
                IsActive = true,
            };

            await _unitOfWork.UserRepository.AddAsync(user);

            var createUserResult = await _manager.CreateAsync(user, registerCredientials.Password);
            if (!createUserResult.Succeeded)
                return new ApiResult { ErrorList = createUserResult.Errors.Select(x => new ApiError { Key = x.Code, Message = x.Description }).ToList(), IsSuccess = false, };

            List<Claim> claims = new()
            {
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                 new Claim(ClaimTypes.Email, user.Email.ToString()),
                 new Claim(ClaimTypes.Role, user.Role.ToString()),
            };

            var claimsResult = await _manager.AddClaimsAsync(user, claims);
            if (!claimsResult.Succeeded)
                return new ApiResult { ErrorList = claimsResult.Errors.Select(x => new ApiError { Key = x.Code, Message = x.Description }).ToList(), IsSuccess = false, };

            await _unitOfWork.SaveChangesAsync();
            return new ApiResult
            {
                Message = "Register Successfully",
                IsSuccess = true,
                Data = new GetUserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    ProfileImageUrl = user.ProfileImageUrl,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Role = user.Role,
                    PhoneNumber = user.PhoneNumber,
                }
            };
        }
        catch (Exception ex)
        {
            return new ApiResult { Message = ex.Message, IsSuccess = false, };
        }
    }
    public async Task<ApiResult> LoginAsync(UserLoginDto loginCredentials)
    {
        try
        {
            if (loginCredentials is null)
                return new ApiResult { Message = "invalid credentials!!!", IsSuccess = false, };

            User? _user = await _manager.FindByEmailAsync(loginCredentials.Email);
            if (_user is null)
                return new ApiResult { Message = "invalid credentials!!!", IsSuccess = false, };

            if (!_user.IsActive)
                return new ApiResult { Message = "User Not Active", IsSuccess = false, };


            bool _isValiduser = await _manager.CheckPasswordAsync(_user, loginCredentials.Password);
            if (!_isValiduser)
                return new ApiResult { Message = "invalid credentials", IsSuccess = false, };

            // Get claims
            var _claims = await _manager.GetClaimsAsync(_user);
            if (_claims is null || _claims.Count == 0)
                return new ApiResult { Message = "invalid credentials", IsSuccess = true, };

            var _token = GenerateUserTokenAsync(_claims);

            return new ApiResult
            {
                Message = "User Logged in Successfully",
                IsSuccess = true,
                Data = new TokenDto
                {
                    UserId = _user.Id,
                    Email = _user.Email!,
                    FirstName = _user.FirstName,
                    LastName = _user.LastName,
                    UserImageUrl = _user.ProfileImageUrl,
                    ExpiresIn = _token.Expires,
                    Token = _token.Token,
                },
            };
        }
        catch (Exception ex)
        {
            return new ApiResult { Message = ex.Message, IsSuccess = false, };
        }
    }

    public async Task<ApiResult> GetAllUsersAsync()
    {
        try
        {
            var users = (await _unitOfWork.UserRepository.GetAllAsync()).Select(u => new GetUserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Role = u.Role,
                PhoneNumber = u.PhoneNumber,
                ProfileImageUrl = u.ProfileImageUrl
            }).ToList();

            return new ApiResult { IsSuccess = true, Data = users };
        }
        catch (Exception ex)
        {
            return new ApiResult { IsSuccess = false, Message = ex.Message };
        }
    }

    private (string Token, long Expires) GenerateUserTokenAsync(IList<Claim> claims)
    {
        string? secretKey = _configuration.GetSection("SecretKey").Value;
        byte[] keyAsBytes = Encoding.ASCII.GetBytes(secretKey!);
        SymmetricSecurityKey key = new(keyAsBytes);

        SigningCredentials signingCredentials = new(key, SecurityAlgorithms.HmacSha256Signature);

        DateTime exp = DateTime.Now.AddMinutes(1000);
        DateTimeOffset dateTimeOffset = new DateTimeOffset(exp);
        var expires = dateTimeOffset.ToUnixTimeSeconds();
        JwtSecurityToken jwtSecurity = new(claims: claims, signingCredentials: signingCredentials, expires: exp);

        JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
        return (jwtSecurityTokenHandler.WriteToken(jwtSecurity), expires);
    }


}
