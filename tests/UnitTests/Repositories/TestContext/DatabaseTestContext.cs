using Application.Shared.Database;
using Microsoft.EntityFrameworkCore;

namespace UnitTests.Repositories.TestContext
{
    public class DatabaseTestContext() : DatabaseContext(
             new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(nameof(DatabaseContext))
                .Options)
    {
        public void CreateDatabase()
        {
            Database.EnsureCreated();
        }

        public void ResetTracking()
        {
            ChangeTracker.Clear();
        }

        public void DisposeDatabase()
        {
            Database.EnsureDeleted();
        }
    }
}