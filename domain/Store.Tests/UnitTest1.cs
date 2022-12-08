using Storee;
using Xunit;

namespace Store.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 103-124-124 0 ");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx IsBn 103-124-124 0 xxs");

            Assert.False(actual);
        }

        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByIsbn()
        {

            const int idOfIsbnSearch = 1;
            const int idOfAutorSearch = 2;

            var bookRep = new StubBookRepository();

            bookRep.ROfSearchByIsbn = new[]
            {
                new Book(idOfIsbnSearch, "","","", "ha-hahaha", 10),
            };

            bookRep.ROfGetAllByTitleOrAuthor = new[]
            {
                new Book(idOfAutorSearch, "","","", "ha-sdfa", 11),
            };

            var bookService = new BookService(bookRep);

            var books = bookService.GetAllByQuery("ISBN 12345-67890");

            Assert.Collection(books, a => Assert.Equal(idOfIsbnSearch, a.Id));
        }

        [Fact]
        public void GetAllByQuery_WithAutor_CallsGetAllByIsbn()
        {

            const int idOfIsbnSearch = 1;
            const int idOfAutorSearch = 2;

            var bookRep = new StubBookRepository();

            bookRep.ROfSearchByIsbn = new[]
            {
                new Book(idOfIsbnSearch, "","","", "ha-sdfa", 11),
            };

            bookRep.ROfGetAllByTitleOrAuthor = new[]
            {
                new Book(idOfAutorSearch, "","","Alex", "ha-sdfa", 11),
            };

            var bookService = new BookService(bookRep);

            var books = bookService.GetAllByQuery("Alex");

            Assert.Collection(books, a => Assert.Equal(idOfAutorSearch, a.Id));
        }
    }
}
