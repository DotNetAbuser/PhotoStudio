namespace Server.Contollers;

[ApiController]
[Route("api/gallery")]
public class GalleryController(
    IGalleryService galleryService)
    : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await galleryService.GetAllAsync());
    }
}