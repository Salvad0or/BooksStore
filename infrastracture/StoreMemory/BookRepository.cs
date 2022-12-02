using System;
using Storee;
using System.Linq;
namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
            new Book(1, "#124"),
            new Book(2, "#sdfsdf"),
            new Book(3, "gdb400")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    }
}
