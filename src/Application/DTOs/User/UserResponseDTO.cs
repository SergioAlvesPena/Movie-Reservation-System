using System;

namespace Application.DTOs.User;

public class UserResponseDTO
{
    public UserResponseDTO(string name, string email, string cpf)
    {
        Name = name;
        Email = email;
        CPF = cpf;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CPF { get; set; }
}
