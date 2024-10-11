using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller    
    {
        [Route("home")]
        public ContentResult Index() {
            // return new ContentResult() {
            //     Content = "Hello from Index",
            //     ContentType = "text/plain"
            // };
            // return Content("Hello from Index", "text/plain");
            return Content("<h1>Welcome</h1> <h2>Nguyen Phuoc Thuan</h2>", "text/html");
        }

        [Route("about")]
        public string About() {
            return "hello world from About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact() {
            return "hello world from Contact";
        }

    }
}
