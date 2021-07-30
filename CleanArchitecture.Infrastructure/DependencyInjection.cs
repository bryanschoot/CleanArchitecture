using CleanArchitecture.Infrastructure.Database;
using CleanArchitecture.Infrastructure.Database.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(c =>
            {
                // c.UseSqlServer(configuration.GetConnectionString(DatabaseOptions.ConnectionString));
                c.UseInMemoryDatabase(DatabaseOptions.Database);
            });

            return services;
        }
    }
}
