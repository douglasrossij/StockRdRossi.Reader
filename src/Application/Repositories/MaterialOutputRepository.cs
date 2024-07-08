using Application.Shared.Database;
using Domain.Repositories;

namespace Application.Repositories
{
    public class MaterialOutputRepository : IMaterialOutputRepository
    {
        private DatabaseContext DatabaseContext;

        public MaterialOutputRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }
    }
}