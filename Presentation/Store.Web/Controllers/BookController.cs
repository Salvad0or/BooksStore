using Microsoft.AspNetCore.Mvc;
using Storee;

namespace Store.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository _bookRepository)
        {
            bookRepository = _bookRepository;
        }

        public IActionResult Index(int ass)
        {
            Book book = bookRepository.GetBookById(ass);

            return View(book);
        }
    }
}
