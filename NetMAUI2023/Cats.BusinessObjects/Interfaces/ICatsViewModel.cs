namespace Cats.BusinessObjects.Interfaces;

public interface ICatsViewModel
{
    ValueTask<ReadOnlyCollection<Cat>> GetCats();
}
