using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamesStore.Persistence;

public static class ConfigurePersistenceProject
{
    public static IServiceCollection BuilderPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
