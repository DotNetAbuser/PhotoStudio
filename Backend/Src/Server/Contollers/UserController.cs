namespace Server.Contollers;

[ApiController]
[Route("api/identity/user")]
public class UserController(
    IUserService userService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SignUpAsync(SignUpRequest request)
    {
        return Ok(await userService.CreateAsync(request));
    }
}