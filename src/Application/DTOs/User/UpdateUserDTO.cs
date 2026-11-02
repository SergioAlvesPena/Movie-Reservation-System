using System;

namespace Application.DTOs.User;

public class UpdateUserDTO
{
    public UpdateUserDTO(string name, string email, string password, string cpf)
    {
        Name = name;
        Email = email;
        Password = password;
        CPF = cpf;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CPF { get; set; }
}
