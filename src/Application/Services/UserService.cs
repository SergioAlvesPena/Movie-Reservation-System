using System;
using Application.DTOs.User;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    public async Task<Guid> CreateUserAsync(CreateUserDTO createUserDTO)
    {
        ArgumentNullException.ThrowIfNull(createUserDTO);

        var user = new User(
            createUserDTO.Name,
            createUserDTO.Email,
            createUserDTO.Password,
            createUserDTO.CPF);

        return await _userRepository.CreateUserAsync(user);
    }

    public async Task DeleteUserAsync(Guid id)
    {
        await _userRepository.DeleteUserAsync(id);
    }

    public async Task<IEnumerable<UserResponseDTO>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllUsersAsync();
        return users.Select(MapToResponse);
    }

    public async Task<UserResponseDTO> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user is null)
        {
            throw new KeyNotFoundException($"Usuário com o id '{id}' não foi encontrado.");
        }

        return MapToResponse(user);
    }

    public async Task UpdateUserAsync(Guid id, UpdateUserDTO updateUserDTO)
    {
        ArgumentNullException.ThrowIfNull(updateUserDTO);

        var user = new User(
            updateUserDTO.Name,
            updateUserDTO.Email,
            updateUserDTO.Password,
            updateUserDTO.CPF);

        await _userRepository.UpdateUserAsync(id, user);
    }

    private static UserResponseDTO MapToResponse(User user)
    {
        return new UserResponseDTO(user.Name, user.Email, user.CPF)
        {
            Password = user.Password
        };
    }
}
