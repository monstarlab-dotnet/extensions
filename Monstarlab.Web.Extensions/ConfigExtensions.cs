namespace Monstarlab.Web.Extensions;

public static class ConfigExtensions
{
    public static IServiceCollection AddConfig<T>(
        this IServiceCollection services,
        IConfigurationSection configurationSection)
        where T : class, new()
    {
        var config = new T();
        configurationSection.Bind(config);
        services.AddSingleton(config);

        return services;
    }
}
