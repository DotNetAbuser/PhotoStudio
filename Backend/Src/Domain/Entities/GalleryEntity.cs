namespace Domain.Entities;

public class GalleryEntity
    : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string PicturePath { get; set; } = string.Empty; 
}