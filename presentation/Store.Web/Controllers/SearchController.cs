using Microsoft.AspNetCore.Mvc;
using Store.Web.Domain;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService bookService;
        public SearchController(BookService bookservice)
        {
            this.bookService = bookService;
        }

         public IActionResult Index(string query)

        {
            var books = bookService.GetAllByQuery(query);
            return View(books);
        }
    }
}
