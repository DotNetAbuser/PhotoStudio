namespace Infrastructure.Services;

public class GalleryService(
    IGalleryRepository galleryRepository)
    : IGalleryService
{
    public async Task<Result<IEnumerable<GalleryResponse>>> GetAllAsync()
    {
        var galleriesEntities = await galleryRepository.GetAllAsync();
        var galleriesResponse = galleriesEntities.Select(galleryEntity => new GalleryResponse(
            Id: galleryEntity.Id,
            Name: galleryEntity.Name,
            PicturePath: galleryEntity.PicturePath)).ToList();
        return Result<IEnumerable<GalleryResponse>>.Success(galleriesResponse, "Картинки из галиреи успешно получены.");
    }
}