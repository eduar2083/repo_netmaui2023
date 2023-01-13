namespace Cats.Http.Repositories;

#nullable disable

public class CatsHttpRepository : ICatsHttpRepository
{
    private readonly HttpClient Client;
    private readonly IConfigurationSection ConfigurationSection;

    public CatsHttpRepository(HttpClient client,
                              IConfigurationSection configurationSection)
    {
        Client = client;
        ConfigurationSection = configurationSection;
    }

    public async ValueTask<ReadOnlyCollection<Cat>> GetCatsAsync()
    {
        return await Client.GetFromJsonAsync<ReadOnlyCollection<Cat>>(ConfigurationSection["cats"]);
    }
}
