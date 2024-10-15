using Microsoft.AspNetCore.Mvc;

namespace ControllersExample_IActionResult.Controllers
{
    public class StoreController : Controller
    {
        [Route("/store/books/{id}")]
        public IActionResult Book()
        {
            // return File("/232105020001-KTPM.pdf", "application/pdf");
            return Content("<h1>Book Store</h1>", "text/html");
        }

    }
}
