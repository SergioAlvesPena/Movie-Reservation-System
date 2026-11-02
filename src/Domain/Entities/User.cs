using System;

namespace Domain.Entities;

public class User
{
    public User()
    {
    }

    public User(string name, string email, string password, string cpf)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
        CPF = cpf;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string CPF { get; private set; }
}
