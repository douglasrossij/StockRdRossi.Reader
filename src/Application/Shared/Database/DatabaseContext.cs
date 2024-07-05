using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Shared.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Material> Materials { get; set; } = null!;
        public DbSet<MaterialInput> MaterialInput { get; set; } = null!;
        public DbSet<MaterialOutput> MaterialOutput { get; set; } = null!;
    }
}