using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DatabaseContext DatabaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<IEnumerable<User>> GetAllUsers ()
        { 
            return await DatabaseContext.Users.ToListAsync();
        }

        public async Task<User?> GetUserById(long id) => await DatabaseContext.Users.FirstOrDefaultAsync(u => u.Id == id);

        public async Task<User?> GetUserByUsername(string username) => await DatabaseContext.Users.FirstOrDefaultAsync(u => u.UserName.ToUpper() == username.ToUpper())!;
    }
}