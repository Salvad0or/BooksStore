using System;
using Storee;
using System.Linq;
namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
            new Book(1, "#124", "ISBN 12123-32145", "D.Martn"),
            new Book(2, "#sdfsdf", "ISBN 12123-32144", "D.Pushkin"),
            new Book(3, "gdb400", "ISBN 12123-32143", "D.Karleon")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }


        public Book[] SearchByIsbn(string isbn)
        {
            return books.Where(b => b.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books.Where(b => b.Author.Contains(titleOrAuthor)
                                 || b.Title.Contains(titleOrAuthor))
                        .ToArray();
        }

        
    }
}
