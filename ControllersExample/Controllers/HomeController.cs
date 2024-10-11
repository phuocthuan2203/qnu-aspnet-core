using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController
    {
        [Route("hello")]
        public string method1() {
            return "hello world from method1";
        }

    }
}
