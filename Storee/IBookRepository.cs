
namespace Storee
{
    public interface IBookRepository
    {
        Book[] SearchByIsbn(string isbn);

        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);
        Book GetBookById(int id);
    }
}
