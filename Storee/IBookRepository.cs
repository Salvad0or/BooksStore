
namespace Storee
{
    public interface IBookRepository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
