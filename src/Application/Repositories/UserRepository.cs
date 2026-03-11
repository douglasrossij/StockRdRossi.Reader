using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        public DatabaseContext DatabaseContext { get; set; }

        public UserRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<User> AddUser(User user)
        {
            var userDto = await DatabaseContext.Users.AddAsync(user).AsTask().ContinueWith(task => task.Result.Entity);
            await DatabaseContext.SaveChangesAsync();
            return userDto;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await DatabaseContext.Users.ToListAsync();
        }

        public async Task<User> UpdateUser(User user)
        {
            var userDto = DatabaseContext.Users.Update(user).Entity;
            await DatabaseContext.SaveChangesAsync();
            return userDto;
        }

        public void DeleteUser(User user)
        {
            var customer = DatabaseContext.Users.Remove(user).Entity;
            DatabaseContext.SaveChangesAsync();
        }
    }
}