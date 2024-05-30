namespace Domain.Configuration;

public class UserConfiguration 
    : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasIndex(x => x.Email)
            .IsUnique();
        builder
            .HasIndex(x => x.PhoneNumber)
            .IsUnique();

        builder
            .HasOne(x => x.Role)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.RoleId);
        builder
            .HasMany(x => x.Sessions)
            .WithOne(x => x.User);
        
        builder.HasData(new List<UserEntity>
        {
            new()
            {
                Id = Guid.NewGuid(),
                RoleId = (int)Role.Guest,
                LastName = "Хасипов",
                FirstName = "Самат",
                MiddleName = "Гость",
                Email = "samatguest@gmail.com",
                PhoneNumber = "+791234567890",
                PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword("qwerty123"),
            },
            new()
            {
                Id = Guid.NewGuid(),
                RoleId = (int)Role.Operator,
                LastName = "Устюшкин",
                FirstName = "Даниил",
                MiddleName = "Оператор",
                Email = "samatoperator@gmail.com",
                PhoneNumber = "+791234567891",
                PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword("qwerty123"),
            },
            new()
            {
                Id = Guid.NewGuid(),
                RoleId = (int)Role.Admin,
                LastName = "Устюшкин",
                FirstName = "Даниил",
                MiddleName = "Админ",
                Email = "samatadmin@gmail.com",
                PhoneNumber = "+791234567892",
                PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword("qwerty123"),
            }
        });
    }
}