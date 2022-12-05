using System;
using System.Collections.Generic;
using System.Text;

namespace Storee
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookrepos)
        {
            _bookRepository = bookrepos;
        }


        public Book[] GetAllByQuery(string query)
        {
            if (Book.IsIsbn(query))
            {
                return _bookRepository.SearchByIsbn(query);
            }

            return _bookRepository.GetAllByTitleOrAuthor(query);
        }
    }
}
