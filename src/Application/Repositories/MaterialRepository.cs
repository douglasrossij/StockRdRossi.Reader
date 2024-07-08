using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private DatabaseContext DatabaseContext;

        public MaterialRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<IEnumerable<Material>> GetAllMaterials() => await DatabaseContext.Materials.ToListAsync();

        public async Task<Material?> GetMaterialById(long id) => await DatabaseContext.Materials.FirstOrDefaultAsync(m => m.Id == id);

        public async Task<Material?> GetMaterialByName(string name) => await DatabaseContext.Materials.FirstOrDefaultAsync(m => m.Name.ToUpper() == name.ToUpper())!;
    }
}