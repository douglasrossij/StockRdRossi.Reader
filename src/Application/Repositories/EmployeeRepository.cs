using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DatabaseContext DatabaseContext;

        public EmployeeRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees() => await DatabaseContext.Employees.ToListAsync();

        public async Task<Employee?> GetEmployeeById(long id) => await DatabaseContext.Employees.FirstOrDefaultAsync(u => u.Id == id);

        public async Task<Employee?> GetEmployeeByUsername(string name) => await DatabaseContext.Employees.FirstOrDefaultAsync(user => user.Name.ToUpper() == name.ToUpper())!;
    }
}