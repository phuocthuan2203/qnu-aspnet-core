using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController
    {
        [Route("home")]
        public string Index() {
            return "hello world from Index";
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
