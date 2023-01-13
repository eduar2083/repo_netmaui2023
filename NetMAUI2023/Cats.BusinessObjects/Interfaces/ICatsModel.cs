namespace Cats.BusinessObjects.Interfaces;

public interface ICatsModel
{
    Task<ReadOnlyCollection<Cat>> GetCatsAsync();
}
