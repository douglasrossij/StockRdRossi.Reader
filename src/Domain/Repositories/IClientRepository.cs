using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IClientRepository
    {
        public Task<IEnumerable<Client>> GetAllClients();
        public Task<Client?> GetClientById(long id);
        public Task<Client?> GetClientByUsername(string name);
    }
}