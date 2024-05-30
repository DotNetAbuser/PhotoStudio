namespace Shared.Enums;

public enum UploadType : byte
{
    [Description(@"Images\ProfilePictures")]
    ProfilePicture = 1,
    
    [Description(@"Images\GalleryPictures")]
    GalleryPicture = 2,
    
    [Description(@"Images\ScenePictures")]
    ScenePicture = 3
}