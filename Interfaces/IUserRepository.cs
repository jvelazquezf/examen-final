using ExamenFinal.Models;

namespace ExamenFinal.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByCredentials(string username, string password);
    }
}
