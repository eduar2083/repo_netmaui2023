namespace Cats.Models;

public class CatsModel : ICatsModel
{
    private readonly ICatsHttpRepository CatsHttpRepository;

    public CatsModel(ICatsHttpRepository catsHttpRepository) =>
        CatsHttpRepository = catsHttpRepository;

    public async Task<ReadOnlyCollection<Cat>> GetCatsAsync() =>
        await CatsHttpRepository.GetCatsAsync();
}
