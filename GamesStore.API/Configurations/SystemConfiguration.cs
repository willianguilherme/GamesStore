namespace GamesStore.API.Configurations;

public static class SystemConfiguration
{
    private static string _systemVersion { get; set; } = string.Empty;
    public static string SystemVersion { get { return _systemVersion; } }

    public static IServiceCollection GetSystemConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        string? systemVersion = configuration.GetSection("SystemInformation:SystemVersion").Value;

        if (string.IsNullOrEmpty(systemVersion))
        {
            throw new InvalidOperationException("A configuração 'SystemInformation:SystemVersion' não foi encontrada ou está vazia.");
        }

        _systemVersion = systemVersion;
        return services;
    }
}
