using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IMaterialRepository
    {
        public Task<Material> AddMaterial(Material material);
        public Task<IEnumerable<Material>> GetAllMaterials();
        public Task<Material> UpdateMaterial(Material material);
        public void DeleteMaterial(Material material);
    }
}