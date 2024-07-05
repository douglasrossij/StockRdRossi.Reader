using Domain.Shared.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Application.Shared.Database
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDatabaseConection(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var databaseConfig = serviceProvider.GetService<IOptions<DatabaseConfig>>()!.Value;

            services.AddDbContext<DatabaseContext>(
                options => options.UseSqlServer(databaseConfig.ToConnectionString()));
        }
    }
}