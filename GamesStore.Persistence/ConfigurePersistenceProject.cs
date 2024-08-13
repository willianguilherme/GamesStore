using GamesStore.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamesStore.Persistence;

public static class ConfigurePersistenceProject
{
    public static IServiceCollection BuilderPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<GamesStoreDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("MainConnection")));

        return services;
    }
}
