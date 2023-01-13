namespace Cats.Models;

public static class _DependencyContainer
{
    public static IServiceCollection AddModels(this IServiceCollection services)
    {
        services.AddScoped<ICatsModel, CatsModel>();

        return services;
    }
}
