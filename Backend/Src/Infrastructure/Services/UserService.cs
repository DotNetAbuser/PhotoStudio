﻿using Domain.Enums;

namespace Infrastructure.Services;

public class UserService(
    IUserRepository userRepository)
    : IUserService
{
    public async Task<Result> CreateAsync(SignUpRequest request)
    {
        var isExistByEmail = await userRepository
            .IsExistByEmailAsync(request.Email);
        if (isExistByEmail)
            return Result<string>.Fail("Пользователь с данной почтой уже существует!");

        var isExistByPhoneNumber = await userRepository
            .IsExistByPhoneNumber(request.PhoneNumber);
        if (isExistByPhoneNumber)
            return Result<string>.Fail("Пользователь с данным номером телефона уже сущетсвует!");

        var userEntity = new UserEntity
        {
            RoleId = (int)Role.Guest,
            LastName = request.LastName,
            FirstName = request.FirstName,
            MiddleName = request.MiddleName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            PasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(request.Password)
        };
        await userRepository.CreateAsync(userEntity);
        return Result<string>.Success("Пользователь успешно зарегистрирован.");
    }
}