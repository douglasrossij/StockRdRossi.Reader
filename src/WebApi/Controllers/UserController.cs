using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpPost("add-user")]
        public async Task<User> Add(User user)
        {       
            return await _userRepository.AddUser(user);
        }

        [HttpGet("get-user-by-id")]
        public async Task<User?> GetById(long id)
        {
            return await _userRepository.GetUserById(id);
        }

        [HttpGet("get-user-by-username")]
        public async Task<User?> GetByUsername(string username)
        {
           return await _userRepository.GetUserByUsername(username);
        }

        [HttpGet("get-users")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userRepository.GetAllUsers();
        }

        [HttpPut("update-user")]
        public async Task<User> Update(User user)
        {
           return await _userRepository.UpdateUser(user);
        }

        [HttpDelete("delete-user")]
        public void Delete(User user)
        {
            _userRepository.DeleteUser(user);
        }
    }
}