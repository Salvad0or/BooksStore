using Microsoft.AspNetCore.Mvc;
using Storee;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private BookService BookService;

        public SearchController(BookService bookService)
        {
            BookService = bookService;
        }

        public IActionResult Index(string query)
        {

            //var books = bookRepository.GetAllByTitle(query);

            Book[] books = BookService.GetAllByQuery(query);

            return View(books);
        }
    }
}
