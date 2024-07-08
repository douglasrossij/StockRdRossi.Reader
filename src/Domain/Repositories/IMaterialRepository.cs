using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IMaterialRepository
    {
        public Task<IEnumerable<Material>> GetAllMaterials();
        public Task<Material?> GetMaterialById(long id);
        public Task<Material?> GetMaterialByName(string name);
    }
}