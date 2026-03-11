using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        public DatabaseContext DatabaseContext { get; set; }

        public MaterialRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<Material> AddMaterial(Material material)
        {
            var materialDto = await DatabaseContext.Materials.AddAsync(material).AsTask().ContinueWith(task => task.Result.Entity);
            await DatabaseContext.SaveChangesAsync();
            return materialDto;
        }

        public async Task<Material?> GetMaterialByName(string name) 
        { 
            return await DatabaseContext.Materials.FirstOrDefaultAsync(m => m.Name == name);
        }

        public async Task<IEnumerable<Material?>> GetMaterialsByType(string type) 
        { 
            return await DatabaseContext.Materials.Where(m => m.Type == type).ToListAsync();
        }

        public async Task<IEnumerable<Material>> GetAllMaterials()
        {
            return await DatabaseContext.Materials.ToListAsync();
        }

        public async Task<Material> UpdateMaterial(Material material)
        {
            var materialDto = DatabaseContext.Materials.Update(material).Entity;
            await DatabaseContext.SaveChangesAsync();
            return materialDto;
        }

        public void DeleteMaterial(Material material)
        {
            var materialDto = DatabaseContext.Materials.Remove(material).Entity;
            DatabaseContext.SaveChangesAsync();
        }
    }
}