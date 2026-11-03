using System;
using Application.DTOs.User;
using Domain.Entities;

namespace Application.Interfaces;

public interface IUserRepository
{
    public Task<Guid> CreateUserAsync(User createUserDTO);
    public Task<User> GetUserByIdAsync(Guid id);
    public Task<IEnumerable<User>> GetAllUsersAsync();
    public Task UpdateUserAsync(Guid id, User updateUserDTO);
    public Task DeleteUserAsync(Guid id);
}
