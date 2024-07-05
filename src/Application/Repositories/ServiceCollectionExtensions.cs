using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}