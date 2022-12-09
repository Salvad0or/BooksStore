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

        public IActionResult Index(int query)
        {
            Book book = bookRepository.GetBookById(query);

            return View(book);
        }
    }
}
