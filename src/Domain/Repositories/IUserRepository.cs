using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User?> GetUserById(long id);
        public Task<User?> GetUserByUsername(string username);
    }
}