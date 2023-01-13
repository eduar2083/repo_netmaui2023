namespace Cats.ViewModels;

public static class _DependencyContainer
{
    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddScoped<ICatsViewModel, CatsViewModel>();

        return services;
    }
}
