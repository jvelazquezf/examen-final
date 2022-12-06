using ExamenFinal.Interfaces;
using ExamenFinal.Models;

namespace ExamenFinal.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> GetByCredentials(string username, string password)
        {
            return await _userRepository.GetUserByCredentials(username, password);
        }
    }
}
