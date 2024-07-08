using Application.Shared.Database;
using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DatabaseContext DatabaseContext;

        public ClientRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public async Task<IEnumerable<Client>> GetAllClients() => await DatabaseContext.Clients.ToListAsync();

        public async Task<Client?> GetClientById(long id) => await DatabaseContext.Clients.FirstOrDefaultAsync(u => u.Id == id);

        public async Task<Client?> GetClientByUsername(string name) => await DatabaseContext.Clients.FirstOrDefaultAsync(user => user.Name.ToUpper() == name.ToUpper())!;
    }
}