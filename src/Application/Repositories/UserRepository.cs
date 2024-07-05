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

        public async Task<IEnumerable<User>> GetAllUsers() 
        {
            var students = await DatabaseContext.Users.ToListAsync();
            return students;
        }

        public User GetUserById(long id) => DatabaseContext.Users.SingleOrDefault(u => u.Id == id)!;

        public User GetUserByUsername(string username) => DatabaseContext.Users.SingleOrDefault(user => user.UserName.ToUpper() == username.ToUpper())!;
    }
}