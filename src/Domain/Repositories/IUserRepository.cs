using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public User GetUserById(long id);
        public User GetUserByUsername(string username);
    }
}