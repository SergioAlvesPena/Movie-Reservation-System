using System;
using Application.DTOs.User;

namespace Application.Interfaces;

public interface IUserService
{
    public Task<Guid> CreateUserAsync(CreateUserDTO createUserDTO);
    public Task<UserResponseDTO> GetUserByIdAsync(Guid id);
    public Task<IEnumerable<UserResponseDTO>> GetAllUsersAsync();
    public Task UpdateUserAsync(Guid id, UpdateUserDTO updateUserDTO);
    public Task DeleteUserAsync(Guid id);
}
