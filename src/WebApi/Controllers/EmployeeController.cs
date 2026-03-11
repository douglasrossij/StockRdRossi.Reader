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

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost("add-employee")]
        public async Task<Employee> Add(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }

        [HttpGet("get-employee-by-name")]
        public async Task<Employee?> GetByName(string name)
        {
            return await _employeeRepository.GetEmployeeByName(name);
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