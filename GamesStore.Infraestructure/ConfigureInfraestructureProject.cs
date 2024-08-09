using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamesStore.Infraestructure;

public static class ConfigureInfraestructureProject
{
    public static IServiceCollection BuilderInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
