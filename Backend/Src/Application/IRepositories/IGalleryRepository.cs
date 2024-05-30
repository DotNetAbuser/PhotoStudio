namespace Application.IRepositories;

public interface IGalleryRepository
{
    Task<IEnumerable<GalleryEntity>> GetAllAsync();
}