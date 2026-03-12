using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<User> AddUser(User user);
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User> UpdateUser(User user);
        public Task DeleteUser(User user);
    }
}