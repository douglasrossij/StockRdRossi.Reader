using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IMaterialInputRepository, MaterialInputRepository>();
            services.AddTransient<IMaterialOutputRepository, MaterialOutputRepository>();
            services.AddTransient<IMaterialRepository, MaterialRepository>();
        }
    }
}