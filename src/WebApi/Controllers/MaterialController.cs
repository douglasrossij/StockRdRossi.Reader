using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("material")]
    public class MaterialController : ControllerBase
    {
        private IMaterialRepository _materialRepository;

        public MaterialController(IMaterialRepository materialRepository)
        { 
            _materialRepository = materialRepository;
        }

        [HttpPost("add-material")]
        public async Task<Material> Add(Material material)
        {
            return await _materialRepository.AddMaterial(material);
        }

        [HttpGet("get-materials")]
        public async Task<IEnumerable<Material>> Get()
        {
            return await _materialRepository.GetAllMaterials();
        }

        [HttpPut("update-material")]
        public async Task<Material> Update(Material material)
        {
            return await _materialRepository.UpdateMaterial(material);
        }

        [HttpDelete("delete-material")]
        public void Delete(Material material)
        {
            _materialRepository.DeleteMaterial(material);
        }
    }
}