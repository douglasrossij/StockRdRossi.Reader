using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IMaterialRepository, MaterialRepository>();
        }
    }
}