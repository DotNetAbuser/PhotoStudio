namespace Infrastructure.Managers;

public interface IUserManager
{
    Task<IResult> CreateAsync(SignUpRequest request);
}

public class UserManager(
    IHttpClientFactory factory)
    : IUserManager
{
    public async Task<IResult> CreateAsync(SignUpRequest request)
    {
        var response = await factory.CreateClient(ApplicationConstants.BaseClientName)
            .PostAsJsonAsync(UserRoutes.SignUp, request);
        return await response.ToResultAsync();
    }
}