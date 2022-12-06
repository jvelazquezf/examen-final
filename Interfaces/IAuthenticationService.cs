using ExamenFinal.Models;

namespace ExamenFinal.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string username, string password);
        Task<string> GenerateJwt(User user);
    }
}
