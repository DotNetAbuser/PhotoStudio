namespace Server.Contollers;

[ApiController]
[Route("api/identity/token")]
public class TokenController(
    ITokenService tokenService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SignInAsync(SignInRequest request)
    {
        return Ok(await tokenService.SignInAsync(request));
    }

    [HttpPost("refresh")]
    public async Task<IActionResult> RefreshTokenAsync(RefreshTokenRequest request)
    {
        return Ok(await tokenService.RefreshTokenAsync(request));
    }
}