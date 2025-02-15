using LMS.BL;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(UserLoginDto loginCredentials)
    {
        var result = await _userService.LoginAsync(loginCredentials);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }



    [HttpPost("Register")]
    public async Task<IActionResult> Register(UserRegisterDto registerCredentials)
    {
        var result = await _userService.RegisterUserAsync(registerCredentials);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }


    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _userService.GetAllUsersAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
