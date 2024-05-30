namespace Infrastructure.Repositories;

public class GalleryRepository(
    ApplicationDbContext dbContext)
    : IGalleryRepository
{
    public async Task<IEnumerable<GalleryEntity>> GetAllAsync()
    {
        return await dbContext.Galleries
            .AsNoTracking()
            .ToListAsync();
    }
}