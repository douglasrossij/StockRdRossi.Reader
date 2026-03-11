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
            var employeeDto = await DatabaseContext.Employees.AddAsync(employee).AsTask().ContinueWith(task => task.Result.Entity);
            await DatabaseContext.SaveChangesAsync();
            return employeeDto;
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

        public void DeleteEmployee(Employee employee)
        {
            var employeeDto = DatabaseContext.Employees.Remove(employee).Entity;
            DatabaseContext.SaveChanges();
        }
    }
}