using Moq;
using Storee;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Store.Tests
{
    public class BookServiceTest
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByIsbn()
        {
            Mock<IBookRepository> bookRepositoryStub = new Mock<IBookRepository>();

            bookRepositoryStub.Setup(x => x.SearchByIsbn(It.IsAny<string>()))
                              .Returns(new[] { new Book(1, "", "", "") });

            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                              .Returns(new[] { new Book(2, "", "", "") });

            var bookservice = new BookService(bookRepositoryStub.Object);

            string isValid = "ISBN 12345-67890";

            var actual = bookservice.GetAllByQuery(isValid);

            Assert.Collection(actual, book => Assert.Equal(1, book.Id));
        }

         [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByTitleOrAuthor()
        {
            Mock<IBookRepository> bookRepositoryStub = new Mock<IBookRepository>();

            bookRepositoryStub.Setup(x => x.SearchByIsbn(It.IsAny<string>()))
                              .Returns(new[] { new Book(1, "", "", "") });

            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                              .Returns(new[] { new Book(2, "", "", "") });

            var bookservice = new BookService(bookRepositoryStub.Object);

            string isInvalid = "12345-67890";

            var actual = bookservice.GetAllByQuery(isInvalid);

            Assert.Collection(actual, book => Assert.Equal(2, book.Id));
        }
    }
}
