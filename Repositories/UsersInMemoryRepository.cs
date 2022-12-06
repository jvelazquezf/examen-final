using ExamenFinal.Models;
using ExamenFinal.Interfaces;


namespace ExamenFinal.Repositories
{
    public class UsersInMemoryRepository: IUserRepository
    {
        private readonly List<User> _users = new List<User>
        {
            new()
            {
                Id = 1,
                Fullname = "Jose Velazquez",
                Username = "jvelazquez",
                Password = "123456",
            }
        };
        public async Task<User?> GetUserByCredentials(string username, string password)
        {
            return _users.FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
        }
    }
}