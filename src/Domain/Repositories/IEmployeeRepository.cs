using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAllEmployees();
        public Task<Employee?> GetEmployeeById(long id);
        public Task<Employee?> GetEmployeeByUsername(string name);
    }
}