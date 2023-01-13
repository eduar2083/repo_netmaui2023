namespace Cats.BusinessObjects.Interfaces;

public interface ICatsHttpRepository
{
    ValueTask<ReadOnlyCollection<Cat>> GetCatsAsync();
}
