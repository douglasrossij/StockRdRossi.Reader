using Application.Repositories;
using Domain.Shared.Database.Entities;
using UnitTests.Repositories.TestContext;

namespace UnitTests.Repositories
{
    public class UserRepositoryTest
    {
        private DatabaseTestContext dbTestContext = new DatabaseTestContext();
        private IEnumerable<User> Users => CreateUsers();

       [Fact]
        public void GetAllUsers_Should_Return_All_Users()
        {
            //Arrange
            CreateDatabaseWithUsers();

            //Act
            var repository = new UserRepository(dbTestContext);
            var users = repository.GetAllUsers().Result;

            //Assert
            Assert.Equal(Users.Count(), users.Count());

            DisposeConnection();
        }

        [Fact]
        public void GetAllUsers_Should_Return_User_By_Id()
        {
            //Arrange
            CreateDatabaseWithUsers();
            var expectedUser = Users.FirstOrDefault();

            //Act
            var repository = new UserRepository(dbTestContext);
            var user = repository.GetUserById(expectedUser!.Id).Result;

            //Assert
            Assert.Equal(expectedUser.Id, user.Id);
            Assert.Equal(expectedUser.UserName, user.UserName);
            Assert.Equal(expectedUser.Password, user.Password);
            Assert.Equal(expectedUser.IsAdministrator, user.IsAdministrator);

            DisposeConnection();
        }

        [Fact]
        public void GetAllUsers_Should_Return_User_By_Username()
        {
            //Arrange
            CreateDatabaseWithUsers();
            var expectedUser = Users.FirstOrDefault();

            //Act
            var repository = new UserRepository(dbTestContext);
            var user = repository.GetUserByUsername(expectedUser!.UserName).Result;

            //Assert
            Assert.Equal(expectedUser.Id, user.Id);
            Assert.Equal(expectedUser.UserName, user.UserName);
            Assert.Equal(expectedUser.Password, user.Password);
            Assert.Equal(expectedUser.IsAdministrator, user.IsAdministrator);

            DisposeConnection();
        }

        private void CreateDatabaseWithUsers()
        {
            dbTestContext.CreateDatabase();
            dbTestContext.Users.AddRange(Users);
            dbTestContext.SaveChanges();
        }

        private void DisposeConnection() 
        {
            dbTestContext.DisposeDatabase();
        }

        private IEnumerable<User> CreateUsers()
        {
            var users = new List<User>();

            users.Add(new User()
            {
                Id = 1,
                IsAdministrator = true,
                Password = "password1",
                UserName = "Test1",
            });

            users.Add(new User()
            {
                Id = 2,
                IsAdministrator = false,
                Password = "password2",
                UserName = "Test2",
            });

            users.Add(new User()
            {
                Id = 3,
                IsAdministrator = false,
                Password = "password3",
                UserName = "Test3",
            });

            return users.AsQueryable();
        }
    }
}