namespace Infrastructure.Managers;

public interface IGalleryManager
{
    Task<IResult<IEnumerable<GalleryResponse>>> GetAllAsync();
}

public class GalleryManager(
    IHttpClientFactory factory)
    : IGalleryManager
{
    public async Task<IResult<IEnumerable<GalleryResponse>>> GetAllAsync()
    {
        var response = await factory.CreateClient(ApplicationConstants.BaseClientName)
            .GetAsync(GalleryRoutes.GetAll);
        return await response.ToResultAsync<IEnumerable<GalleryResponse>>();
    }
}