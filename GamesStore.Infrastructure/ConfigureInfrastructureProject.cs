using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamesStore.Infrastructure;

public static class ConfigureInfrastructureProject
{
    public static IServiceCollection BuilderInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
