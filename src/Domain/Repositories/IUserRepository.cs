using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<User> AddUser(User user);
        public Task<User?> GetUserById(long id);
        public Task<User?> GetUserByUsername(string username);
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User> UpdateUser(User user);
        public void DeleteUser(User user);
    }
}