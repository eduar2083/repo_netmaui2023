namespace Cats.ViewModels;

#nullable disable

internal class CatsViewModel : ICatsViewModel
{

    private readonly ICatsModel Model;

    public CatsViewModel(ICatsModel model) =>
        Model = model;



    public async Task GetCatsAsync()
    {
        Cats = await Model.GetCatsAsync();

    }

    public IReadOnlyCollection<Cat> Cats { get; private set; }
}
