namespace Cats.ViewModels;

internal class CatsViewModel : ICatsViewModel
{
    private readonly ICatsModel Model;

    public CatsViewModel(ICatsModel model) =>
        Model = model;

    public async ValueTask<ReadOnlyCollection<Cat>> GetCats() =>
        await Model.GetCatsAsync();
}
