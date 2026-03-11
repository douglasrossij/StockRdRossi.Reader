using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<IEnumerable<Employee>> GetAllEmployees();
        public Task<Employee> UpdateEmployee(Employee employee);
        public void DeleteEmployee(Employee employee);
    }
}