﻿namespace Infrastructure.Repositories;

public class UserRepository(
    ApplicationDbContext dbContext)
    : IUserRepository
{
    public async Task<UserEntity?> GetByPhoneNumberWithRoleAsync(string phoneNumber)
    {
        return await dbContext.Users
            .AsNoTracking()
            .Include(x => x.Role)
            .SingleOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
    }

    public async Task<UserEntity?> GetByIdWithRoleAsync(Guid userId)
    {
        return await dbContext.Users
            .AsNoTracking()
            .Include(x => x.Role)
            .SingleOrDefaultAsync(x => x.Id == userId);
    }
    
    public async Task<bool> IsExistByEmailAsync(string email)
    {
        return await dbContext.Users
            .AsNoTracking()
            .AnyAsync(x => x.Email == email);
    }

    public async Task<bool> IsExistByPhoneNumber(string phoneNumber)
    {
        return await dbContext.Users
            .AsNoTracking()
            .AnyAsync(x => x.PhoneNumber == phoneNumber);
    }

    public async Task CreateAsync(UserEntity entity)
    {
        await dbContext.Users.AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }
}