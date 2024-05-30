namespace Domain.Configuration;

public class GalleryConfiguration
    : IEntityTypeConfiguration<GalleryEntity>
{
    public void Configure(EntityTypeBuilder<GalleryEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasIndex(x => x.Name)
            .IsUnique();

        builder.HasData(new List<GalleryEntity>
        {
            new()
            {
                Id = 1,
                Name = "Работа 1",
                PicturePath = "Files//Images//GalleryPictures//1.jpg",
            },
            new()
            {
                Id = 2,
                Name = "Работа 2",
                PicturePath = "Files//Images//GalleryPictures//2.jpg",
            },
            new()
            {
                Id = 3,
                Name = "Работа 3",
                PicturePath = "Files//Images//GalleryPictures//3.jpg",
            },
            new()
            {
                Id = 4,
                Name = "Работа 4",
                PicturePath = "Files//Images//GalleryPictures//4.jpg",
            },
            new()
            {
                Id = 5,
                Name = "Работа 5",
                PicturePath = "Files//Images//GalleryPictures//5.jpg",
            },
            new()
            {
                Id = 6,
                Name = "Работа 6",
                PicturePath = "Files//Images//GalleryPictures//6.jpg",
            },
            new()
            {
                Id = 7,
                Name = "Работа 7",
                PicturePath = "Files//Images//GalleryPictures//7.jpg",
            },
            new()
            {
                Id = 8,
                Name = "Работа 8",
                PicturePath = "Files//Images//GalleryPictures//8.jpg",
            },
            new()
            {
                Id = 9,
                Name = "Работа 9",
                PicturePath = "Files//Images//GalleryPictures//9.jpg",
            }
        });
    }
}