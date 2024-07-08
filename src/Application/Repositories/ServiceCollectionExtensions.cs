using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IMaterialInputRepository, MaterialInputRepository>();
            services.AddScoped<IMaterialOutputRepository, MaterialOutputRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
        }
    }
}