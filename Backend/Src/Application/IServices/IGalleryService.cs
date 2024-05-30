namespace Application.IServices;

public interface IGalleryService
{
    Task<Result<IEnumerable<GalleryResponse>>> GetAllAsync();
}