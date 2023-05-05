using HR.LeaveManagement.Application.Contracts.Identity;
using HR.LeaveManagement.Application.Models.Identity;

using Microsoft.AspNetCore.Mvc;

namespace HR.LeaveManagement.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthController(IAuthService authenticationService) => _authenticationService = authenticationService;

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponse>> Login(AuthRequest request) => Ok(await _authenticationService.Login(request));

    [HttpPost("register")]
    public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request) => Ok(await _authenticationService.Register(request));
}
