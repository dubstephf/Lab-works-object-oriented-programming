using Lab5.Application.Models.Users;

namespace Lab5.Application.Abstractions.Repositories;

public interface IUserRepository
{
    Task<User?> FindUserByUsername(string username);

    Task UpdateMoneyOfUserBalance(string username, long newMoneyValue);

    Task AddNewUser(string username, string password);
}