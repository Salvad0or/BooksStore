using Microsoft.AspNetCore.Mvc;
using Storee;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private IBookRepository bookRepository;

        public SearchController(IBookRepository bookRep)
        {
            bookRepository = bookRep;
        }

        public IActionResult Index(string query)
        {

            var books = bookRepository.GetAllByTitle(query);

            return View(books);
        }
    }
}
