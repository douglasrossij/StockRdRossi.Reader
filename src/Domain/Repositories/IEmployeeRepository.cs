using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<Employee?> GetEmployeeById(long id);
        public Task<Employee?> GetEmployeeByName(string name);
        public Task<IEnumerable<Employee>> GetAllEmployees();
        public Task<Employee> UpdateEmployee(Employee employee);
        public void DeleteEmployee(Employee employee);
    }
}