using Domain.Entities;

namespace Application.IRepositories;

public interface IUserRepository
{
    Task<bool> IsExistByEmailAsync(string email);
    Task<bool> IsExistByPhoneNumber(string phoneNumber);
    Task CreateAsync(UserEntity entity);
    Task<UserEntity?> GetByPhoneNumberWithRoleAsync(string phoneNumber);
    Task<UserEntity?> GetByIdWithRoleAsync(Guid userId);
}