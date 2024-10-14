using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

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

        [Route("person")]
        public JsonResult Person() {
            Person person = new Person() {
                Id = Guid.NewGuid(),
                FirstName = "Thuan",
                LastName = "Nguyen",
                Age = 21
            };
            // return new JsonResult(person);
            return Json(person);
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
