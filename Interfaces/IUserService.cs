using ExamenFinal.Models;
namespace ExamenFinal.Interfaces
{
    public interface IUserService
    {
        Task<User> GetByCredentials(string username, string password);
    }
}
