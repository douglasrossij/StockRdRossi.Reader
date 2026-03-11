using Domain.Shared.Database.Entities;

namespace Domain.Repositories
{
    public interface IClientRepository
    {
        public Task<Client> AddClient(Client client);
        public Task<IEnumerable<Client>> GetAllClients();
        public Task<Client> UpdateClient(Client client);
        public void DeleteClient(Client client);
    }
}