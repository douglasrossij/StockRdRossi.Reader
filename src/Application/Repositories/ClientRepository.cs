using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public DatabaseContext DatabaseContext { get; set; }

        public ClientRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<Client> AddClient(Client client)
        {
            var clientDto = (await DatabaseContext.Clients.AddAsync(client)).Entity;
            await DatabaseContext.SaveChangesAsync();
            return clientDto;
        }

        public async Task<Client?> GetClientByName(string name) 
        { 
            return await DatabaseContext.Clients.FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await DatabaseContext.Clients.ToListAsync();
        }

        public async Task<Client> UpdateClient(Client client)
        {
            var clientDto = DatabaseContext.Clients.Update(client).Entity;
            await DatabaseContext.SaveChangesAsync();
            return clientDto;
        }

        public async Task DeleteClient(Client client)
        {
            DatabaseContext.Clients.Remove(client);
            await DatabaseContext.SaveChangesAsync();
        }
    }
}