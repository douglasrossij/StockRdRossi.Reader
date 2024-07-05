using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IUserRepository _userRepository;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpGet(Name = "GetUser")]
        public async Task<IEnumerable<User>> Get()
        {
            var user = await _userRepository.GetAllUsers();
            return user;
        }
    }
}
