using Domain.Repositories;
using Domain.Shared.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("client")]
    public class ClientController : ControllerBase
    {
        private IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpPost("add-client")]
        public async Task<Client> Add(Client client)
        {
            return await _clientRepository.AddClient(client);
        }

        [HttpGet("get-client-by-name")]
        public async Task<Client?> GetByName(string name)
        {
            return await _clientRepository.GetClientByName(name);
        }

        [HttpGet("get-clients")]
        public async Task<IEnumerable<Client>> Get()
        {
            return await _clientRepository.GetAllClients();
        }

        [HttpPut("update-client")]
        public async Task<Client> Update(Client client)
        {
            return await _clientRepository.UpdateClient(client);
        }

        [HttpDelete("delete-client")]
        public async Task Delete(Client client)
        {
            _clientRepository.DeleteClient(client);
        }
    }
}