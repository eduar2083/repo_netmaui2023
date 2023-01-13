namespace Cats.Http.Repositories;

#nullable disable

public static class _DependencyContainer
{
    public static IServiceCollection AddHttpRepositories(this IServiceCollection services,
                                                         IConfigurationSection configurationSection)
    {
        IHttpClientBuilder Builder = services.AddHttpClient<ICatsHttpRepository, CatsHttpRepository>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(configurationSection["baseUrl"]);
        });

        return services;
    }
}
