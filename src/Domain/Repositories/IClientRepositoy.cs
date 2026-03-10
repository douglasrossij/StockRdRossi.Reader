using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IClientRepository
    {
        public Task<Client> AddClient(Client client);
        public Task<Client?> GetClientById(long id);
        public Task<Client?> GetClientByName(string name);
        public Task<IEnumerable<Client>> GetAllClients();
        public Task<Client> UpdateClient(Client client);
        public void DeleteClient(Client client);
    }
}