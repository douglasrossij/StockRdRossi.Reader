using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        [HttpPost("add-employee")]
        public async Task<Employee> Add(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }

        [HttpGet("get-employees")]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        [HttpPut("update-employee")]
        public async Task<Employee> Update(Employee employee)
        {
            return await _employeeRepository.UpdateEmployee(employee);
        }

        [HttpDelete("delete-employee")]
        public void Delete(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }
    }
}