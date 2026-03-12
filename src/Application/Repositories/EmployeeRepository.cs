using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public DatabaseContext DatabaseContext { get; set; }

        public EmployeeRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var employeeDto = (await DatabaseContext.Employees.AddAsync(employee)).Entity;
            await DatabaseContext.SaveChangesAsync();
            return employeeDto;
        }

        public async Task<Employee?> GetEmployeeByName(string name)
        {
            return await DatabaseContext.Employees.FirstOrDefaultAsync(e => e.Name == name);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await DatabaseContext.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeeDto = DatabaseContext.Employees.Update(employee).Entity;
            await DatabaseContext.SaveChangesAsync();
            return employeeDto;
        }

        public async Task DeleteEmployee(Employee employee)
        {
            DatabaseContext.Employees.Remove(employee);
            await DatabaseContext.SaveChangesAsync();
        }
    }
}