using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamesStore.Application;

public static class ConfigureApplicationProject
{
    public static IServiceCollection BuilderApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
