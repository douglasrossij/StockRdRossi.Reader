using Application.Shared.Database;
using Domain.Repositories;

namespace Application.Repositories
{
    public class MaterialInputRepository : IMaterialInputRepository
    {
        private DatabaseContext DatabaseContext;

        public MaterialInputRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }
    }
}