using Storee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Tests
{
    internal class StubBookRepository : IBookRepository
    {

        public Book[] ROfGetAllByTitleOrAuthor { get; set; }

        public Book[] ROfSearchByIsbn { get; set; }
        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return ROfGetAllByTitleOrAuthor;
        }

        public Book[] SearchByIsbn(string isbn)
        {
            return ROfSearchByIsbn;
        }
    }
}
