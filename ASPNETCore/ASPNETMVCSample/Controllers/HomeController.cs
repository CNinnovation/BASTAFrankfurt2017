using BooksLib;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVCSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult TagHelpers() =>
            View(new Book(0, "enter a title", "enter a publisher"));

        [HttpPost]
        public string UploadBook(Book b) =>
            $"book {b.Title} from {b.Publisher} uploaded";

        // ViewComponent instantiated from controller action
        public IActionResult Books1() =>
            ViewComponent("BooksList", "Wrox Press");

        // ViewComponent instantiated from view
        public IActionResult Books2() =>
            View();

        // ViewComponent instantiated using tag helpers
        public IActionResult Books3() =>
            View();
    }
}
