using LMS.BL;
using LMS.BL.Dtos.User;
using LMS.BL.Shared.Models;
using Microsoft.AspNetCore.Authorization;
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
    [AllowAnonymous]
    public async Task<IActionResult> Login(UserLoginDto loginCredentials)
    {
        var result = await _userService.LoginAsync(loginCredentials);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] UserRegisterDto registerCredentials)
    {
        var result = await _userService.RegisterUserAsync(registerCredentials);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetAllUsers")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _userService.GetAllUsersAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetAllRoles")]

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllRoles()
    {
        var result = await _userService.GetAllRolesAsync();
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddRoleToUser")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddRoleToUser([FromBody] UserRoleDto request)
    {
        var result = await _userService.AddRoleToUserAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("RemoveRoleFromUser")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> RemoveRoleFromUser([FromBody] UserRoleDto request)
    {
        var result = await _userService.RemoveRoleFromUserAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("ActivateDeactivateUser")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> ToggleUserActivation([FromBody] ToggleUserActivationDto request)
    {
        var result = await _userService.ActivateDeactivateUserAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddUserWithDefaultPassword")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddUser([FromBody] AddUserDto request)
    {
        var result = await _userService.AddUserAsync(request);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }

}
